namespace HubChat
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Connect = new System.Windows.Forms.Button();
            this.TwojNick = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PortSerwera = new System.Windows.Forms.Label();
            this.IPSerwera = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TwojPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TwojeIP = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Send = new System.Windows.Forms.Button();
            this.ChatText = new System.Windows.Forms.TextBox();
            this.MainChatWindow = new System.Windows.Forms.FlowLayoutPanel();
            this.ChatClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(15, 558);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 32);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Wyjście";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 87);
            this.panel1.TabIndex = 1;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Magneto", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.OrangeRed;
            this.Header.Location = new System.Drawing.Point(392, 11);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(266, 60);
            this.Header.TabIndex = 0;
            this.Header.Text = "HubChat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.ChatClear);
            this.panel2.Controls.Add(this.Connect);
            this.panel2.Controls.Add(this.TwojNick);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.PortSerwera);
            this.panel2.Controls.Add(this.IPSerwera);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TwojPort);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TwojeIP);
            this.panel2.Controls.Add(this.Option);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 603);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(15, 487);
            this.Connect.Margin = new System.Windows.Forms.Padding(4);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 28);
            this.Connect.TabIndex = 13;
            this.Connect.Text = "Połącz";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TwojNick
            // 
            this.TwojNick.AutoSize = true;
            this.TwojNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwojNick.Location = new System.Drawing.Point(15, 239);
            this.TwojNick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TwojNick.Name = "TwojNick";
            this.TwojNick.Size = new System.Drawing.Size(39, 17);
            this.TwojNick.TabIndex = 12;
            this.TwojNick.Text = "Nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Twój Nick:";
            // 
            // PortSerwera
            // 
            this.PortSerwera.AutoSize = true;
            this.PortSerwera.Location = new System.Drawing.Point(15, 180);
            this.PortSerwera.Name = "PortSerwera";
            this.PortSerwera.Size = new System.Drawing.Size(40, 17);
            this.PortSerwera.TabIndex = 10;
            this.PortSerwera.Text = "1024";
            // 
            // IPSerwera
            // 
            this.IPSerwera.AutoSize = true;
            this.IPSerwera.Location = new System.Drawing.Point(3, 147);
            this.IPSerwera.Name = "IPSerwera";
            this.IPSerwera.Size = new System.Drawing.Size(68, 17);
            this.IPSerwera.TabIndex = 9;
            this.IPSerwera.Text = "192.0.0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Serwer Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Serwer IP:";
            // 
            // TwojPort
            // 
            this.TwojPort.AutoSize = true;
            this.TwojPort.Location = new System.Drawing.Point(13, 90);
            this.TwojPort.Name = "TwojPort";
            this.TwojPort.Size = new System.Drawing.Size(40, 17);
            this.TwojPort.TabIndex = 6;
            this.TwojPort.Text = "1024";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Twój Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Twoje IP:";
            // 
            // TwojeIP
            // 
            this.TwojeIP.AutoSize = true;
            this.TwojeIP.Location = new System.Drawing.Point(0, 56);
            this.TwojeIP.Name = "TwojeIP";
            this.TwojeIP.Size = new System.Drawing.Size(68, 17);
            this.TwojeIP.TabIndex = 3;
            this.TwojeIP.Text = "192.0.0.1";
            // 
            // Option
            // 
            this.Option.Location = new System.Drawing.Point(16, 523);
            this.Option.Margin = new System.Windows.Forms.Padding(4);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(75, 28);
            this.Option.TabIndex = 2;
            this.Option.Text = "Opcje";
            this.Option.UseVisualStyleBackColor = true;
            this.Option.Click += new System.EventHandler(this.Option_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.Menu);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 34);
            this.panel3.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Crimson;
            this.Menu.Location = new System.Drawing.Point(21, 2);
            this.Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(63, 26);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.Send);
            this.panel4.Controls.Add(this.ChatText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(108, 644);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(957, 46);
            this.panel4.TabIndex = 3;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(839, 9);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(83, 28);
            this.Send.TabIndex = 1;
            this.Send.Text = "Wyślij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // ChatText
            // 
            this.ChatText.Location = new System.Drawing.Point(0, 9);
            this.ChatText.Margin = new System.Windows.Forms.Padding(4);
            this.ChatText.Name = "ChatText";
            this.ChatText.Size = new System.Drawing.Size(829, 22);
            this.ChatText.TabIndex = 0;
            // 
            // MainChatWindow
            // 
            this.MainChatWindow.AutoScroll = true;
            this.MainChatWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.MainChatWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainChatWindow.Location = new System.Drawing.Point(108, 87);
            this.MainChatWindow.Margin = new System.Windows.Forms.Padding(4);
            this.MainChatWindow.Name = "MainChatWindow";
            this.MainChatWindow.Size = new System.Drawing.Size(957, 557);
            this.MainChatWindow.TabIndex = 4;
            // 
            // ChatClear
            // 
            this.ChatClear.Location = new System.Drawing.Point(15, 451);
            this.ChatClear.Margin = new System.Windows.Forms.Padding(4);
            this.ChatClear.Name = "ChatClear";
            this.ChatClear.Size = new System.Drawing.Size(75, 28);
            this.ChatClear.TabIndex = 14;
            this.ChatClear.Text = "Czyść";
            this.ChatClear.UseVisualStyleBackColor = true;
            this.ChatClear.Click += new System.EventHandler(this.ChatClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1065, 690);
            this.Controls.Add(this.MainChatWindow);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HubChat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox ChatText;
        private System.Windows.Forms.FlowLayoutPanel MainChatWindow;
        private System.Windows.Forms.Button Option;
        private System.Windows.Forms.Label TwojPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TwojeIP;
        private System.Windows.Forms.Label TwojNick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PortSerwera;
        private System.Windows.Forms.Label IPSerwera;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button ChatClear;
    }
}

