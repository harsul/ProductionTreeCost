namespace KromelProgram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.malzemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.malzemeKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mamulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mamulKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maliyetHesabiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardMaliyetHesabıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maliyetHesabiKontrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::KromelProgram.Properties.Resources.LOGO;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 421);
            this.panel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeToolStripMenuItem,
            this.mamulToolStripMenuItem,
            this.maliyetHesabiToolStripMenuItem,
            this.projeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // malzemeToolStripMenuItem
            // 
            this.malzemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malzemeKontrolToolStripMenuItem});
            this.malzemeToolStripMenuItem.Name = "malzemeToolStripMenuItem";
            this.malzemeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.malzemeToolStripMenuItem.Text = "Malzeme";
            // 
            // malzemeKontrolToolStripMenuItem
            // 
            this.malzemeKontrolToolStripMenuItem.Name = "malzemeKontrolToolStripMenuItem";
            this.malzemeKontrolToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.malzemeKontrolToolStripMenuItem.Text = "Malzeme Kontrol";
            this.malzemeKontrolToolStripMenuItem.Click += new System.EventHandler(this.MalzemeKontrolToolStripMenuItem_Click);
            // 
            // mamulToolStripMenuItem
            // 
            this.mamulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mamulKontrolToolStripMenuItem});
            this.mamulToolStripMenuItem.Name = "mamulToolStripMenuItem";
            this.mamulToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.mamulToolStripMenuItem.Text = "Mamul";
            // 
            // mamulKontrolToolStripMenuItem
            // 
            this.mamulKontrolToolStripMenuItem.Name = "mamulKontrolToolStripMenuItem";
            this.mamulKontrolToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mamulKontrolToolStripMenuItem.Text = "Mamul Kontrol";
            this.mamulKontrolToolStripMenuItem.Click += new System.EventHandler(this.MamulKontrolToolStripMenuItem_Click);
            // 
            // maliyetHesabiToolStripMenuItem
            // 
            this.maliyetHesabiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardMaliyetHesabıToolStripMenuItem,
            this.maliyetHesabiKontrolToolStripMenuItem});
            this.maliyetHesabiToolStripMenuItem.Name = "maliyetHesabiToolStripMenuItem";
            this.maliyetHesabiToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.maliyetHesabiToolStripMenuItem.Text = "Mamul Maliyetlendirme";
            // 
            // standardMaliyetHesabıToolStripMenuItem
            // 
            this.standardMaliyetHesabıToolStripMenuItem.Name = "standardMaliyetHesabıToolStripMenuItem";
            this.standardMaliyetHesabıToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.standardMaliyetHesabıToolStripMenuItem.Text = "Standard Maliyet Hesabı";
            this.standardMaliyetHesabıToolStripMenuItem.Click += new System.EventHandler(this.StandardMaliyetHesabıToolStripMenuItem_Click);
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.projeToolStripMenuItem.Text = "Proje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::KromelProgram.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(631, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 20);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(427, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 16);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(631, 20);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(427, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 16);
            this.panel6.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 40);
            this.panel2.TabIndex = 1;
            // 
            // maliyetHesabiKontrolToolStripMenuItem
            // 
            this.maliyetHesabiKontrolToolStripMenuItem.Name = "maliyetHesabiKontrolToolStripMenuItem";
            this.maliyetHesabiKontrolToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.maliyetHesabiKontrolToolStripMenuItem.Text = "Maliyet Hesabi Kontrol";
            this.maliyetHesabiKontrolToolStripMenuItem.Click += new System.EventHandler(this.MaliyetHesabiKontrolToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KROMEL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem malzemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mamulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maliyetHesabiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardMaliyetHesabıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem mamulKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem malzemeKontrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maliyetHesabiKontrolToolStripMenuItem;
    }
}

