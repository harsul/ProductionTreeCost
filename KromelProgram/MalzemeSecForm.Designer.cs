namespace KromelProgram
{
    partial class MalzemeSecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalzemeSecForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kromelDBDataSet = new KromelProgram.KromelDBDataSet();
            this.textBoxMalzemeAdi = new System.Windows.Forms.TextBox();
            this.textBoxMalzemeID = new System.Windows.Forms.TextBox();
            this.filtreleToolStrip = new System.Windows.Forms.ToolStrip();
            this.parameterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.parameterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filtreleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.malzemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeTableAdapter = new KromelProgram.KromelDBDataSetTableAdapters.MalzemeTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).BeginInit();
            this.filtreleToolStrip.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBoxBirimFiyat);
            this.panel3.Controls.Add(this.textBoxMalzemeAdi);
            this.panel3.Controls.Add(this.textBoxMalzemeID);
            this.panel3.Controls.Add(this.filtreleToolStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 28);
            this.panel3.TabIndex = 2;
            // 
            // textBoxBirimFiyat
            // 
            this.textBoxBirimFiyat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "BirimFiyat", true));
            this.textBoxBirimFiyat.Location = new System.Drawing.Point(549, 2);
            this.textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            this.textBoxBirimFiyat.ReadOnly = true;
            this.textBoxBirimFiyat.Size = new System.Drawing.Size(65, 20);
            this.textBoxBirimFiyat.TabIndex = 7;
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
            // textBoxMalzemeAdi
            // 
            this.textBoxMalzemeAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "MalzemeAdi", true));
            this.textBoxMalzemeAdi.Location = new System.Drawing.Point(381, 2);
            this.textBoxMalzemeAdi.Name = "textBoxMalzemeAdi";
            this.textBoxMalzemeAdi.ReadOnly = true;
            this.textBoxMalzemeAdi.Size = new System.Drawing.Size(162, 20);
            this.textBoxMalzemeAdi.TabIndex = 6;
            // 
            // textBoxMalzemeID
            // 
            this.textBoxMalzemeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.malzemeBindingSource, "MalzemeID", true));
            this.textBoxMalzemeID.Location = new System.Drawing.Point(275, 2);
            this.textBoxMalzemeID.Name = "textBoxMalzemeID";
            this.textBoxMalzemeID.ReadOnly = true;
            this.textBoxMalzemeID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMalzemeID.TabIndex = 5;
            // 
            // filtreleToolStrip
            // 
            this.filtreleToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtreleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterToolStripLabel,
            this.parameterToolStripTextBox,
            this.filtreleToolStripButton});
            this.filtreleToolStrip.Location = new System.Drawing.Point(0, 0);
            this.filtreleToolStrip.Name = "filtreleToolStrip";
            this.filtreleToolStrip.Size = new System.Drawing.Size(753, 24);
            this.filtreleToolStrip.TabIndex = 4;
            this.filtreleToolStrip.Text = "filtreleToolStrip";
            // 
            // parameterToolStripLabel
            // 
            this.parameterToolStripLabel.Name = "parameterToolStripLabel";
            this.parameterToolStripLabel.Size = new System.Drawing.Size(49, 21);
            this.parameterToolStripLabel.Text = "ARAMA";
            // 
            // parameterToolStripTextBox
            // 
            this.parameterToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.parameterToolStripTextBox.Name = "parameterToolStripTextBox";
            this.parameterToolStripTextBox.Size = new System.Drawing.Size(150, 24);
            // 
            // filtreleToolStripButton
            // 
            this.filtreleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtreleToolStripButton.Name = "filtreleToolStripButton";
            this.filtreleToolStripButton.Size = new System.Drawing.Size(46, 21);
            this.filtreleToolStripButton.Text = "Filtrele";
            this.filtreleToolStripButton.Click += new System.EventHandler(this.FiltreleToolStripButton_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(757, 433);
            this.panel7.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzemeIDDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.malzemeDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(753, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // malzemeIDDataGridViewTextBoxColumn
            // 
            this.malzemeIDDataGridViewTextBoxColumn.DataPropertyName = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.HeaderText = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.Name = "malzemeIDDataGridViewTextBoxColumn";
            this.malzemeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.malzemeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // malzemeTableAdapter
            // 
            this.malzemeTableAdapter.ClearBeforeFill = true;
            // 
            // MalzemeSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 461);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(655, 500);
            this.Name = "MalzemeSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MalzemeSecForm";
            this.Load += new System.EventHandler(this.MalzemeSecForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).EndInit();
            this.filtreleToolStrip.ResumeLayout(false);
            this.filtreleToolStrip.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KromelDBDataSet kromelDBDataSet;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private KromelDBDataSetTableAdapters.MalzemeTableAdapter malzemeTableAdapter;
        private System.Windows.Forms.ToolStrip filtreleToolStrip;
        private System.Windows.Forms.ToolStripLabel parameterToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox parameterToolStripTextBox;
        private System.Windows.Forms.ToolStripButton filtreleToolStripButton;
        private System.Windows.Forms.TextBox textBoxBirimFiyat;
        private System.Windows.Forms.TextBox textBoxMalzemeAdi;
        private System.Windows.Forms.TextBox textBoxMalzemeID;
        private System.Windows.Forms.DataGridViewButtonColumn malzemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}