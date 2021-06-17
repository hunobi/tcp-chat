namespace HubChat
{
    partial class Opcje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AdressIP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AcceptData = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserNick = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userNazwa = new System.Windows.Forms.TextBox();
            this.UserPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres IP:";
            // 
            // AdressIP
            // 
            this.AdressIP.Location = new System.Drawing.Point(62, 28);
            this.AdressIP.Name = "AdressIP";
            this.AdressIP.Size = new System.Drawing.Size(100, 20);
            this.AdressIP.TabIndex = 1;
            this.AdressIP.Text = "127.0.0.1";
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(62, 54);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 2;
            this.Port.Text = "1024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AdressIP);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Serwera";
            // 
            // AcceptData
            // 
            this.AcceptData.Location = new System.Drawing.Point(12, 226);
            this.AcceptData.Name = "AcceptData";
            this.AcceptData.Size = new System.Drawing.Size(75, 23);
            this.AcceptData.TabIndex = 5;
            this.AcceptData.Text = "Zapisz!";
            this.AcceptData.UseVisualStyleBackColor = true;
            this.AcceptData.Click += new System.EventHandler(this.AcceptData_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(142, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Wyjdź";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UserNick);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.userNazwa);
            this.groupBox2.Controls.Add(this.UserPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Twoje Dane";
            // 
            // UserNick
            // 
            this.UserNick.AutoSize = true;
            this.UserNick.Location = new System.Drawing.Point(6, 31);
            this.UserNick.Name = "UserNick";
            this.UserNick.Size = new System.Drawing.Size(29, 13);
            this.UserNick.TabIndex = 0;
            this.UserNick.Text = "Nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port:";
            // 
            // userNazwa
            // 
            this.userNazwa.Location = new System.Drawing.Point(62, 28);
            this.userNazwa.Name = "userNazwa";
            this.userNazwa.Size = new System.Drawing.Size(100, 20);
            this.userNazwa.TabIndex = 1;
            this.userNazwa.Text = "Gość";
            // 
            // UserPort
            // 
            this.UserPort.Location = new System.Drawing.Point(62, 54);
            this.UserPort.Name = "UserPort";
            this.UserPort.Size = new System.Drawing.Size(100, 20);
            this.UserPort.TabIndex = 2;
            this.UserPort.Text = "1024";
            // 
            // Opcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(229, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AcceptData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Opcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdressIP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AcceptData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label UserNick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNazwa;
        private System.Windows.Forms.TextBox UserPort;
    }
}