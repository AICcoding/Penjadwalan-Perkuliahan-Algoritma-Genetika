namespace Penjadwalan_Perkuliahan_Algoritma_Genetika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mataKuliahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waktuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waktuLaranganDosenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesAlgoritmaGenetikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cekUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.bantuanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.prosesAlgoritmaGenetikaToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mataKuliahToolStripMenuItem,
            this.dosenToolStripMenuItem,
            this.ruangToolStripMenuItem,
            this.waktuToolStripMenuItem,
            this.waktuLaranganDosenToolStripMenuItem,
            this.mataToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // mataKuliahToolStripMenuItem
            // 
            this.mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            this.mataKuliahToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.mataKuliahToolStripMenuItem.Text = "Mata kuliah";
            this.mataKuliahToolStripMenuItem.Click += new System.EventHandler(this.mataKuliahToolStripMenuItem_Click);
            // 
            // dosenToolStripMenuItem
            // 
            this.dosenToolStripMenuItem.Name = "dosenToolStripMenuItem";
            this.dosenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dosenToolStripMenuItem.Text = "Dosen";
            this.dosenToolStripMenuItem.Click += new System.EventHandler(this.dosenToolStripMenuItem_Click);
            // 
            // ruangToolStripMenuItem
            // 
            this.ruangToolStripMenuItem.Name = "ruangToolStripMenuItem";
            this.ruangToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ruangToolStripMenuItem.Text = "Ruang";
            this.ruangToolStripMenuItem.Click += new System.EventHandler(this.ruangToolStripMenuItem_Click);
            // 
            // waktuToolStripMenuItem
            // 
            this.waktuToolStripMenuItem.Name = "waktuToolStripMenuItem";
            this.waktuToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.waktuToolStripMenuItem.Text = "Waktu";
            this.waktuToolStripMenuItem.Click += new System.EventHandler(this.waktuToolStripMenuItem_Click);
            // 
            // mataToolStripMenuItem
            // 
            this.mataToolStripMenuItem.Name = "mataToolStripMenuItem";
            this.mataToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.mataToolStripMenuItem.Text = "Relasi Mata kuliah dan dosen";
            this.mataToolStripMenuItem.Click += new System.EventHandler(this.mataToolStripMenuItem_Click);
            // 
            // waktuLaranganDosenToolStripMenuItem
            // 
            this.waktuLaranganDosenToolStripMenuItem.Name = "waktuLaranganDosenToolStripMenuItem";
            this.waktuLaranganDosenToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.waktuLaranganDosenToolStripMenuItem.Text = "Waktu larangan dosen";
            this.waktuLaranganDosenToolStripMenuItem.Click += new System.EventHandler(this.waktuLaranganDosenToolStripMenuItem_Click);
            // 
            // prosesAlgoritmaGenetikaToolStripMenuItem
            // 
            this.prosesAlgoritmaGenetikaToolStripMenuItem.Name = "prosesAlgoritmaGenetikaToolStripMenuItem";
            this.prosesAlgoritmaGenetikaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.prosesAlgoritmaGenetikaToolStripMenuItem.Text = "Proses algoritma genetika";
            this.prosesAlgoritmaGenetikaToolStripMenuItem.Click += new System.EventHandler(this.prosesAlgoritmaGenetikaToolStripMenuItem_Click);
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cekUpdateToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.tentangAplikasiToolStripMenuItem});
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.bantuanToolStripMenuItem.Text = "Tentang";
            // 
            // cekUpdateToolStripMenuItem
            // 
            this.cekUpdateToolStripMenuItem.Name = "cekUpdateToolStripMenuItem";
            this.cekUpdateToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cekUpdateToolStripMenuItem.Text = "Cek update";
            this.cekUpdateToolStripMenuItem.Click += new System.EventHandler(this.cekUpdateToolStripMenuItem_Click);
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.creditToolStripMenuItem.Text = "Tentang developer";
            this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tentangAplikasiToolStripMenuItem.Text = "Tentang aplikasi";
            this.tentangAplikasiToolStripMenuItem.Click += new System.EventHandler(this.tentangAplikasiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proses";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(57, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(658, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 408);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(743, 447);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penjadwalan Perkuliahan Algoritma Genetika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mataKuliahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waktuLaranganDosenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesAlgoritmaGenetikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cekUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangAplikasiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem waktuToolStripMenuItem;
    }
}

