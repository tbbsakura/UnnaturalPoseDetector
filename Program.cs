using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnnaturalPoseDetector
{

    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainForm = new Form1();
            mainForm.Show();

            while (mainForm.Created)
            {
                mainForm.Update();
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }

        }
    }
}
