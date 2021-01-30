namespace KromelProgram
{
    partial class MalzemeKontrolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeKontrolForm));
            this.malzemeTableAdapter = new KromelProgram.KromelDBDataSetTableAdapters.MalzemeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kromelDBDataSet = new KromelProgram.KromelDBDataSet();
            this.panel7 = new System.Windows.Forms.Panel();
            this.filtreleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.parameterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.parameterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.filtreleToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGuncele = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMalzeme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMalzemeAdi = new System.Windows.Forms.TextBox();
            this.textBoxMalzemeKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).BeginInit();
            this.panel7.SuspendLayout();
            this.filtreleToolStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // malzemeTableAdapter
            // 
            this.malzemeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeIDDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.malzemeDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // malzemeIDDataGridViewTextBoxColumn
            // 
            this.malzemeIDDataGridViewTextBoxColumn.DataPropertyName = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.HeaderText = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.Name = "malzemeIDDataGridViewTextBoxColumn";
            this.malzemeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            // 
            // malzemeDataGridViewTextBoxColumn
            // 
            this.malzemeDataGridViewTextBoxColumn.DataPropertyName = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.HeaderText = "Malzeme";
            this.malzemeDataGridViewTextBoxColumn.Name = "malzemeDataGridViewTextBoxColumn";
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataMember = "Malzeme";
            this.malzemeBindingSource.DataSource = this.kromelDBDataSet;
            // 
            // kromelDBDataSet
            // 
            this.kromelDBDataSet.DataSetName = "KromelDBDataSet";
            this.kromelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(800, 342);
            this.panel7.TabIndex = 5;
            // 
            // filtreleToolStripButton
            // 
            this.filtreleToolStripButton.Image = global::KromelProgram.Properties.Resources.filter_512;
            this.filtreleToolStripButton.Name = "filtreleToolStripButton";
            this.filtreleToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.filtreleToolStripButton.Text = "Filtrele";
            this.filtreleToolStripButton.Click += new System.EventHandler(this.FiltreleToolStripButton_Click);
            // 
            // parameterToolStripTextBox
            // 
            this.parameterToolStripTextBox.Name = "parameterToolStripTextBox";
            this.parameterToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // parameterToolStripLabel
            // 
            this.parameterToolStripLabel.Name = "parameterToolStripLabel";
            this.parameterToolStripLabel.Size = new System.Drawing.Size(25, 22);
            this.parameterToolStripLabel.Text = "Ara";
            // 
            // filtreleToolStrip
            // 
            this.filtreleToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filtreleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterToolStripLabel,
            this.parameterToolStripTextBox,
            this.filtreleToolStripButton,
            this.toolStripButtonGuncele});
            this.filtreleToolStrip.Location = new System.Drawing.Point(0, 90);
            this.filtreleToolStrip.Name = "filtreleToolStrip";
            this.filtreleToolStrip.Size = new System.Drawing.Size(796, 25);
            this.filtreleToolStrip.TabIndex = 4;
            this.filtreleToolStrip.Text = "filtreleToolStrip";
            // 
            // toolStripButtonGuncele
            // 
            this.toolStripButtonGuncele.Image = global::KromelProgram.Properties.Resources.saveicon;
            this.toolStripButtonGuncele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncele.Name = "toolStripButtonGuncele";
            this.toolStripButtonGuncele.Size = new System.Drawing.Size(121, 22);
            this.toolStripButtonGuncele.Text = "Malzeme Guncele";
            this.toolStripButtonGuncele.Click += new System.EventHandler(this.ToolStripButtonGuncele_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dateTimePickerTarih);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxBirimFiyat);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxMalzeme);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxMalzemeAdi);
            this.panel3.Controls.Add(this.textBoxMalzemeKod);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.filtreleToolStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 119);
            this.panel3.TabIndex = 4;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.malzemeBindingSource, "Tarih", true));
            this.dateTimePickerTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTarih.Location = new System.Drawing.Point(294, 29);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerTarih.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tarih";
            // 
            // textBoxBirimFiyat
            // 
            this.textBoxBirimFiyat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "BirimFiyat", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBoxBirimFiyat.Location = new System.Drawing.Point(294, 4);
            this.textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            this.textBoxBirimFiyat.Size = new System.Drawing.Size(101, 20);
            this.textBoxBirimFiyat.TabIndex = 4;
            this.textBoxBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birim Fiyat";
            // 
            // textBoxMalzeme
            // 
            this.textBoxMalzeme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "Malzeme", true));
            this.textBoxMalzeme.Location = new System.Drawing.Point(83, 55);
            this.textBoxMalzeme.Name = "textBoxMalzeme";
            this.textBoxMalzeme.Size = new System.Drawing.Size(140, 20);
            this.textBoxMalzeme.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Malzeme";
            // 
            // textBoxMalzemeAdi
            // 
            this.textBoxMalzemeAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "MalzemeAdi", true));
            this.textBoxMalzemeAdi.Location = new System.Drawing.Point(83, 29);
            this.textBoxMalzemeAdi.Name = "textBoxMalzemeAdi";
            this.textBoxMalzemeAdi.Size = new System.Drawing.Size(140, 20);
            this.textBoxMalzemeAdi.TabIndex = 2;
            // 
            // textBoxMalzemeKod
            // 
            this.textBoxMalzemeKod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "MalzemeID", true));
            this.textBoxMalzemeKod.Location = new System.Drawing.Point(83, 3);
            this.textBoxMalzemeKod.Name = "textBoxMalzemeKod";
            this.textBoxMalzemeKod.Size = new System.Drawing.Size(140, 20);
            this.textBoxMalzemeKod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Malzeme Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Malzeme Kod";
            // 
            // MalzemeKontrolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "MalzemeKontrolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MalzemeKontrolForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).EndInit();
            this.panel7.ResumeLayout(false);
            this.filtreleToolStrip.ResumeLayout(false);
            this.filtreleToolStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private KromelDBDataSetTableAdapters.MalzemeTableAdapter malzemeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private KromelDBDataSet kromelDBDataSet;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripButton filtreleToolStripButton;
        private System.Windows.Forms.ToolStripTextBox parameterToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel parameterToolStripLabel;
        private System.Windows.Forms.ToolStrip filtreleToolStrip;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncele;
        private System.Windows.Forms.TextBox textBoxMalzemeAdi;
        private System.Windows.Forms.TextBox textBoxMalzemeKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMalzeme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBirimFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}