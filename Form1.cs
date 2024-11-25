using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using uOSC;
using System.Numerics;


namespace UnnaturalPoseDetector
{
    public partial class Form1 : Form
    {
        private const int UPD_DEFAULT_PORT = 39544;
        const int Y_DIFF_MAX_DEF = 30;
        const int Z_DIFF_MAX_DEF = 30;
        int yDiffMax = 30;
        int zDiffMax = 30;

        Parser parser_ = new Parser();

        public UdpClient txClient;          // 送信用ソケット
        public UdpClient rxClient;          // 受信用ソケット
        public IPEndPoint remoteEP;         // RxClientのReceiveメソッドの引き数
        public byte[] rxData;               // 受信データ格納用配列
        public string strRx = "受信";       // ボタン表示用
        public string strStop = "停止";     // ボタン表示用
                                          //
        public delegate void SetTextDelegate(string text);
        Quaternion qWaist = Quaternion.Identity;
        Quaternion qChest = Quaternion.Identity;

        private System.Media.SoundPlayer player = null;
        string SoundFile = "c:\\Windows\\Media\\tada.wav";

        DateTime dtStartSound = new DateTime();
        bool forwardMode = false;

        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }

        private void PlaySound()
        {
            player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
            dtStartSound = DateTime.Now;
        }
        public Form1()
        {
            InitializeComponent();
            txClient = new UdpClient();
            this.textBoxListenPort.Text = UPD_DEFAULT_PORT.ToString();
            this.textBoxThresY.Text = Y_DIFF_MAX_DEF.ToString();
            this.textBoxThresZ.Text = Z_DIFF_MAX_DEF.ToString();
            this.labelThres.Text = $"Threshold: (Y, Z) = ( {yDiffMax}, {zDiffMax} )";
            this.labelSoundFile.Text = SoundFile;
        }

        void UpdateLabelThres()
        {
            Invoke(new SetTextDelegate(SetLabelThres), $"Threshold: (Y, Z) = ( {yDiffMax}, {zDiffMax} )");
        }

        int GetTextBoxInt(TextBox tbox, int defaultValue)
        {
            int nTry = 0;
            try
            {
                nTry = int.Parse(tbox.Text);
            }
            catch
            {
                nTry = UPD_DEFAULT_PORT;
            }
            return nTry;
        }
        int GetThres(TextBox tbox, int defaultValue)
        {
            int nTry = 0;
            try
            {
                nTry = int.Parse(tbox.Text);
                if (nTry < 10) nTry = 10;
                if (nTry > 180) nTry = 180;
            }
            catch
            {
                nTry = defaultValue;
            }
            return nTry;
        }
        private void btnListen_Click(object sender, EventArgs e)
        {
            Console.Write("btnListen_Click called\n");

            if (btnListen.Text == strRx || btnListen.Text != strStop)
            {
                labelLog.Text = "Listening";
                // 受信用ソケットを初期化
                int portListen = GetTextBoxInt(textBoxListenPort, UPD_DEFAULT_PORT);

                yDiffMax = GetThres(textBoxThresY, Y_DIFF_MAX_DEF);
                zDiffMax =  GetThres(textBoxThresZ, Z_DIFF_MAX_DEF);

                UpdateLabelThres();

                rxClient = new UdpClient(portListen);
                rxClient.BeginReceive(ReceiveCallback, null);
                // ボタン表示を変更
                btnListen.Text = strStop;
            }
            else if (btnListen.Text == strStop)
            {
                labelLog.Text = "Stopped";
                StopSound();

                // ソケットを切断
                rxClient.Close();
                // ボタン表示を変更
                btnListen.Text = strRx;
            }
        }

        // 受信処理用メソッド
        void ReceiveCallback(IAsyncResult ar)
        {
            // 受信データの送信元情報が格納されるremoteEPはnullにしておく。
            remoteEP = null;
            try
            {
                rxData = rxClient.EndReceive(ar, ref remoteEP);

                if ( forwardMode )
                {
                    int nPort = GetTextBoxInt(textBoxListenPort, 0); 
                    if ( nPort != 0 )
                    {
                        txClient.Send(rxData, rxData.Length, "127.0.0.1", nPort);
                    }
                }

                int pos = 0;
                parser_.Parse(rxData, ref pos, rxData.Length);

                while (parser_.messageCount > 0)
                {
                    var message = parser_.Dequeue();
                    string msgtext = message.ToString();
                    //    Console.WriteLine(msgtext);
                    int idxChest = msgtext.IndexOf("human://CHEST");
                    int idxWaist = msgtext.IndexOf("human://WAIST");
                    Quaternion q = Quaternion.Identity;
                    if (msgtext.IndexOf("human://")>0)
                    {
                        q.X = (float)message.values[4];
                        q.Y = (float)message.values[5];
                        q.Z = (float)message.values[6];
                        q.W = (float)message.values[7];
//                        Invoke(new SetTextDelegate(SetText), $" Quartenion q = {q}\n");
                    }
                    Vector3 v = Q2EularSlime(q);

                    //Invoke(new SetTextDelegate(SetText), $" {msgtext}\n");
                    if (idxChest > 0 )
                    {
                        qChest = q;
                        //Invoke(new SetTextDelegate(SetText), $" qChest = {qChest}\n");
                        //Invoke(new SetTextDelegate(SetText), $" vChest = {v}\n");
                        Invoke(new SetTextDelegate(SetChestEular), "Chest Rot: " + v.ToString());
                    }
                    else if ( idxWaist > 0)
                    {
                        qWaist= q;
                        //Invoke(new SetTextDelegate(SetText), $" qWaist= {qWaist}\n");
                        //Invoke(new SetTextDelegate(SetText), $" vWais= {v}\n");
                        Invoke(new SetTextDelegate(SetWaistEuler), "Waist Rot: " + v.ToString());
                    }

                    if ( idxWaist > 0 || idxChest > 0 )
                    {
                        Vector3 eularWaist = Q2EularSlime(qWaist);
                        Vector3 eularChest= Q2EularSlime(qChest);
                        float diffY = NormalizeAngle(eularWaist.Y - eularChest.Y);
                        float diffZ = NormalizeAngle(eularWaist.Z - eularChest.Z);
                        Invoke(new SetTextDelegate(SetDiffLabel), $"Diff: Y = {diffY.ToString()}, Z = {diffZ.ToString()}");
                        bool notified = false;
                        if (diffY < yDiffMax && diffY > -yDiffMax)
                        {
                            // OK
                        }
                        else
                        {
                            Invoke(new SetTextDelegate(SetText), $"Y difference {diffY}\n");
                            notified = true;
                        }
                        if (diffZ < zDiffMax && diffZ > -zDiffMax)
                        {
                            // OK
                        }
                        else
                        {
                            Invoke(new SetTextDelegate(SetText), $"Z difference {diffZ}\n");
                            notified = true;
                        }

                        //終了時間の取得
                        DateTime end = new DateTime();
                        end = DateTime.Now;
                        TimeSpan diffTime = end - dtStartSound;
                        if ( diffTime.TotalSeconds >= 30.0 )
                        {
                            StopSound();
                        }

                        if ( notified && player == null)
                        {
                            PlaySound();
                        }

                    }
                }

                // 受信データをテキストボックスに表示
                // 再び受信開始
                rxClient.BeginReceive(ReceiveCallback, null);
            }
            catch (ObjectDisposedException ode)
            {
                // BeginReceiveの実施中にソケットをCloseするとスローされる例外
                // 何もしない
            }
        }

        public static Vector3 Q2EularSlime(Quaternion q1)
        {
            float sqw = q1.W * q1.W;
            float sqx = q1.X * q1.X;
            float sqy = q1.Y * q1.Y;
            float sqz = q1.Z * q1.Z;
            float unit = sqx + sqy + sqz + sqw; // if normalised is one, otherwise is correction factor
            float test = q1.X * q1.W - q1.Y * q1.Z;
            Vector3 v;
            const double Rad2Deg = 360/(Math.PI * 2);
            if (test>0.4995f*unit)
            { // singularity at north pole
                v.Y = (float)(2f * Math.Atan2(q1.Y, q1.X)* Rad2Deg);
                v.X = (float)(Math.PI / 2* Rad2Deg);
                v.Z = 0;
                return NormalizeAngles(v);
            }
            if (test<-0.4995f*unit)
            { // singularity at south pole
                v.Y = (float)(-2f * Math.Atan2(q1.Y, q1.X)* Rad2Deg);
                v.X = (float)(-Math.PI / 2 * Rad2Deg);
                v.Z = 0;
                return NormalizeAngles(v);
            }
            Quaternion q = new Quaternion(q1.W, q1.Z, q1.X, q1.Y);
            v.Y = 360-(float)(Math.Atan2(2f * q.X * q.W + 2f * q.Y * q.Z, 1 - 2f * (q.Z * q.Z + q.W * q.W))* Rad2Deg);     // Yaw
            v.X = 360-(float)(Math.Asin(2f * (q.X * q.Z - q.W * q.Y))* Rad2Deg);                             // Pitch
            v.Z = (float)(Math.Atan2(2f * q.X * q.Y + 2f * q.Z * q.W, 1 - 2f * (q.Y * q.Y + q.Z * q.Z))* Rad2Deg);      // Roll
            return NormalizeAngles(v);
        }

        static Vector3 NormalizeAngles(Vector3 angles)
        {
            angles.X = NormalizeAngle(angles.X);
            angles.Y = NormalizeAngle(angles.Y);
            angles.Z = NormalizeAngle(angles.Z);
            return angles;
        }

        static float NormalizeAngle(float angle)
        {
            while (angle>180)
                angle -= 360;
            while (angle<-180)
                angle += 360;
            return angle;
        }

        // サブスレッドからのテキストボックスへの書込み処理用メソッド
        public void SetText(string text)
        {
            // テキストボックスに引数の文字列を追記
            richTextBox1.AppendText(text);
            // カーソルを最後尾に移動
            richTextBox1.Select(richTextBox1.TextLength, 0);
            richTextBox1.ScrollToCaret();
        }

        public void SetChestEular(string text)
        {
            labelRotChest.Text = text;
        }
        public void SetWaistEuler(string text)
        {
            labelRotWaist.Text = text;
        }
        public void SetDiffLabel(string text)
        {
            labelDiff.Text = text;
        }

        public void SetLabelThres(string text)
        {
            labelThres.Text = text;
        }


        // 「×」ボタンクリック時の処理
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.Write("Form1_FormClosing called\n");
            // ソケットを切断
            if (rxClient != null)
            {
                rxClient.Close();
            }
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string[] strs = SoundFile.Split('\\');
            ofd.FileName = strs[strs.Length-1];
            ofd.InitialDirectory = SoundFile.Substring(0, SoundFile.Length-ofd.FileName.Length-1);
            ofd.Filter = "WAV(*.wav)|*.wav";
            ofd.FilterIndex = 1;
            ofd.Title = "ファイルを選択してください";
            ofd.RestoreDirectory = false;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);
                SoundFile = ofd.FileName;
                labelSoundFile.Text = SoundFile;
            }
        }
        private void btnFwd_Click(object sender, EventArgs e)
        {
            forwardMode = !forwardMode;
        }
    }
}
