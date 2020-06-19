namespace AirportISSProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.slideImg = new System.Windows.Forms.PictureBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.profileButton = new Guna.UI2.WinForms.Guna2Button();
            this.infoButton = new Guna.UI2.WinForms.Guna2Button();
            this.ticketButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainArea = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideImg)).BeginInit();
            this.panel3.SuspendLayout();
            this.mainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Founder";
            this.label2.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets";
            this.label1.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(8, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.slideImg);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.profileButton);
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.ticketButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 608);
            this.panel1.TabIndex = 3;
            // 
            // slideImg
            // 
            this.slideImg.BackColor = System.Drawing.Color.Transparent;
            this.slideImg.Image = ((System.Drawing.Image)(resources.GetObject("slideImg.Image")));
            this.slideImg.Location = new System.Drawing.Point(165, 97);
            this.slideImg.Name = "slideImg";
            this.slideImg.Size = new System.Drawing.Size(42, 107);
            this.slideImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slideImg.TabIndex = 8;
            this.slideImg.TabStop = false;
            this.slideImg.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderRadius = 8;
            this.exitButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.exitButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.exitButton.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exitButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.CheckedState.Image")));
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.exitButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitButton.ImageOffset = new System.Drawing.Point(5, -1);
            this.exitButton.Location = new System.Drawing.Point(17, 524);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedColor = System.Drawing.Color.White;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(170, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выход";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitButton.TextOffset = new System.Drawing.Point(7, 0);
            this.exitButton.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Transparent;
            this.settingsButton.BorderRadius = 8;
            this.settingsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.settingsButton.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.settingsButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.CheckedState.Image")));
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.settingsButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.HoverState.Parent = this.settingsButton;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.ImageOffset = new System.Drawing.Point(5, -1);
            this.settingsButton.Location = new System.Drawing.Point(17, 439);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.PressedColor = System.Drawing.Color.White;
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(170, 45);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsButton.TextOffset = new System.Drawing.Point(7, 0);
            this.settingsButton.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Transparent;
            this.profileButton.BorderRadius = 8;
            this.profileButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.profileButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.profileButton.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.profileButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.CheckedState.Image")));
            this.profileButton.CheckedState.Parent = this.profileButton;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.CustomImages.Parent = this.profileButton;
            this.profileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.profileButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.HoverState.Parent = this.profileButton;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.profileButton.ImageOffset = new System.Drawing.Point(5, -1);
            this.profileButton.Location = new System.Drawing.Point(17, 357);
            this.profileButton.Name = "profileButton";
            this.profileButton.PressedColor = System.Drawing.Color.White;
            this.profileButton.ShadowDecoration.Parent = this.profileButton;
            this.profileButton.Size = new System.Drawing.Size(170, 45);
            this.profileButton.TabIndex = 7;
            this.profileButton.Text = "Профиль";
            this.profileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.profileButton.TextOffset = new System.Drawing.Point(7, 0);
            this.profileButton.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.BorderRadius = 8;
            this.infoButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.infoButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.infoButton.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.infoButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.CheckedState.Image")));
            this.infoButton.CheckedState.Parent = this.infoButton;
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoButton.CustomImages.Parent = this.infoButton;
            this.infoButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.infoButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.HoverState.Parent = this.infoButton;
            this.infoButton.Image = ((System.Drawing.Image)(resources.GetObject("infoButton.Image")));
            this.infoButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.infoButton.ImageOffset = new System.Drawing.Point(5, -1);
            this.infoButton.Location = new System.Drawing.Point(17, 280);
            this.infoButton.Name = "infoButton";
            this.infoButton.PressedColor = System.Drawing.Color.White;
            this.infoButton.ShadowDecoration.Parent = this.infoButton;
            this.infoButton.Size = new System.Drawing.Size(170, 45);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Информация";
            this.infoButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.infoButton.TextOffset = new System.Drawing.Point(7, 0);
            this.infoButton.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // ticketButton
            // 
            this.ticketButton.BackColor = System.Drawing.Color.Transparent;
            this.ticketButton.BorderRadius = 8;
            this.ticketButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ticketButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.ticketButton.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ticketButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("ticketButton.CheckedState.Image")));
            this.ticketButton.CheckedState.Parent = this.ticketButton;
            this.ticketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketButton.CustomImages.Parent = this.ticketButton;
            this.ticketButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ticketButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketButton.ForeColor = System.Drawing.Color.White;
            this.ticketButton.HoverState.Parent = this.ticketButton;
            this.ticketButton.Image = ((System.Drawing.Image)(resources.GetObject("ticketButton.Image")));
            this.ticketButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ticketButton.ImageOffset = new System.Drawing.Point(5, -1);
            this.ticketButton.Location = new System.Drawing.Point(17, 205);
            this.ticketButton.Name = "ticketButton";
            this.ticketButton.PressedColor = System.Drawing.Color.White;
            this.ticketButton.ShadowDecoration.Parent = this.ticketButton;
            this.ticketButton.Size = new System.Drawing.Size(170, 45);
            this.ticketButton.TabIndex = 7;
            this.ticketButton.Text = "Билеты";
            this.ticketButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ticketButton.TextOffset = new System.Drawing.Point(7, 0);
            this.ticketButton.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.ticketButton.Click += new System.EventHandler(this.ticketButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderColor = System.Drawing.Color.Transparent;
            this.searchButton.BorderRadius = 8;
            this.searchButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.searchButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.searchButton.CheckedState.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.CheckedState.Image")));
            this.searchButton.CheckedState.Parent = this.searchButton;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.CustomImages.Parent = this.searchButton;
            this.searchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.searchButton.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.HoverState.Parent = this.searchButton;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchButton.ImageOffset = new System.Drawing.Point(5, -1);
            this.searchButton.Location = new System.Drawing.Point(17, 129);
            this.searchButton.Name = "searchButton";
            this.searchButton.PressedColor = System.Drawing.Color.White;
            this.searchButton.ShadowDecoration.Parent = this.searchButton;
            this.searchButton.Size = new System.Drawing.Size(170, 45);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchButton.TextOffset = new System.Drawing.Point(7, 0);
            this.searchButton.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 97);
            this.panel3.TabIndex = 6;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // mainArea
            // 
            this.mainArea.Controls.Add(this.pictureBox1);
            this.mainArea.Controls.Add(this.label3);
            this.mainArea.Controls.Add(this.label4);
            this.mainArea.Controls.Add(this.label5);
            this.mainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainArea.Location = new System.Drawing.Point(205, 0);
            this.mainArea.Name = "mainArea";
            this.mainArea.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.mainArea.Size = new System.Drawing.Size(882, 608);
            this.mainArea.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Montserrat", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 99);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tickets";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Montserrat", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(498, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 99);
            this.label4.TabIndex = 8;
            this.label4.Text = "Founder";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Montserrat Thin", 45.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(576, 84);
            this.label5.TabIndex = 10;
            this.label5.Text = "03.06.2020 14:14:35";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 608);
            this.Controls.Add(this.mainArea);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets Founder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slideImg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.mainArea.ResumeLayout(false);
            this.mainArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel mainArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2Button searchButton;
        public System.Windows.Forms.PictureBox slideImg;
        public Guna.UI2.WinForms.Guna2Button profileButton;
        public Guna.UI2.WinForms.Guna2Button infoButton;
        public Guna.UI2.WinForms.Guna2Button ticketButton;
        public Guna.UI2.WinForms.Guna2Button exitButton;
        public Guna.UI2.WinForms.Guna2Button settingsButton;
        private System.Windows.Forms.Timer timer2;
    }
}

