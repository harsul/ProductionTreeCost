using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromelProgram
{
    public partial class MaliyetDetayForm : Form
    {
        public MaliyetDetayForm()
        {
            InitializeComponent();
        }

        public MaliyetDetayForm(string mamuladi, string iscilik, string malzememaliyet)
        {
            InitializeComponent();

            textBoxMamulAdi.Text = mamuladi;
            textIscilikSaat.Text = iscilik;
            textmalzemeMaliyeti.Text = malzememaliyet;
        }

        private void Hesapla()
        {
            try
            {
                double iscilik = Convert.ToDouble(textIscilikSaat.Text);
                double malzemeMaliyeti = Convert.ToDouble(textmalzemeMaliyeti.Text);

                //Converting textbox values 
                double direktIscilik = Math.Round(iscilik * Convert.ToDouble(direktIscilikUcret.Text), 2);
                double genelUretim = Math.Round(iscilik * Convert.ToDouble(genelUretimUcret.Text), 2);
                double amortisman = Math.Round(iscilik * Convert.ToDouble(amortismanUcret.Text), 2);
                double arge = Math.Round(iscilik * Convert.ToDouble(argeUcret.Text), 2);
                double satisPazarlama = Math.Round(iscilik * Convert.ToDouble(satisPazarlamaUcret.Text), 2);
                double genelYonetim = Math.Round(iscilik * Convert.ToDouble(genelYonetimUcret.Text), 2);
                double girmeyenAmortisman = Math.Round(iscilik * Convert.ToDouble(girmeyenAmortismanUcret.Text), 2);

                //calculating the cost 
                double uretimMayliyeti = Math.Round(malzemeMaliyeti + direktIscilik + genelUretim + amortisman, 2);
                double satisMaliyeti = Math.Round(uretimMayliyeti + arge + satisPazarlama + genelYonetim + girmeyenAmortisman, 2);

                double damgaVergisi = Math.Round((satisMaliyeti + satisMaliyeti * 0.25) * 0.01, 2);

                double genelToplam = Math.Round(satisMaliyeti + damgaVergisi, 2);

                //setting total price
                txtdirektIscilikToplam.Text = (direktIscilik).ToString();
                txtgenelUretimToplam.Text = (genelUretim).ToString();
                txtamortismanToplam.Text = (amortisman).ToString();
                txtargeToplam.Text = (amortisman).ToString();
                txt4satisPazarlamaToplam.Text = (satisPazarlama).ToString();
                txtgenelYonetimToplam.Text = (genelYonetim).ToString();
                txtgirmeyenAmortismanToplam.Text = (girmeyenAmortisman).ToString();

                txturetimMaliyeti.Text = uretimMayliyeti.ToString();
                txtsatisMaliyeti.Text = satisMaliyeti.ToString();
                txtdamgaVergisi.Text = damgaVergisi.ToString();

                txtgenelToplam.Text = genelToplam.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void MaliyetDetayForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kromelDBDataSet.IscilikGiderleri' table. You can move, or remove it, as needed.
            this.iscilikGiderleriTableAdapter.Fill(this.kromelDBDataSet.IscilikGiderleri);

            double direktIscilik = Convert.ToDouble(direktIscilikUcret.Text);
            double genelUretim = Convert.ToDouble(genelUretimUcret.Text);
            double amortisman = Convert.ToDouble(amortismanUcret.Text);
            double arge = Convert.ToDouble(argeUcret.Text);
            double satisPazarlama = Convert.ToDouble(satisPazarlamaUcret.Text);
            double genelYonetim = Convert.ToDouble(genelYonetimUcret.Text);
            double girmeyenAmortisman = Convert.ToDouble(girmeyenAmortismanUcret.Text);

            double toplamucret =
                Math.Round(direktIscilik +
                genelUretim +
                amortisman +
                arge +
                satisPazarlama +
                genelYonetim +
                girmeyenAmortisman, 2);

            textBoxIscilikUcret.Text = toplamucret.ToString();

            Hesapla();
        }
    }
}
