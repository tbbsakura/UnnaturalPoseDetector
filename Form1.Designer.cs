namespace UnnaturalPoseDetector
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListen = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxListenPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPortForwardTo = new System.Windows.Forms.TextBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelRotChest = new System.Windows.Forms.Label();
            this.labelRotWaist = new System.Windows.Forms.Label();
            this.labelDiff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThresY = new System.Windows.Forms.TextBox();
            this.textBoxThresZ = new System.Windows.Forms.TextBox();
            this.labelThres = new System.Windows.Forms.Label();
            this.buttonSound = new System.Windows.Forms.Button();
            this.labelSoundFile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnListen.Location = new System.Drawing.Point(234, 17);
            this.btnListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(70, 29);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFwd.Location = new System.Drawing.Point(234, 50);
            this.btnFwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(70, 30);
            this.btnFwd.TabIndex = 1;
            this.btnFwd.Text = "Forward";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port listen to";
            // 
            // textBoxListenPort
            // 
            this.textBoxListenPort.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxListenPort.Location = new System.Drawing.Point(125, 21);
            this.textBoxListenPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxListenPort.Name = "textBoxListenPort";
            this.textBoxListenPort.Size = new System.Drawing.Size(96, 23);
            this.textBoxListenPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port forward to";
            // 
            // textBoxPortForwardTo
            // 
            this.textBoxPortForwardTo.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPortForwardTo.Location = new System.Drawing.Point(125, 52);
            this.textBoxPortForwardTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPortForwardTo.Name = "textBoxPortForwardTo";
            this.textBoxPortForwardTo.Size = new System.Drawing.Size(96, 23);
            this.textBoxPortForwardTo.TabIndex = 5;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLog.Location = new System.Drawing.Point(14, 90);
            this.labelLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(41, 15);
            this.labelLog.TabIndex = 6;
            this.labelLog.Text = "label3";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 283);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(964, 209);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // labelRotChest
            // 
            this.labelRotChest.AutoSize = true;
            this.labelRotChest.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRotChest.Location = new System.Drawing.Point(435, 23);
            this.labelRotChest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotChest.Name = "labelRotChest";
            this.labelRotChest.Size = new System.Drawing.Size(40, 15);
            this.labelRotChest.TabIndex = 8;
            this.labelRotChest.Text = "Chest";
            // 
            // labelRotWaist
            // 
            this.labelRotWaist.AutoSize = true;
            this.labelRotWaist.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRotWaist.Location = new System.Drawing.Point(435, 57);
            this.labelRotWaist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotWaist.Name = "labelRotWaist";
            this.labelRotWaist.Size = new System.Drawing.Size(39, 15);
            this.labelRotWaist.TabIndex = 9;
            this.labelRotWaist.Text = "Waist";
            // 
            // labelDiff
            // 
            this.labelDiff.AutoSize = true;
            this.labelDiff.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDiff.Location = new System.Drawing.Point(435, 90);
            this.labelDiff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiff.Name = "labelDiff";
            this.labelDiff.Size = new System.Drawing.Size(27, 15);
            this.labelDiff.TabIndex = 10;
            this.labelDiff.Text = "Diff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Threshold (何度以上の差で通知するか)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(23, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(122, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Z";
            // 
            // textBoxThresY
            // 
            this.textBoxThresY.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxThresY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxThresY.Location = new System.Drawing.Point(42, 168);
            this.textBoxThresY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxThresY.Name = "textBoxThresY";
            this.textBoxThresY.Size = new System.Drawing.Size(50, 23);
            this.textBoxThresY.TabIndex = 14;
            // 
            // textBoxThresZ
            // 
            this.textBoxThresZ.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxThresZ.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxThresZ.Location = new System.Drawing.Point(141, 168);
            this.textBoxThresZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxThresZ.Name = "textBoxThresZ";
            this.textBoxThresZ.Size = new System.Drawing.Size(50, 23);
            this.textBoxThresZ.TabIndex = 15;
            // 
            // labelThres
            // 
            this.labelThres.AutoSize = true;
            this.labelThres.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelThres.Location = new System.Drawing.Point(435, 122);
            this.labelThres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThres.Name = "labelThres";
            this.labelThres.Size = new System.Drawing.Size(40, 15);
            this.labelThres.TabIndex = 16;
            this.labelThres.Text = "Thres";
            // 
            // buttonSound
            // 
            this.buttonSound.Location = new System.Drawing.Point(438, 154);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(120, 23);
            this.buttonSound.TabIndex = 17;
            this.buttonSound.Text = "Select Sound";
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // labelSoundFile
            // 
            this.labelSoundFile.AutoSize = true;
            this.labelSoundFile.Location = new System.Drawing.Point(564, 159);
            this.labelSoundFile.Name = "labelSoundFile";
            this.labelSoundFile.Size = new System.Drawing.Size(35, 12);
            this.labelSoundFile.TabIndex = 18;
            this.labelSoundFile.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(23, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "10以上180以下、デフォルト30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelSoundFile);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.labelThres);
            this.Controls.Add(this.textBoxThresZ);
            this.Controls.Add(this.textBoxThresY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDiff);
            this.Controls.Add(this.labelRotWaist);
            this.Controls.Add(this.labelRotChest);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.textBoxPortForwardTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxListenPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnListen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Unnatural Pose Detector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxListenPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPortForwardTo;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelRotChest;
        private System.Windows.Forms.Label labelRotWaist;
        private System.Windows.Forms.Label labelDiff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxThresY;
        private System.Windows.Forms.TextBox textBoxThresZ;
        private System.Windows.Forms.Label labelThres;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Label labelSoundFile;
        private System.Windows.Forms.Label label6;
    }
}

