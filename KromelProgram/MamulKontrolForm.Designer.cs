namespace KromelProgram
{
    partial class MamulKontrolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MamulKontrolForm));
            this.mamulTableAdapter = new KromelProgram.KromelDBDataSetTableAdapters.MamulTableAdapter();
            this.parametreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.parametreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mamulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kromelDBDataSet = new KromelProgram.KromelDBDataSet();
            this.filtreleToolStrip = new System.Windows.Forms.ToolStrip();
            this.filtreleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMamulGunceleme = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSatisPazarlama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMusteri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKapasite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMamulAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMamulID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mamulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamulAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazirlayanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).BeginInit();
            this.filtreleToolStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mamulTableAdapter
            // 
            this.mamulTableAdapter.ClearBeforeFill = true;
            // 
            // parametreToolStripTextBox
            // 
            this.parametreToolStripTextBox.Name = "parametreToolStripTextBox";
            this.parametreToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // parametreToolStripLabel
            // 
            this.parametreToolStripLabel.Name = "parametreToolStripLabel";
            this.parametreToolStripLabel.Size = new System.Drawing.Size(25, 22);
            this.parametreToolStripLabel.Text = "Ara";
            // 
            // mamulBindingSource
            // 
            this.mamulBindingSource.DataMember = "Mamul";
            this.mamulBindingSource.DataSource = this.kromelDBDataSet;
            // 
            // kromelDBDataSet
            // 
            this.kromelDBDataSet.DataSetName = "KromelDBDataSet";
            this.kromelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filtreleToolStrip
            // 
            this.filtreleToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filtreleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametreToolStripLabel,
            this.parametreToolStripTextBox,
            this.filtreleToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButtonMamulGunceleme});
            this.filtreleToolStrip.Location = new System.Drawing.Point(0, 135);
            this.filtreleToolStrip.Name = "filtreleToolStrip";
            this.filtreleToolStrip.Size = new System.Drawing.Size(941, 25);
            this.filtreleToolStrip.TabIndex = 6;
            this.filtreleToolStrip.Text = "filtreleToolStrip";
            // 
            // filtreleToolStripButton
            // 
            this.filtreleToolStripButton.Image = global::KromelProgram.Properties.Resources.filter_512;
            this.filtreleToolStripButton.Name = "filtreleToolStripButton";
            this.filtreleToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.filtreleToolStripButton.Text = "Filtrele";
            this.filtreleToolStripButton.Click += new System.EventHandler(this.FiltreleToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMamulGunceleme
            // 
            this.toolStripButtonMamulGunceleme.Image = global::KromelProgram.Properties.Resources.saveicon;
            this.toolStripButtonMamulGunceleme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMamulGunceleme.Name = "toolStripButtonMamulGunceleme";
            this.toolStripButtonMamulGunceleme.Size = new System.Drawing.Size(128, 22);
            this.toolStripButtonMamulGunceleme.Text = "Mamul Gunceleme";
            this.toolStripButtonMamulGunceleme.Click += new System.EventHandler(this.ToolStripButtonMamulGunceleme_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dateTimePickerSiparisTarihi);
            this.panel3.Controls.Add(this.dateTimePickerYayinTarihi);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxSatisPazarlama);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxMusteri);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxTip);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxKapasite);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxMamulAdi);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxMamulID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.filtreleToolStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 164);
            this.panel3.TabIndex = 6;
            // 
            // dateTimePickerSiparisTarihi
            // 
            this.dateTimePickerSiparisTarihi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Siparistarihi", true));
            this.dateTimePickerSiparisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSiparisTarihi.Location = new System.Drawing.Point(316, 57);
            this.dateTimePickerSiparisTarihi.Name = "dateTimePickerSiparisTarihi";
            this.dateTimePickerSiparisTarihi.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerSiparisTarihi.TabIndex = 8;
            // 
            // dateTimePickerYayinTarihi
            // 
            this.dateTimePickerYayinTarihi.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mamulBindingSource, "YayinTarihi", true));
            this.dateTimePickerYayinTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerYayinTarihi.Location = new System.Drawing.Point(74, 106);
            this.dateTimePickerYayinTarihi.Name = "dateTimePickerYayinTarihi";
            this.dateTimePickerYayinTarihi.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerYayinTarihi.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Yayın Tarihi";
            // 
            // textBoxSatisPazarlama
            // 
            this.textBoxSatisPazarlama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "SatisPazarlamaYonetici", true));
            this.textBoxSatisPazarlama.Location = new System.Drawing.Point(316, 80);
            this.textBoxSatisPazarlama.Name = "textBoxSatisPazarlama";
            this.textBoxSatisPazarlama.Size = new System.Drawing.Size(148, 20);
            this.textBoxSatisPazarlama.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Satış Pazarlama";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Hazirlayan", true));
            this.textBox7.Location = new System.Drawing.Point(74, 80);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(148, 20);
            this.textBox7.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hazırlayan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sipariş Tarihi";
            // 
            // textBoxMusteri
            // 
            this.textBoxMusteri.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Musteri", true));
            this.textBoxMusteri.Location = new System.Drawing.Point(74, 54);
            this.textBoxMusteri.Name = "textBoxMusteri";
            this.textBoxMusteri.Size = new System.Drawing.Size(148, 20);
            this.textBoxMusteri.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Müşteri";
            // 
            // textBoxTip
            // 
            this.textBoxTip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Tip", true));
            this.textBoxTip.Location = new System.Drawing.Point(316, 31);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(148, 20);
            this.textBoxTip.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tip";
            // 
            // textBoxKapasite
            // 
            this.textBoxKapasite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Kapasite", true));
            this.textBoxKapasite.Location = new System.Drawing.Point(316, 6);
            this.textBoxKapasite.Name = "textBoxKapasite";
            this.textBoxKapasite.Size = new System.Drawing.Size(148, 20);
            this.textBoxKapasite.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kapasite";
            // 
            // textBoxMamulAdi
            // 
            this.textBoxMamulAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "MamulAdi", true));
            this.textBoxMamulAdi.Location = new System.Drawing.Point(74, 28);
            this.textBoxMamulAdi.Name = "textBoxMamulAdi";
            this.textBoxMamulAdi.Size = new System.Drawing.Size(148, 20);
            this.textBoxMamulAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mamül Adı";
            // 
            // textBoxMamulID
            // 
            this.textBoxMamulID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "MamulID", true));
            this.textBoxMamulID.Location = new System.Drawing.Point(74, 2);
            this.textBoxMamulID.Name = "textBoxMamulID";
            this.textBoxMamulID.Size = new System.Drawing.Size(148, 20);
            this.textBoxMamulID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mamül Kod";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(949, 450);
            this.panel7.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 282);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamulIDDataGridViewTextBoxColumn,
            this.mamulAdiDataGridViewTextBoxColumn,
            this.kapasiteDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.musteriDataGridViewTextBoxColumn,
            this.siparistarihiDataGridViewTextBoxColumn,
            this.hazirlayanDataGridViewTextBoxColumn,
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn,
            this.yayinTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mamulBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // mamulIDDataGridViewTextBoxColumn
            // 
            this.mamulIDDataGridViewTextBoxColumn.DataPropertyName = "MamulID";
            this.mamulIDDataGridViewTextBoxColumn.HeaderText = "MamulID";
            this.mamulIDDataGridViewTextBoxColumn.Name = "mamulIDDataGridViewTextBoxColumn";
            // 
            // mamulAdiDataGridViewTextBoxColumn
            // 
            this.mamulAdiDataGridViewTextBoxColumn.DataPropertyName = "MamulAdi";
            this.mamulAdiDataGridViewTextBoxColumn.HeaderText = "MamulAdi";
            this.mamulAdiDataGridViewTextBoxColumn.Name = "mamulAdiDataGridViewTextBoxColumn";
            // 
            // kapasiteDataGridViewTextBoxColumn
            // 
            this.kapasiteDataGridViewTextBoxColumn.DataPropertyName = "Kapasite";
            this.kapasiteDataGridViewTextBoxColumn.HeaderText = "Kapasite";
            this.kapasiteDataGridViewTextBoxColumn.Name = "kapasiteDataGridViewTextBoxColumn";
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            // 
            // musteriDataGridViewTextBoxColumn
            // 
            this.musteriDataGridViewTextBoxColumn.DataPropertyName = "Musteri";
            this.musteriDataGridViewTextBoxColumn.HeaderText = "Musteri";
            this.musteriDataGridViewTextBoxColumn.Name = "musteriDataGridViewTextBoxColumn";
            // 
            // siparistarihiDataGridViewTextBoxColumn
            // 
            this.siparistarihiDataGridViewTextBoxColumn.DataPropertyName = "Siparistarihi";
            this.siparistarihiDataGridViewTextBoxColumn.HeaderText = "Siparistarihi";
            this.siparistarihiDataGridViewTextBoxColumn.Name = "siparistarihiDataGridViewTextBoxColumn";
            // 
            // hazirlayanDataGridViewTextBoxColumn
            // 
            this.hazirlayanDataGridViewTextBoxColumn.DataPropertyName = "Hazirlayan";
            this.hazirlayanDataGridViewTextBoxColumn.HeaderText = "Hazirlayan";
            this.hazirlayanDataGridViewTextBoxColumn.Name = "hazirlayanDataGridViewTextBoxColumn";
            // 
            // satisPazarlamaYoneticiDataGridViewTextBoxColumn
            // 
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn.DataPropertyName = "SatisPazarlamaYonetici";
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn.HeaderText = "SatisPazarlamaYonetici";
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn.Name = "satisPazarlamaYoneticiDataGridViewTextBoxColumn";
            // 
            // yayinTarihiDataGridViewTextBoxColumn
            // 
            this.yayinTarihiDataGridViewTextBoxColumn.DataPropertyName = "YayinTarihi";
            this.yayinTarihiDataGridViewTextBoxColumn.HeaderText = "YayinTarihi";
            this.yayinTarihiDataGridViewTextBoxColumn.Name = "yayinTarihiDataGridViewTextBoxColumn";
            // 
            // MamulKontrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.panel7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(965, 489);
            this.Name = "MamulKontrolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MamulKontrolForm";
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).EndInit();
            this.filtreleToolStrip.ResumeLayout(false);
            this.filtreleToolStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KromelDBDataSetTableAdapters.MamulTableAdapter mamulTableAdapter;
        private System.Windows.Forms.ToolStripTextBox parametreToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel parametreToolStripLabel;
        private System.Windows.Forms.BindingSource mamulBindingSource;
        private KromelDBDataSet kromelDBDataSet;
        private System.Windows.Forms.ToolStrip filtreleToolStrip;
        private System.Windows.Forms.ToolStripButton filtreleToolStripButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripButton toolStripButtonMamulGunceleme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazirlayanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisPazarlamaYoneticiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerSiparisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerYayinTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSatisPazarlama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMusteri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKapasite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMamulAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMamulID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}