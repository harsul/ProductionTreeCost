namespace KromelProgram.Forms.Mamul
{
    partial class MamulListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MamulListForm));
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UrunAgaci = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mamulIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamulAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cizim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TeknikSartname = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mamulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new KromelProgram.Data.DatabaseDataSet();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonResim = new System.Windows.Forms.Button();
            this.buttonSartname = new System.Windows.Forms.Button();
            this.buttonCizim = new System.Windows.Forms.Button();
            this.textBoxSartname = new System.Windows.Forms.TextBox();
            this.textBoxCizim = new System.Windows.Forms.TextBox();
            this.textBoxResimYolu = new System.Windows.Forms.TextBox();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.textBoxMamulAdi = new System.Windows.Forms.TextBox();
            this.textBoxKapasite = new System.Windows.Forms.TextBox();
            this.textBoxMamulID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.parametreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.filterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mamulTableAdapter = new KromelProgram.Data.DatabaseDataSetTableAdapters.MamulTableAdapter();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView1);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(22, 125);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(842, 317);
            this.panel9.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunAgaci,
            this.mamulIDDataGridViewTextBoxColumn,
            this.mamulAdiDataGridViewTextBoxColumn,
            this.kapasiteDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn,
            this.Cizim,
            this.TeknikSartname});
            this.dataGridView1.DataSource = this.mamulBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UrunAgaci
            // 
            this.UrunAgaci.DataPropertyName = "MamulID";
            this.UrunAgaci.FillWeight = 50F;
            this.UrunAgaci.HeaderText = "Ürün Ağaci";
            this.UrunAgaci.Name = "UrunAgaci";
            this.UrunAgaci.Text = "Aç";
            this.UrunAgaci.UseColumnTextForButtonValue = true;
            // 
            // mamulIDDataGridViewTextBoxColumn
            // 
            this.mamulIDDataGridViewTextBoxColumn.DataPropertyName = "MamulID";
            this.mamulIDDataGridViewTextBoxColumn.HeaderText = "Mamul Kodu";
            this.mamulIDDataGridViewTextBoxColumn.Name = "mamulIDDataGridViewTextBoxColumn";
            // 
            // mamulAdiDataGridViewTextBoxColumn
            // 
            this.mamulAdiDataGridViewTextBoxColumn.DataPropertyName = "MamulAdi";
            this.mamulAdiDataGridViewTextBoxColumn.HeaderText = "Mamul Adi";
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
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            this.resimDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resimDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resimDataGridViewTextBoxColumn.Text = "";
            // 
            // Cizim
            // 
            this.Cizim.DataPropertyName = "Cizim";
            this.Cizim.HeaderText = "Cizim";
            this.Cizim.Name = "Cizim";
            this.Cizim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cizim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TeknikSartname
            // 
            this.TeknikSartname.DataPropertyName = "TeknikSartname";
            this.TeknikSartname.HeaderText = "TeknikSartname";
            this.TeknikSartname.Name = "TeknikSartname";
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
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 302);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(842, 15);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(449, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(393, 15);
            this.panel6.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(373, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(20, 15);
            this.panel10.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statusStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(864, 19);
            this.panel4.TabIndex = 23;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMesaj});
            this.statusStrip1.Location = new System.Drawing.Point(0, -3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMesaj
            // 
            this.toolStripStatusLabelMesaj.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabelMesaj.Name = "toolStripStatusLabelMesaj";
            this.toolStripStatusLabelMesaj.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabelMesaj.Text = ".";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(864, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 461);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 317);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.bindingNavigator1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(864, 125);
            this.panel3.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonResim);
            this.groupBox1.Controls.Add(this.buttonSartname);
            this.groupBox1.Controls.Add(this.buttonCizim);
            this.groupBox1.Controls.Add(this.textBoxSartname);
            this.groupBox1.Controls.Add(this.textBoxCizim);
            this.groupBox1.Controls.Add(this.textBoxResimYolu);
            this.groupBox1.Controls.Add(this.pictureBoxResim);
            this.groupBox1.Controls.Add(this.textBoxMamulAdi);
            this.groupBox1.Controls.Add(this.textBoxKapasite);
            this.groupBox1.Controls.Add(this.textBoxMamulID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 96);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // buttonResim
            // 
            this.buttonResim.Location = new System.Drawing.Point(659, 16);
            this.buttonResim.Name = "buttonResim";
            this.buttonResim.Size = new System.Drawing.Size(75, 23);
            this.buttonResim.TabIndex = 36;
            this.buttonResim.Text = "Resim";
            this.buttonResim.UseVisualStyleBackColor = true;
            this.buttonResim.Click += new System.EventHandler(this.buttonResimEkle_Click);
            // 
            // buttonSartname
            // 
            this.buttonSartname.Location = new System.Drawing.Point(659, 66);
            this.buttonSartname.Name = "buttonSartname";
            this.buttonSartname.Size = new System.Drawing.Size(75, 23);
            this.buttonSartname.TabIndex = 35;
            this.buttonSartname.Text = "Şartname";
            this.buttonSartname.UseVisualStyleBackColor = true;
            this.buttonSartname.Click += new System.EventHandler(this.buttonSartname_Click);
            // 
            // buttonCizim
            // 
            this.buttonCizim.Location = new System.Drawing.Point(659, 41);
            this.buttonCizim.Name = "buttonCizim";
            this.buttonCizim.Size = new System.Drawing.Size(75, 23);
            this.buttonCizim.TabIndex = 34;
            this.buttonCizim.Text = "Çizim";
            this.buttonCizim.UseVisualStyleBackColor = true;
            this.buttonCizim.Click += new System.EventHandler(this.buttonCizim_Click);
            // 
            // textBoxSartname
            // 
            this.textBoxSartname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "TeknikSartname", true));
            this.textBoxSartname.Location = new System.Drawing.Point(494, 68);
            this.textBoxSartname.Name = "textBoxSartname";
            this.textBoxSartname.Size = new System.Drawing.Size(159, 20);
            this.textBoxSartname.TabIndex = 33;
            // 
            // textBoxCizim
            // 
            this.textBoxCizim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Cizim", true));
            this.textBoxCizim.Location = new System.Drawing.Point(494, 43);
            this.textBoxCizim.Name = "textBoxCizim";
            this.textBoxCizim.Size = new System.Drawing.Size(159, 20);
            this.textBoxCizim.TabIndex = 32;
            // 
            // textBoxResimYolu
            // 
            this.textBoxResimYolu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Resim", true));
            this.textBoxResimYolu.Location = new System.Drawing.Point(494, 17);
            this.textBoxResimYolu.Name = "textBoxResimYolu";
            this.textBoxResimYolu.Size = new System.Drawing.Size(159, 20);
            this.textBoxResimYolu.TabIndex = 31;
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResim.Location = new System.Drawing.Point(398, 15);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(89, 75);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResim.TabIndex = 29;
            this.pictureBoxResim.TabStop = false;
            // 
            // textBoxMamulAdi
            // 
            this.textBoxMamulAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "MamulAdi", true));
            this.textBoxMamulAdi.Location = new System.Drawing.Point(78, 46);
            this.textBoxMamulAdi.Multiline = true;
            this.textBoxMamulAdi.Name = "textBoxMamulAdi";
            this.textBoxMamulAdi.Size = new System.Drawing.Size(156, 44);
            this.textBoxMamulAdi.TabIndex = 25;
            // 
            // textBoxKapasite
            // 
            this.textBoxKapasite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Kapasite", true));
            this.textBoxKapasite.Location = new System.Drawing.Point(292, 18);
            this.textBoxKapasite.Name = "textBoxKapasite";
            this.textBoxKapasite.Size = new System.Drawing.Size(100, 20);
            this.textBoxKapasite.TabIndex = 26;
            // 
            // textBoxMamulID
            // 
            this.textBoxMamulID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "MamulID", true));
            this.textBoxMamulID.Location = new System.Drawing.Point(78, 18);
            this.textBoxMamulID.Name = "textBoxMamulID";
            this.textBoxMamulID.ReadOnly = true;
            this.textBoxMamulID.Size = new System.Drawing.Size(156, 20);
            this.textBoxMamulID.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kapasite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mamul Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mamul Adı";
            // 
            // textBoxTip
            // 
            this.textBoxTip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mamulBindingSource, "Tip", true));
            this.textBoxTip.Location = new System.Drawing.Point(292, 44);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(100, 20);
            this.textBoxTip.TabIndex = 28;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.mamulBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.parametreToolStripTextBox,
            this.filterToolStripButton,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(860, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni Ekle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Filtre";
            // 
            // parametreToolStripTextBox
            // 
            this.parametreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.parametreToolStripTextBox.Name = "parametreToolStripTextBox";
            this.parametreToolStripTextBox.Size = new System.Drawing.Size(125, 25);
            // 
            // filterToolStripButton
            // 
     //       this.filterToolStripButton.Image = global::KromelProgram.Properties.Resources.search_icon;
            this.filterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterToolStripButton.Name = "filterToolStripButton";
            this.filterToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.filterToolStripButton.Text = "Ara";
            this.filterToolStripButton.Click += new System.EventHandler(this.fillByFilterToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Kaydet";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
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
            // MamulListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MamulListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mamul";
            this.Load += new System.EventHandler(this.MamulListForm_Load);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mamulBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox parametreToolStripTextBox;
        private System.Windows.Forms.ToolStripButton filterToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private Data.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource mamulBindingSource;
        private Data.DatabaseDataSetTableAdapters.MamulTableAdapter mamulTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxResimYolu;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.TextBox textBoxMamulAdi;
        private System.Windows.Forms.TextBox textBoxKapasite;
        private System.Windows.Forms.TextBox textBoxMamulID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMesaj;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button buttonSartname;
        private System.Windows.Forms.Button buttonCizim;
        private System.Windows.Forms.TextBox textBoxSartname;
        private System.Windows.Forms.TextBox textBoxCizim;
        private System.Windows.Forms.DataGridViewButtonColumn UrunAgaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamulAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Cizim;
        private System.Windows.Forms.DataGridViewButtonColumn TeknikSartname;
        private System.Windows.Forms.Button buttonResim;
    }
}