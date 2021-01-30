namespace KromelProgram
{
    partial class MaliyetDetayForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIscilikUcret = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textIscilikSaat = new System.Windows.Forms.TextBox();
            this.textmalzemeMaliyeti = new System.Windows.Forms.TextBox();
            this.txtgenelToplam = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtdamgaVergisi = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtsatisMaliyeti = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtgirmeyenAmortismanToplam = new System.Windows.Forms.TextBox();
            this.girmeyenAmortismanUcret = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtgenelYonetimToplam = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt4satisPazarlamaToplam = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxMamulAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtargeToplam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genelYonetimUcret = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.satisPazarlamaUcret = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.argeUcret = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txturetimMaliyeti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtamortismanToplam = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgenelUretimToplam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.amortismanUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genelUretimUcret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.direktIscilikUcret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdirektIscilikToplam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kromelDBDataSet = new KromelProgram.KromelDBDataSet();
            this.iscilikGiderleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iscilikGiderleriTableAdapter = new KromelProgram.KromelDBDataSetTableAdapters.IscilikGiderleriTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscilikGiderleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "İŞÇİLİK (ücret)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIscilikUcret
            // 
            this.textBoxIscilikUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "ToplamIscilik", true));
            this.textBoxIscilikUcret.Location = new System.Drawing.Point(96, 45);
            this.textBoxIscilikUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIscilikUcret.Name = "textBoxIscilikUcret";
            this.textBoxIscilikUcret.ReadOnly = true;
            this.textBoxIscilikUcret.Size = new System.Drawing.Size(41, 20);
            this.textBoxIscilikUcret.TabIndex = 74;
            this.textBoxIscilikUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 22);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 13);
            this.label29.TabIndex = 73;
            this.label29.Text = "İŞÇİLİK (saat)";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textIscilikSaat
            // 
            this.textIscilikSaat.Location = new System.Drawing.Point(96, 19);
            this.textIscilikSaat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textIscilikSaat.Name = "textIscilikSaat";
            this.textIscilikSaat.ReadOnly = true;
            this.textIscilikSaat.Size = new System.Drawing.Size(41, 20);
            this.textIscilikSaat.TabIndex = 72;
            this.textIscilikSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textmalzemeMaliyeti
            // 
            this.textmalzemeMaliyeti.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textmalzemeMaliyeti.Location = new System.Drawing.Point(273, 50);
            this.textmalzemeMaliyeti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textmalzemeMaliyeti.Name = "textmalzemeMaliyeti";
            this.textmalzemeMaliyeti.Size = new System.Drawing.Size(100, 20);
            this.textmalzemeMaliyeti.TabIndex = 71;
            this.textmalzemeMaliyeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtgenelToplam
            // 
            this.txtgenelToplam.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtgenelToplam.Location = new System.Drawing.Point(273, 393);
            this.txtgenelToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgenelToplam.Name = "txtgenelToplam";
            this.txtgenelToplam.ReadOnly = true;
            this.txtgenelToplam.Size = new System.Drawing.Size(100, 20);
            this.txtgenelToplam.TabIndex = 70;
            this.txtgenelToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(177, 396);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(90, 13);
            this.label28.TabIndex = 69;
            this.label28.Text = "GENEL TOPLAM";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(58, 366);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(209, 13);
            this.label27.TabIndex = 68;
            this.label27.Text = "Damga Vergisi (Maliyet + 25%= Kalan * 1%)";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdamgaVergisi
            // 
            this.txtdamgaVergisi.Location = new System.Drawing.Point(273, 363);
            this.txtdamgaVergisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdamgaVergisi.Name = "txtdamgaVergisi";
            this.txtdamgaVergisi.ReadOnly = true;
            this.txtdamgaVergisi.Size = new System.Drawing.Size(100, 20);
            this.txtdamgaVergisi.TabIndex = 67;
            this.txtdamgaVergisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(177, 340);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 13);
            this.label26.TabIndex = 66;
            this.label26.Text = "SATIŞ MALİYETİ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsatisMaliyeti
            // 
            this.txtsatisMaliyeti.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsatisMaliyeti.Location = new System.Drawing.Point(273, 337);
            this.txtsatisMaliyeti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsatisMaliyeti.Name = "txtsatisMaliyeti";
            this.txtsatisMaliyeti.ReadOnly = true;
            this.txtsatisMaliyeti.Size = new System.Drawing.Size(100, 20);
            this.txtsatisMaliyeti.TabIndex = 65;
            this.txtsatisMaliyeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(216, 303);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 13);
            this.label25.TabIndex = 64;
            this.label25.Text = "TOPLAM";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgirmeyenAmortismanToplam
            // 
            this.txtgirmeyenAmortismanToplam.Location = new System.Drawing.Point(273, 300);
            this.txtgirmeyenAmortismanToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgirmeyenAmortismanToplam.Name = "txtgirmeyenAmortismanToplam";
            this.txtgirmeyenAmortismanToplam.ReadOnly = true;
            this.txtgirmeyenAmortismanToplam.Size = new System.Drawing.Size(100, 20);
            this.txtgirmeyenAmortismanToplam.TabIndex = 63;
            this.txtgirmeyenAmortismanToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // girmeyenAmortismanUcret
            // 
            this.girmeyenAmortismanUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.girmeyenAmortismanUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "GirmeyenAmortisman", true));
            this.girmeyenAmortismanUcret.Location = new System.Drawing.Point(165, 300);
            this.girmeyenAmortismanUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.girmeyenAmortismanUcret.Name = "girmeyenAmortismanUcret";
            this.girmeyenAmortismanUcret.Size = new System.Drawing.Size(41, 20);
            this.girmeyenAmortismanUcret.TabIndex = 62;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 303);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(150, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Maliyete Girmeyen Amortisman";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(163, 204);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "ÜCRET";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 276);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "TOPLAM";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgenelYonetimToplam
            // 
            this.txtgenelYonetimToplam.Location = new System.Drawing.Point(273, 273);
            this.txtgenelYonetimToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgenelYonetimToplam.Name = "txtgenelYonetimToplam";
            this.txtgenelYonetimToplam.ReadOnly = true;
            this.txtgenelYonetimToplam.Size = new System.Drawing.Size(100, 20);
            this.txtgenelYonetimToplam.TabIndex = 52;
            this.txtgenelYonetimToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(216, 250);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "TOPLAM";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt4satisPazarlamaToplam
            // 
            this.txt4satisPazarlamaToplam.Location = new System.Drawing.Point(273, 247);
            this.txt4satisPazarlamaToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt4satisPazarlamaToplam.Name = "txt4satisPazarlamaToplam";
            this.txt4satisPazarlamaToplam.ReadOnly = true;
            this.txt4satisPazarlamaToplam.Size = new System.Drawing.Size(100, 20);
            this.txt4satisPazarlamaToplam.TabIndex = 50;
            this.txt4satisPazarlamaToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(216, 224);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "TOPLAM";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMamulAdi
            // 
            this.textBoxMamulAdi.Location = new System.Drawing.Point(132, 12);
            this.textBoxMamulAdi.Name = "textBoxMamulAdi";
            this.textBoxMamulAdi.ReadOnly = true;
            this.textBoxMamulAdi.Size = new System.Drawing.Size(207, 20);
            this.textBoxMamulAdi.TabIndex = 41;
            this.textBoxMamulAdi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mamül Adı";
            // 
            // txtargeToplam
            // 
            this.txtargeToplam.Location = new System.Drawing.Point(273, 221);
            this.txtargeToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtargeToplam.Name = "txtargeToplam";
            this.txtargeToplam.ReadOnly = true;
            this.txtargeToplam.Size = new System.Drawing.Size(100, 20);
            this.txtargeToplam.TabIndex = 48;
            this.txtargeToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxIscilikUcret);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.textIscilikSaat);
            this.groupBox1.Controls.Add(this.textmalzemeMaliyeti);
            this.groupBox1.Controls.Add(this.txtgenelToplam);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtdamgaVergisi);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtsatisMaliyeti);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtgirmeyenAmortismanToplam);
            this.groupBox1.Controls.Add(this.girmeyenAmortismanUcret);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtgenelYonetimToplam);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt4satisPazarlamaToplam);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtargeToplam);
            this.groupBox1.Controls.Add(this.genelYonetimUcret);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.satisPazarlamaUcret);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.argeUcret);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txturetimMaliyeti);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtamortismanToplam);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtgenelUretimToplam);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.amortismanUcret);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.genelUretimUcret);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.direktIscilikUcret);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdirektIscilikToplam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(400, 437);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALIYET DETAY TABLOSU";
            // 
            // genelYonetimUcret
            // 
            this.genelYonetimUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.genelYonetimUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "GenelYonetim", true));
            this.genelYonetimUcret.Location = new System.Drawing.Point(165, 274);
            this.genelYonetimUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.genelYonetimUcret.Name = "genelYonetimUcret";
            this.genelYonetimUcret.Size = new System.Drawing.Size(41, 20);
            this.genelYonetimUcret.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(76, 276);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Genel Yönetim";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satisPazarlamaUcret
            // 
            this.satisPazarlamaUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.satisPazarlamaUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "SatisPazarlama", true));
            this.satisPazarlamaUcret.Location = new System.Drawing.Point(165, 248);
            this.satisPazarlamaUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.satisPazarlamaUcret.Name = "satisPazarlamaUcret";
            this.satisPazarlamaUcret.Size = new System.Drawing.Size(41, 20);
            this.satisPazarlamaUcret.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 250);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Satiş ve Pazarlama";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // argeUcret
            // 
            this.argeUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.argeUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "Arge", true));
            this.argeUcret.Location = new System.Drawing.Point(165, 222);
            this.argeUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.argeUcret.Name = "argeUcret";
            this.argeUcret.Size = new System.Drawing.Size(41, 20);
            this.argeUcret.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(109, 225);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "AR-GE ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 178);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "ÜRETİM MALİYETİ (Malzeme Dahil)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txturetimMaliyeti
            // 
            this.txturetimMaliyeti.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txturetimMaliyeti.Location = new System.Drawing.Point(273, 175);
            this.txturetimMaliyeti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txturetimMaliyeti.Name = "txturetimMaliyeti";
            this.txturetimMaliyeti.ReadOnly = true;
            this.txturetimMaliyeti.Size = new System.Drawing.Size(100, 20);
            this.txturetimMaliyeti.TabIndex = 31;
            this.txturetimMaliyeti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "TOPLAM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtamortismanToplam
            // 
            this.txtamortismanToplam.Location = new System.Drawing.Point(273, 139);
            this.txtamortismanToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtamortismanToplam.Name = "txtamortismanToplam";
            this.txtamortismanToplam.ReadOnly = true;
            this.txtamortismanToplam.Size = new System.Drawing.Size(100, 20);
            this.txtamortismanToplam.TabIndex = 29;
            this.txtamortismanToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "TOPLAM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgenelUretimToplam
            // 
            this.txtgenelUretimToplam.Location = new System.Drawing.Point(273, 113);
            this.txtgenelUretimToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtgenelUretimToplam.Name = "txtgenelUretimToplam";
            this.txtgenelUretimToplam.ReadOnly = true;
            this.txtgenelUretimToplam.Size = new System.Drawing.Size(100, 20);
            this.txtgenelUretimToplam.TabIndex = 27;
            this.txtgenelUretimToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "TOPLAM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amortismanUcret
            // 
            this.amortismanUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.amortismanUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "Amortisman", true));
            this.amortismanUcret.Location = new System.Drawing.Point(165, 140);
            this.amortismanUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amortismanUcret.Name = "amortismanUcret";
            this.amortismanUcret.Size = new System.Drawing.Size(41, 20);
            this.amortismanUcret.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Amortisman ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genelUretimUcret
            // 
            this.genelUretimUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.genelUretimUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "GenelUretim", true));
            this.genelUretimUcret.Location = new System.Drawing.Point(165, 114);
            this.genelUretimUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.genelUretimUcret.Name = "genelUretimUcret";
            this.genelUretimUcret.Size = new System.Drawing.Size(41, 20);
            this.genelUretimUcret.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Genel Üretim";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direktIscilikUcret
            // 
            this.direktIscilikUcret.BackColor = System.Drawing.Color.PaleGreen;
            this.direktIscilikUcret.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iscilikGiderleriBindingSource, "DirektIscilik", true));
            this.direktIscilikUcret.Location = new System.Drawing.Point(165, 88);
            this.direktIscilikUcret.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.direktIscilikUcret.Name = "direktIscilikUcret";
            this.direktIscilikUcret.Size = new System.Drawing.Size(41, 20);
            this.direktIscilikUcret.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ÜCRET";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direkt İşçilik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdirektIscilikToplam
            // 
            this.txtdirektIscilikToplam.Location = new System.Drawing.Point(273, 87);
            this.txtdirektIscilikToplam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdirektIscilikToplam.Name = "txtdirektIscilikToplam";
            this.txtdirektIscilikToplam.ReadOnly = true;
            this.txtdirektIscilikToplam.Size = new System.Drawing.Size(100, 20);
            this.txtdirektIscilikToplam.TabIndex = 4;
            this.txtdirektIscilikToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MALZEME MALIYETI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kromelDBDataSet
            // 
            this.kromelDBDataSet.DataSetName = "KromelDBDataSet";
            this.kromelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iscilikGiderleriBindingSource
            // 
            this.iscilikGiderleriBindingSource.DataMember = "IscilikGiderleri";
            this.iscilikGiderleriBindingSource.DataSource = this.kromelDBDataSet;
            // 
            // iscilikGiderleriTableAdapter
            // 
            this.iscilikGiderleriTableAdapter.ClearBeforeFill = true;
            // 
            // MaliyetDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 481);
            this.Controls.Add(this.textBoxMamulAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MaliyetDetayForm";
            this.Text = "MaliyetDetayForm";
            this.Load += new System.EventHandler(this.MaliyetDetayForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kromelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscilikGiderleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIscilikUcret;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textIscilikSaat;
        private System.Windows.Forms.TextBox textmalzemeMaliyeti;
        private System.Windows.Forms.TextBox txtgenelToplam;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtdamgaVergisi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtsatisMaliyeti;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtgirmeyenAmortismanToplam;
        private System.Windows.Forms.TextBox girmeyenAmortismanUcret;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtgenelYonetimToplam;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt4satisPazarlamaToplam;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxMamulAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtargeToplam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox genelYonetimUcret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox satisPazarlamaUcret;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox argeUcret;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txturetimMaliyeti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtamortismanToplam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgenelUretimToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amortismanUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox genelUretimUcret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox direktIscilikUcret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdirektIscilikToplam;
        private System.Windows.Forms.Label label2;
        private KromelDBDataSet kromelDBDataSet;
        private System.Windows.Forms.BindingSource iscilikGiderleriBindingSource;
        private KromelDBDataSetTableAdapters.IscilikGiderleriTableAdapter iscilikGiderleriTableAdapter;
    }
}