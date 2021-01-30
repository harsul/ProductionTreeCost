namespace KromelProgram.Forms.Mamul
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mamulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamulAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cizim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TeknikSartname = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mamulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new KromelProgram.Data.DatabaseDataSet();
            this.fillByIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.parameterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.parameterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mamulTableAdapter = new KromelProgram.Data.DatabaseDataSetTableAdapters.MamulTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.fillByIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sec,
            this.mamulIDDataGridViewTextBoxColumn,
            this.mamulAdiDataGridViewTextBoxColumn,
            this.kapasiteDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn,
            this.Cizim,
            this.TeknikSartname});
            this.dataGridView1.DataSource = this.mamulBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(884, 436);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sec
            // 
            this.Sec.HeaderText = "Seç";
            this.Sec.Name = "Sec";
            this.Sec.ReadOnly = true;
            this.Sec.Text = "Seç";
            this.Sec.UseColumnTextForButtonValue = true;
            // 
            // mamulIDDataGridViewTextBoxColumn
            // 
            this.mamulIDDataGridViewTextBoxColumn.DataPropertyName = "MamulID";
            this.mamulIDDataGridViewTextBoxColumn.HeaderText = "Mamul Kodu";
            this.mamulIDDataGridViewTextBoxColumn.Name = "mamulIDDataGridViewTextBoxColumn";
            this.mamulIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mamulAdiDataGridViewTextBoxColumn
            // 
            this.mamulAdiDataGridViewTextBoxColumn.DataPropertyName = "MamulAdi";
            this.mamulAdiDataGridViewTextBoxColumn.HeaderText = "Mamul Adi";
            this.mamulAdiDataGridViewTextBoxColumn.Name = "mamulAdiDataGridViewTextBoxColumn";
            this.mamulAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kapasiteDataGridViewTextBoxColumn
            // 
            this.kapasiteDataGridViewTextBoxColumn.DataPropertyName = "Kapasite";
            this.kapasiteDataGridViewTextBoxColumn.HeaderText = "Kapasite";
            this.kapasiteDataGridViewTextBoxColumn.Name = "kapasiteDataGridViewTextBoxColumn";
            this.kapasiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            this.resimDataGridViewTextBoxColumn.ReadOnly = true;
            this.resimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resimDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cizim
            // 
            this.Cizim.DataPropertyName = "Cizim";
            this.Cizim.HeaderText = "Cizim";
            this.Cizim.Name = "Cizim";
            this.Cizim.ReadOnly = true;
            this.Cizim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cizim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TeknikSartname
            // 
            this.TeknikSartname.DataPropertyName = "TeknikSartname";
            this.TeknikSartname.HeaderText = "Teknik Sartname";
            this.TeknikSartname.Name = "TeknikSartname";
            this.TeknikSartname.ReadOnly = true;
            this.TeknikSartname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeknikSartname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mamulBindingSource
            // 
            this.mamulBindingSource.DataMember = "Mamul";
            this.mamulBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByIDToolStrip
            // 
            this.fillByIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parameterToolStripLabel,
            this.parameterToolStripTextBox,
            this.fillByIDToolStripButton,
            this.toolStripSeparator1,
            this.newToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.fillByIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIDToolStrip.Name = "fillByIDToolStrip";
            this.fillByIDToolStrip.Size = new System.Drawing.Size(884, 25);
            this.fillByIDToolStrip.TabIndex = 3;
            this.fillByIDToolStrip.Text = "fillByIDToolStrip";
            // 
            // parameterToolStripLabel
            // 
            this.parameterToolStripLabel.Name = "parameterToolStripLabel";
            this.parameterToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.parameterToolStripLabel.Text = "parameter:";
            // 
            // parameterToolStripTextBox
            // 
            this.parameterToolStripTextBox.Name = "parameterToolStripTextBox";
            this.parameterToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            // 
            // fillByIDToolStripButton
            // 
    //        this.fillByIDToolStripButton.Image = global::KromelProgram.Properties.Resources.search_icon;
            this.fillByIDToolStripButton.Name = "fillByIDToolStripButton";
            this.fillByIDToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillByIDToolStripButton.Text = "Ara";
            this.fillByIDToolStripButton.Click += new System.EventHandler(this.fillByFilterToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.newToolStripButton.Text = "Ekle";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // mamulTableAdapter
            // 
            this.mamulTableAdapter.ClearBeforeFill = true;
            // 
            // MamulSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByIDToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MamulSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mamul Secimi";
            this.Load += new System.EventHandler(this.MamulSecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.fillByIDToolStrip.ResumeLayout(false);
            this.fillByIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByIDToolStrip;
        private System.Windows.Forms.ToolStripLabel parameterToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox parameterToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIDToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private Data.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource mamulBindingSource;
        private Data.DatabaseDataSetTableAdapters.MamulTableAdapter mamulTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Cizim;
        private System.Windows.Forms.DataGridViewButtonColumn TeknikSartname;
    }
}