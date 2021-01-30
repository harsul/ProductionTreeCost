namespace KromelProgram
{
    partial class MamulSecForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MamulSecForm));
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mamulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mamulAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazirlayanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kromelDBDataSet = new KromelProgram.KromelDBDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMamulAdi = new System.Windows.Forms.TextBox();
            this.textBoxMamulID = new System.Windows.Forms.TextBox();
            this.filtreleToolStrip = new System.Windows.Forms.ToolStrip();
            this.parametreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.parametreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filtreleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mamulTableAdapter = new KromelProgram.KromelDBDataSetTableAdapters.MamulTableAdapter();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.filtreleToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(840, 433);
            this.panel7.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamulIDDataGridViewTextBoxColumn,
            this.mamulAdiDataGridViewTextBoxColumn,
            this.kapasiteDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.yayinTarihiDataGridViewTextBoxColumn,
            this.musteriDataGridViewTextBoxColumn,
            this.siparistarihiDataGridViewTextBoxColumn,
            this.hazirlayanDataGridViewTextBoxColumn,
            this.satisPazarlamaYoneticiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mamulBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // mamulIDDataGridViewTextBoxColumn
            // 
            this.mamulIDDataGridViewTextBoxColumn.DataPropertyName = "MamulID";
            this.mamulIDDataGridViewTextBoxColumn.HeaderText = "MamulID";
            this.mamulIDDataGridViewTextBoxColumn.Name = "mamulIDDataGridViewTextBoxColumn";
            this.mamulIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mamulIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // yayinTarihiDataGridViewTextBoxColumn
            // 
            this.yayinTarihiDataGridViewTextBoxColumn.DataPropertyName = "YayinTarihi";
            this.yayinTarihiDataGridViewTextBoxColumn.HeaderText = "YayinTarihi";
            this.yayinTarihiDataGridViewTextBoxColumn.Name = "yayinTarihiDataGridViewTextBoxColumn";
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBoxMamulAdi);
            this.panel3.Controls.Add(this.textBoxMamulID);
            this.panel3.Controls.Add(this.filtreleToolStrip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 28);
            this.panel3.TabIndex = 4;
            // 
            // textBoxMamulAdi
            // 
            this.textBoxMamulAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "MamulAdi", true));
            this.textBoxMamulAdi.Location = new System.Drawing.Point(377, 2);
            this.textBoxMamulAdi.Name = "textBoxMamulAdi";
            this.textBoxMamulAdi.ReadOnly = true;
            this.textBoxMamulAdi.Size = new System.Drawing.Size(258, 20);
            this.textBoxMamulAdi.TabIndex = 8;
            // 
            // textBoxMamulID
            // 
            this.textBoxMamulID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "MamulID", true));
            this.textBoxMamulID.Location = new System.Drawing.Point(271, 2);
            this.textBoxMamulID.Name = "textBoxMamulID";
            this.textBoxMamulID.ReadOnly = true;
            this.textBoxMamulID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMamulID.TabIndex = 7;
            // 
            // filtreleToolStrip
            // 
            this.filtreleToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtreleToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametreToolStripLabel,
            this.parametreToolStripTextBox,
            this.filtreleToolStripButton});
            this.filtreleToolStrip.Location = new System.Drawing.Point(0, 0);
            this.filtreleToolStrip.Name = "filtreleToolStrip";
            this.filtreleToolStrip.Size = new System.Drawing.Size(836, 24);
            this.filtreleToolStrip.TabIndex = 6;
            this.filtreleToolStrip.Text = "filtreleToolStrip";
            // 
            // parametreToolStripLabel
            // 
            this.parametreToolStripLabel.Name = "parametreToolStripLabel";
            this.parametreToolStripLabel.Size = new System.Drawing.Size(25, 21);
            this.parametreToolStripLabel.Text = "Ara";
            // 
            // parametreToolStripTextBox
            // 
            this.parametreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.parametreToolStripTextBox.Name = "parametreToolStripTextBox";
            this.parametreToolStripTextBox.Size = new System.Drawing.Size(150, 24);
            // 
            // filtreleToolStripButton
            // 
            this.filtreleToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filtreleToolStripButton.Name = "filtreleToolStripButton";
            this.filtreleToolStripButton.Size = new System.Drawing.Size(46, 21);
            this.filtreleToolStripButton.Text = "Filtrele";
            this.filtreleToolStripButton.Click += new System.EventHandler(this.FiltreleToolStripButton_Click);
            // 
            // mamulTableAdapter
            // 
            this.mamulTableAdapter.ClearBeforeFill = true;
            // 
            // MamulSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 461);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(856, 500);
            this.Name = "MamulSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MamulSecForm";
            this.Load += new System.EventHandler(this.MamulSecForm_Load);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.filtreleToolStrip.ResumeLayout(false);
            this.filtreleToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KromelDBDataSet kromelDBDataSet;
        private System.Windows.Forms.BindingSource mamulBindingSource;
        private KromelDBDataSetTableAdapters.MamulTableAdapter mamulTableAdapter;
        private System.Windows.Forms.ToolStrip filtreleToolStrip;
        private System.Windows.Forms.ToolStripLabel parametreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox parametreToolStripTextBox;
        private System.Windows.Forms.ToolStripButton filtreleToolStripButton;
        private System.Windows.Forms.DataGridViewButtonColumn mamulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hazirlayanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisPazarlamaYoneticiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxMamulAdi;
        private System.Windows.Forms.TextBox textBoxMamulID;
    }
}