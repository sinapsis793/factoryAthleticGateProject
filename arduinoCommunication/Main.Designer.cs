namespace factoryAthletic
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.optionsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.doorOpen = new System.Windows.Forms.Button();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsButton
            // 
            this.optionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsButton.Location = new System.Drawing.Point(1163, 15);
            this.optionsButton.Margin = new System.Windows.Forms.Padding(6);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(206, 44);
            this.optionsButton.TabIndex = 6;
            this.optionsButton.Text = "Ayarlar";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(945, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Durdur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(727, 15);
            this.startButton.Margin = new System.Windows.Forms.Padding(6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(206, 44);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Baþlat";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // doorOpen
            // 
            this.doorOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doorOpen.Enabled = false;
            this.doorOpen.Location = new System.Drawing.Point(432, 15);
            this.doorOpen.Margin = new System.Windows.Forms.Padding(6);
            this.doorOpen.Name = "doorOpen";
            this.doorOpen.Size = new System.Drawing.Size(206, 44);
            this.doorOpen.TabIndex = 10;
            this.doorOpen.Text = "Turnikeyi Aç";
            this.doorOpen.UseVisualStyleBackColor = true;
            this.doorOpen.Click += new System.EventHandler(this.doorOpen_Click);
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.Location = new System.Drawing.Point(12, 25);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(171, 25);
            this.connectionStatus.TabIndex = 11;
            this.connectionStatus.Text = "Baðlantý Durumu";
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNo,
            this.nameSurname,
            this.enterDate,
            this.enterTime,
            this.remainDays});
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridView.Location = new System.Drawing.Point(0, 3);
            this.usersGridView.Margin = new System.Windows.Forms.Padding(0, 3, 3, 91);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidth = 82;
            this.usersGridView.RowTemplate.Height = 33;
            this.usersGridView.Size = new System.Drawing.Size(971, 967);
            this.usersGridView.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 1061);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.21136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.78864F));
            this.tableLayoutPanel1.Controls.Add(this.usersGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userImage, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1388, 1061);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // userImage
            // 
            this.userImage.Image = ((System.Drawing.Image)(resources.GetObject("userImage.Image")));
            this.userImage.Location = new System.Drawing.Point(977, 3);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(400, 400);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userImage.TabIndex = 12;
            this.userImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.connectionStatus);
            this.panel2.Controls.Add(this.doorOpen);
            this.panel2.Controls.Add(this.optionsButton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 970);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 91);
            this.panel2.TabIndex = 14;
            // 
            // userNo
            // 
            this.userNo.HeaderText = "Kullanýcý No";
            this.userNo.MinimumWidth = 10;
            this.userNo.Name = "userNo";
            this.userNo.ReadOnly = true;
            // 
            // nameSurname
            // 
            this.nameSurname.HeaderText = "Ad Soyad";
            this.nameSurname.MinimumWidth = 10;
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.ReadOnly = true;
            // 
            // enterDate
            // 
            this.enterDate.HeaderText = "Giriþ Tarihi";
            this.enterDate.MinimumWidth = 10;
            this.enterDate.Name = "enterDate";
            this.enterDate.ReadOnly = true;
            // 
            // enterTime
            // 
            this.enterTime.HeaderText = "Giriþ Saati";
            this.enterTime.MinimumWidth = 10;
            this.enterTime.Name = "enterTime";
            this.enterTime.ReadOnly = true;
            // 
            // remainDays
            // 
            this.remainDays.HeaderText = "Kalan Gün";
            this.remainDays.MinimumWidth = 10;
            this.remainDays.Name = "remainDays";
            this.remainDays.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 1061);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factory+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button doorOpen;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainDays;
    }
}

