namespace KromelProgram.Forms.Malzeme
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fillByIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.parameterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.parameterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fillByIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.malzemeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Olcu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Olcu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalinlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new KromelProgram.Data.DatabaseDataSet();
            this.malzemeTableAdapter = new KromelProgram.Data.DatabaseDataSetTableAdapters.MalzemeTableAdapter();
            this.fillByIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.newToolStripButton.Text = "Ekle";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // fillByIDToolStripButton
            // 
//            this.fillByIDToolStripButton.Image = global::KromelProgram.Properties.Resources.search_icon;
            this.fillByIDToolStripButton.Name = "fillByIDToolStripButton";
            this.fillByIDToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillByIDToolStripButton.Text = "Ara";
            this.fillByIDToolStripButton.Click += new System.EventHandler(this.fillByFilterToolStripButton_Click);
            // 
            // parameterToolStripTextBox
            // 
            this.parameterToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.parameterToolStripTextBox.Name = "parameterToolStripTextBox";
            this.parameterToolStripTextBox.Size = new System.Drawing.Size(120, 25);
            // 
            // parameterToolStripLabel
            // 
            this.parameterToolStripLabel.Name = "parameterToolStripLabel";
            this.parameterToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.parameterToolStripLabel.Text = "Filtre:";
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
            this.fillByIDToolStrip.TabIndex = 5;
            this.fillByIDToolStrip.Text = "fillByIDToolStrip";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sec,
            this.malzemeIDDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.malzemeGrubuDataGridViewTextBoxColumn,
            this.Olcu1,
            this.Olcu2,
            this.Kalinlik,
            this.Boy,
            this.fiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.malzemeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(884, 436);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Sec
            // 
            this.Sec.FillWeight = 50F;
            this.Sec.HeaderText = "Seç";
            this.Sec.Name = "Sec";
            this.Sec.ReadOnly = true;
            this.Sec.Text = "Seç";
            this.Sec.UseColumnTextForButtonValue = true;
            // 
            // malzemeIDDataGridViewTextBoxColumn
            // 
            this.malzemeIDDataGridViewTextBoxColumn.DataPropertyName = "MalzemeID";
            this.malzemeIDDataGridViewTextBoxColumn.HeaderText = "Malzeme Kodu";
            this.malzemeIDDataGridViewTextBoxColumn.Name = "malzemeIDDataGridViewTextBoxColumn";
            this.malzemeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "Malzeme Adi";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            this.malzemeAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemeGrubuDataGridViewTextBoxColumn
            // 
            this.malzemeGrubuDataGridViewTextBoxColumn.DataPropertyName = "MalzemeGrubu";
            this.malzemeGrubuDataGridViewTextBoxColumn.HeaderText = "Malzeme Grubu";
            this.malzemeGrubuDataGridViewTextBoxColumn.Name = "malzemeGrubuDataGridViewTextBoxColumn";
            this.malzemeGrubuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Olcu1
            // 
            this.Olcu1.DataPropertyName = "Olcu1";
            this.Olcu1.HeaderText = "Olcu1";
            this.Olcu1.Name = "Olcu1";
            this.Olcu1.ReadOnly = true;
            // 
            // Olcu2
            // 
            this.Olcu2.DataPropertyName = "Olcu2";
            this.Olcu2.HeaderText = "Olcu2";
            this.Olcu2.Name = "Olcu2";
            this.Olcu2.ReadOnly = true;
            // 
            // Kalinlik
            // 
            this.Kalinlik.DataPropertyName = "Kalinlik";
            this.Kalinlik.HeaderText = "Kalinlik";
            this.Kalinlik.Name = "Kalinlik";
            this.Kalinlik.ReadOnly = true;
            // 
            // Boy
            // 
            this.Boy.DataPropertyName = "Boy";
            this.Boy.HeaderText = "Boy";
            this.Boy.Name = "Boy";
            this.Boy.ReadOnly = true;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malzemeBindingSource
            // 
            this.malzemeBindingSource.DataMember = "Malzeme";
            this.malzemeBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // malzemeTableAdapter
            // 
            this.malzemeTableAdapter.ClearBeforeFill = true;
            // 
            // MalzemeSecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByIDToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MalzemeSecForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Malzeme Seçimi";
            this.Load += new System.EventHandler(this.MalzemeSecForm_Load);
            this.fillByIDToolStrip.ResumeLayout(false);
            this.fillByIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malzemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton fillByIDToolStripButton;
        private System.Windows.Forms.ToolStripTextBox parameterToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel parameterToolStripLabel;
        private System.Windows.Forms.ToolStrip fillByIDToolStrip;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Data.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource malzemeBindingSource;
        private Data.DatabaseDataSetTableAdapters.MalzemeTableAdapter malzemeTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Olcu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Olcu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalinlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boy;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
    }
}