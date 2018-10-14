namespace fileChecker
{
    partial class frmDosyaTakip
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDosyaTakip));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnGozat = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.lblProgramStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.listPath = new System.Windows.Forms.ListView();
            this.Boyut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DosyaYolu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPListView = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SonDeneme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sayi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya Yolu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Boyutu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kbdan büyükse uyar";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(9, 86);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(428, 46);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(392, 24);
            this.btnGozat.Margin = new System.Windows.Forms.Padding(2);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(45, 19);
            this.btnGozat.TabIndex = 4;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(84, 24);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(304, 20);
            this.txtPath.TabIndex = 5;
            this.txtPath.Text = "C:\\";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(84, 63);
            this.txtMaxSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(30, 20);
            this.txtMaxSize.TabIndex = 6;
            this.txtMaxSize.Text = "100";
            // 
            // lblProgramStatus
            // 
            this.lblProgramStatus.AutoSize = true;
            this.lblProgramStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramStatus.ForeColor = System.Drawing.Color.Red;
            this.lblProgramStatus.Location = new System.Drawing.Point(145, 98);
            this.lblProgramStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgramStatus.Name = "lblProgramStatus";
            this.lblProgramStatus.Size = new System.Drawing.Size(0, 18);
            this.lblProgramStatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Oluşan Dosyalar:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "File Checker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // listPath
            // 
            this.listPath.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Boyut,
            this.date,
            this.DosyaYolu});
            this.listPath.GridLines = true;
            this.listPath.Location = new System.Drawing.Point(9, 152);
            this.listPath.Name = "listPath";
            this.listPath.Size = new System.Drawing.Size(428, 170);
            this.listPath.TabIndex = 10;
            this.listPath.UseCompatibleStateImageBehavior = false;
            this.listPath.View = System.Windows.Forms.View.Details;
            this.listPath.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPath_ColumnClick);
            // 
            // Boyut
            // 
            this.Boyut.Text = "Boyut";
            this.Boyut.Width = 41;
            // 
            // date
            // 
            this.date.Text = "Tarih";
            this.date.Width = 115;
            // 
            // DosyaYolu
            // 
            this.DosyaYolu.Text = "Dosya Yolu";
            this.DosyaYolu.Width = 290;
            // 
            // IPListView
            // 
            this.IPListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.SonDeneme,
            this.Sayi});
            this.IPListView.GridLines = true;
            this.IPListView.Location = new System.Drawing.Point(9, 363);
            this.IPListView.Name = "IPListView";
            this.IPListView.Size = new System.Drawing.Size(428, 170);
            this.IPListView.TabIndex = 11;
            this.IPListView.UseCompatibleStateImageBehavior = false;
            this.IPListView.View = System.Windows.Forms.View.Details;
            this.IPListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.IPListView_ColumnClick);
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 171;
            // 
            // SonDeneme
            // 
            this.SonDeneme.Text = "Son Deneme";
            this.SonDeneme.Width = 175;
            // 
            // Sayi
            // 
            this.Sayi.Text = "Toplam Sayı";
            this.Sayi.Width = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Engellenen IPler:";
            // 
            // frmDosyaTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(446, 556);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IPListView);
            this.Controls.Add(this.listPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblProgramStatus);
            this.Controls.Add(this.txtMaxSize);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDosyaTakip";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dosya Takip";
            this.Resize += new System.EventHandler(this.frmDosyaTakip_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.Label lblProgramStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ListView listPath;
        private System.Windows.Forms.ColumnHeader Boyut;
        private System.Windows.Forms.ColumnHeader DosyaYolu;
        private System.Windows.Forms.ColumnHeader date;
        private ListViewColumnSorter lvwColumnSorter;
        private System.Windows.Forms.ListView IPListView;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader SonDeneme;
        private System.Windows.Forms.ColumnHeader Sayi;
        private System.Windows.Forms.Label label5;
    }
}

