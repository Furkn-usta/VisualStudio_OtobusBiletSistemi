namespace otobus_otomasyon
{
    partial class admin_panel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.oturumKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(841, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletPaneliToolStripMenuItem,
            this.kullanıcıPaneliToolStripMenuItem,
            this.biletİptalToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // biletPaneliToolStripMenuItem
            // 
            this.biletPaneliToolStripMenuItem.AutoSize = false;
            this.biletPaneliToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.biletPaneliToolStripMenuItem.Image = global::otobus_otomasyon.Properties.Resources.bus_ticket_icon;
            this.biletPaneliToolStripMenuItem.Name = "biletPaneliToolStripMenuItem";
            this.biletPaneliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.biletPaneliToolStripMenuItem.Text = "Bilet Paneli";
            this.biletPaneliToolStripMenuItem.Click += new System.EventHandler(this.biletPaneliToolStripMenuItem_Click);
            // 
            // kullanıcıPaneliToolStripMenuItem
            // 
            this.kullanıcıPaneliToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.kullanıcıPaneliToolStripMenuItem.Image = global::otobus_otomasyon.Properties.Resources.myspace_icon;
            this.kullanıcıPaneliToolStripMenuItem.Name = "kullanıcıPaneliToolStripMenuItem";
            this.kullanıcıPaneliToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.kullanıcıPaneliToolStripMenuItem.Text = "Kullanıcı Paneli";
            this.kullanıcıPaneliToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıPaneliToolStripMenuItem_Click);
            // 
            // biletİptalToolStripMenuItem
            // 
            this.biletİptalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.biletİptalToolStripMenuItem.Image = global::otobus_otomasyon.Properties.Resources.Ticket_remove_icon;
            this.biletİptalToolStripMenuItem.Name = "biletİptalToolStripMenuItem";
            this.biletİptalToolStripMenuItem.Size = new System.Drawing.Size(215, 30);
            this.biletİptalToolStripMenuItem.Text = "Bilet İptal";
            this.biletİptalToolStripMenuItem.Click += new System.EventHandler(this.biletİptalToolStripMenuItem_Click);
            // 
            // oturumKapatToolStripMenuItem
            // 
            this.oturumKapatToolStripMenuItem.Name = "oturumKapatToolStripMenuItem";
            this.oturumKapatToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.oturumKapatToolStripMenuItem.Text = "Oturum Kapat";
            this.oturumKapatToolStripMenuItem.Click += new System.EventHandler(this.oturumKapatToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::otobus_otomasyon.Properties.Resources.bus_4_icon;
            this.pictureBox1.Location = new System.Drawing.Point(255, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 324);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.admin_panel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oturumKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletİptalToolStripMenuItem;
    }
}