namespace KUTUPHANE
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVerilenKitapDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alınanÖdünçKitapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlarToolStripMenuItem,
            this.kitapToolStripMenuItem,
            this.üyeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListesiRaporuToolStripMenuItem,
            this.üyeListesiRaporuToolStripMenuItem,
            this.ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem,
            this.ödünçVerilenKitapDurumuToolStripMenuItem,
            this.alınanÖdünçKitapListesiToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // kitapListesiRaporuToolStripMenuItem
            // 
            this.kitapListesiRaporuToolStripMenuItem.Name = "kitapListesiRaporuToolStripMenuItem";
            this.kitapListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.kitapListesiRaporuToolStripMenuItem.Text = "Kitap Listesi Raporu";
            this.kitapListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.KitapListesiRaporuToolStripMenuItem_Click);
            // 
            // üyeListesiRaporuToolStripMenuItem
            // 
            this.üyeListesiRaporuToolStripMenuItem.Name = "üyeListesiRaporuToolStripMenuItem";
            this.üyeListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.üyeListesiRaporuToolStripMenuItem.Text = "Üye Listesi Raporu";
            this.üyeListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.ÜyeListesiRaporuToolStripMenuItem_Click);
            // 
            // ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem
            // 
            this.ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Name = "ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem";
            this.ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Text = "Ödünç Verilen Kitapların Listesi Raporu";
            this.ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem.Click += new System.EventHandler(this.ÖdünçVerilenKitaplarınListesiRaporuToolStripMenuItem_Click);
            // 
            // ödünçVerilenKitapDurumuToolStripMenuItem
            // 
            this.ödünçVerilenKitapDurumuToolStripMenuItem.Name = "ödünçVerilenKitapDurumuToolStripMenuItem";
            this.ödünçVerilenKitapDurumuToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.ödünçVerilenKitapDurumuToolStripMenuItem.Text = "Ödünç Verilen Kitap Durumu";
            this.ödünçVerilenKitapDurumuToolStripMenuItem.Click += new System.EventHandler(this.ÖdünçVerilenKitapDurumuToolStripMenuItem_Click);
            // 
            // alınanÖdünçKitapListesiToolStripMenuItem
            // 
            this.alınanÖdünçKitapListesiToolStripMenuItem.Name = "alınanÖdünçKitapListesiToolStripMenuItem";
            this.alınanÖdünçKitapListesiToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.alınanÖdünçKitapListesiToolStripMenuItem.Text = "Alınan Ödünç Kitap Sıralama Liste";
            this.alınanÖdünçKitapListesiToolStripMenuItem.Click += new System.EventHandler(this.AlınanÖdünçKitapListesiToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKitapToolStripMenuItem,
            this.toolStripMenuItem1});
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.kitapToolStripMenuItem.Text = "Kitap";
            // 
            // yeniKitapToolStripMenuItem
            // 
            this.yeniKitapToolStripMenuItem.Name = "yeniKitapToolStripMenuItem";
            this.yeniKitapToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.yeniKitapToolStripMenuItem.Text = "Yeni Kitap";
            this.yeniKitapToolStripMenuItem.Click += new System.EventHandler(this.YeniKitapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem1.Text = "Ödünç Kitap";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // üyeToolStripMenuItem
            // 
            this.üyeToolStripMenuItem.Name = "üyeToolStripMenuItem";
            this.üyeToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.üyeToolStripMenuItem.Text = "Üye";
            this.üyeToolStripMenuItem.Click += new System.EventHandler(this.ÜyeToolStripMenuItem_Click);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KUTUPHANE UYGULAMASI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçVerilenKitaplarınListesiRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ödünçVerilenKitapDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alınanÖdünçKitapListesiToolStripMenuItem;
    }
}