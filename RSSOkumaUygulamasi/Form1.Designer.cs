namespace RSSOkumaUygulamasi
{
    partial class Form1
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
            this.BtnGetir = new System.Windows.Forms.Button();
            this.txtRSSUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBaslik = new System.Windows.Forms.ListBox();
            this.web_Browser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGetir
            // 
            this.BtnGetir.Location = new System.Drawing.Point(1055, 21);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(75, 23);
            this.BtnGetir.TabIndex = 0;
            this.BtnGetir.Text = "Getir";
            this.BtnGetir.UseVisualStyleBackColor = true;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // txtRSSUrl
            // 
            this.txtRSSUrl.Location = new System.Drawing.Point(15, 21);
            this.txtRSSUrl.Name = "txtRSSUrl";
            this.txtRSSUrl.Size = new System.Drawing.Size(1017, 22);
            this.txtRSSUrl.TabIndex = 1;
            this.txtRSSUrl.Text = "https://www.sabah.com.tr/rss/spor.xml";
            this.txtRSSUrl.TextChanged += new System.EventHandler(this.txtRSSUrl_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRSSUrl);
            this.groupBox1.Controls.Add(this.BtnGetir);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // lstBaslik
            // 
            this.lstBaslik.FormattingEnabled = true;
            this.lstBaslik.ItemHeight = 16;
            this.lstBaslik.Location = new System.Drawing.Point(15, 34);
            this.lstBaslik.Name = "lstBaslik";
            this.lstBaslik.Size = new System.Drawing.Size(386, 548);
            this.lstBaslik.TabIndex = 3;
            this.lstBaslik.SelectedIndexChanged += new System.EventHandler(this.lstBaslik_SelectedIndexChanged);
            // 
            // web_Browser1
            // 
            this.web_Browser1.Location = new System.Drawing.Point(15, 21);
            this.web_Browser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Browser1.Name = "web_Browser1";
            this.web_Browser1.Size = new System.Drawing.Size(983, 565);
            this.web_Browser1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstBaslik);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 586);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_Browser1);
            this.groupBox3.Location = new System.Drawing.Point(440, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1004, 592);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 706);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RSS OKUMA UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.TextBox txtRSSUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBaslik;
        private System.Windows.Forms.WebBrowser web_Browser1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

