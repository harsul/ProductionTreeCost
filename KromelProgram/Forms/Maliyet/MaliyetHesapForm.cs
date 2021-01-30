using KromelProgram.Forms.Malzeme;
using KromelProgram.Forms.Mamul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromelProgram.Forms.Maliyet
{
    public partial class MaliyetHesapForm : Form
    {
        private AlertForm alert;
        IDataObject dataInClipboard;


        public MaliyetHesapForm()
        {
            InitializeComponent();
        }

        private void MaliyetHesapForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.temporaryMaliyetHesap' table. You can move, or remove it, as needed.
            

            this.dataGridView1.Columns["birimFiyatDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["iscilikMaliyetDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["MalzemeMaliyetDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void SetMamul(string id)
        {
            textBoxMamulKodu.Text = id;
            textBoxMamulAdi.Text = mamulTableAdapter.GetData().FindByMamulID(id).MamulAdi;

            this.temporaryMaliyetHesapTableAdapter.FillByMamulID(this.databaseDataSet.temporaryMaliyetHesap, id);

            //button disable
            if (mamulTableAdapter.GetData().FindByMamulID(id).IsResimNull())
            {
                buttonResim.Enabled = false;
            }

            if (mamulTableAdapter.GetData().FindByMamulID(id).IsCizimNull())
            {
                buttonCizim.Enabled = false;
            }

            if (mamulTableAdapter.GetData().FindByMamulID(id).IsTeknikSartnameNull())
            {
                buttonSartname.Enabled = false;
            }

            ToplamHesapla();
        }

        public void setMalzeme(string id)
        {
            try
            {
                textBoxMalzemeKodu.Text = id;
                textBoxMalzemeAdi.Text = malzemeTableAdapter.GetData().FindByMalzemeID(id).MalzemeAdi;
                textBoxMalzeme.Text = malzemeTableAdapter.GetData().FindByMalzemeID(id).MalzemeGrubu;
                textBoxOlcu1.Text = !malzemeTableAdapter.GetData().FindByMalzemeID(id).IsOlcu1Null() ? malzemeTableAdapter.GetData().FindByMalzemeID(id).Olcu1 : null;
                textBoxOlcu2.Text = !malzemeTableAdapter.GetData().FindByMalzemeID(id).IsOlcu2Null() ? malzemeTableAdapter.GetData().FindByMalzemeID(id).Olcu2 : null;
                textBoxKalinlik.Text = !malzemeTableAdapter.GetData().FindByMalzemeID(id).IsKalinlikNull() ? malzemeTableAdapter.GetData().FindByMalzemeID(id).Kalinlik.ToString() : null;
                textBoxBoy.Text = !malzemeTableAdapter.GetData().FindByMalzemeID(id).IsBoyNull() ? malzemeTableAdapter.GetData().FindByMalzemeID(id).Boy.ToString() : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        #region DataControl
        private decimal? DecimalControl(string veri)
        {
            if (veri != "")
            {
                return Convert.ToDecimal(veri);
            }
            else return null;
        }
        private string StringControl(string veri)
        {
            if (veri != "")
            {
                return veri;
            }
            else return null;
        }

        public bool isDecimal(string value)
        {
            try
            {
                Decimal.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Calculations
        public void IscilikMaliyetiHesapla()
        {
            try
            {
                decimal total = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Sum(t => Convert.ToDecimal(t.Cells["iscilikMaliyetDataGridViewTextBoxColumn"].Value));

                textBoxIscilikMaliyetToplam.Text = total.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void IscilikDakikaHesapla()
        {
            try
            {
                decimal total = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Sum(t => Convert.ToDecimal(t.Cells["iscilikDakikaDataGridViewTextBoxColumn"].Value));

                textBoxIscilikSaat.Text = (total / 60).ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MalzemeMaliyetiHesapla()
        {
            try
            {
                decimal total = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells["malzemeMaliyetDataGridViewTextBoxColumn"].Value));

                textBoxMalzemeMaliyetToplam.Text = total.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToplamMaliyetHesapla()
        {
            decimal iscilik = Convert.ToDecimal(textBoxIscilikMaliyetToplam.Text);
            decimal malzeme = Convert.ToDecimal(textBoxMalzemeMaliyetToplam.Text);

            decimal toplam = iscilik + malzeme;

            textBoxMaliyetToplam.Text = toplam.ToString("#,##0.00");
        }

        private decimal? NormHesaplama(decimal? olcu1, decimal? olcu2, decimal? kalinlik, decimal? boy, int toplamAdet)
        {
            if (boy != null)
            {
                return boy * toplamAdet / 1000;
            }
            else if (olcu1 != null && olcu2 != null && kalinlik != null)
            {
                return (olcu1 * olcu2 * kalinlik * 8) / 1000000 * toplamAdet;
            }
            else return toplamAdet;
        }
        private void MalzemeUcretHesapla()
        {
            try
            {
                if (textBoxNorm.Text != "" && textBoxBirimFiyat.Text != "")
                {
                    decimal norm = Convert.ToDecimal(textBoxNorm.Text);
                    decimal birimFiyat = Convert.ToDecimal(textBoxBirimFiyat.Text);

                    decimal malzemeUcreti = Math.Round(norm * birimFiyat, 2);

                    textBoxMalzeme.Text = malzemeUcreti.ToString();

                    ToplamHesapla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ToplamHesapla()
        {
            IscilikDakikaHesapla();
            IscilikMaliyetiHesapla();
            MalzemeMaliyetiHesapla();
            ToplamMaliyetHesapla();
        }
        #endregion

        #region Buttons
        private void excelToolStripButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy != true)
            {
                // create a new instance of the alert form
                alert = new AlertForm();
                alert.Show();
                // Start the asynchronous operation.

                dataInClipboard = Clipboard.GetDataObject();

                backgroundWorker.RunWorkerAsync();
            }
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                temporaryMaliyetHesapBindingSource.EndEdit();
                temporaryMaliyetHesapTableAdapter.Update(databaseDataSet.temporaryMaliyetHesap);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveToolStripButton_Click(sender, e);
                
                this.temporaryMaliyetHesapTableAdapter.FillByFilter(this.databaseDataSet.temporaryMaliyetHesap, parameterToolStripTextBox.Text,textBoxMamulKodu.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                ToplamHesapla();
            }

        }

        private void buttonResim_Click(object sender, EventArgs e)
        {
            if (!mamulTableAdapter.GetData().FindByMamulID(textBoxMamulKodu.Text).IsResimNull())
            {

                ResimGosterForm resimGosterForm = new ResimGosterForm(textBoxMamulKodu.Text);

                resimGosterForm.Show();
            }
            else
            {
                MessageBox.Show("Resim yüklenmedi!", "Mesaj", MessageBoxButtons.OK);
            }
        }

        private void buttonCizim_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mamulTableAdapter.GetData().FindByMamulID(textBoxMamulKodu.Text).IsCizimNull())
                {
                    string file = mamulTableAdapter.GetData().FindByMamulID(textBoxMamulKodu.Text).Cizim;
                    Process.Start(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSartname_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mamulTableAdapter.GetData().FindByMamulID(textBoxMamulKodu.Text).IsTeknikSartnameNull())
                {
                    string file = mamulTableAdapter.GetData().FindByMamulID(textBoxMamulKodu.Text).TeknikSartname;
                    Process.Start(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region TextChanged

        private void textBoxIscilikDakika_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIscilikDakika.Text != "")
            {
                decimal dakika = Convert.ToDecimal(textBoxIscilikDakika.Text);
                decimal ucret = Convert.ToDecimal(textBoxIscilikUcret.Text);

                decimal toplam = Math.Round(dakika / 60 * ucret, 2);

                textBoxIscilikMaliyet.Text = toplam.ToString();
            }
        }

        private void textBoxIscilikMaliyet_TextChanged(object sender, EventArgs e)
        {
            ToplamHesapla();
        }

        private void textBoxBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBirimFiyat.Text != "")
            {
                
                decimal norm = Convert.ToDecimal(textBoxNorm.Text);
                decimal birimFiyat = Convert.ToDecimal(textBoxBirimFiyat.Text);

                decimal toplam = Math.Round(norm * birimFiyat, 2);

                textBoxMalzemeMaliyet.Text = toplam.ToString("#,##0.00");
            }
        }

        private void textBoxNorm_TextChanged(object sender, EventArgs e)
        {
            MalzemeUcretHesapla();
        }

        private void textBoxMalzemeMaliyet_TextChanged(object sender, EventArgs e)
        {
            MalzemeUcretHesapla();
        }



        #endregion

        private void buttonNormHesapla_Click(object sender, EventArgs e)
        {
            decimal? olcu1, olcu2, kalinlik, boy;
            int toplamAdet;
            decimal? norm;


            if (isDecimal(textBoxOlcu1.Text))
            {
                olcu1 = DecimalControl(textBoxOlcu1.Text);
            }
            else olcu1 = null;

            if (isDecimal(textBoxOlcu1.Text))
            {
                olcu2 = DecimalControl(textBoxOlcu1.Text);
            }
            else olcu2 = null;

            kalinlik = DecimalControl(textBoxKalinlik.Text);
            boy = DecimalControl(textBoxBoy.Text);
            toplamAdet = Convert.ToInt32(numericUpDownAdet.Value);

            norm = NormHesaplama(olcu1, olcu2, kalinlik, boy, toplamAdet);

            textBoxNorm.Text = norm.ToString();

        }

        private void buttonMalzemeSec_Click(object sender, EventArgs e)
        {
            MalzemeSecForm malzemeSecForm = new MalzemeSecForm(this);

            malzemeSecForm.Show();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            try
            {
                char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
                char columnSplitter = '\t';         // Tab.

                decimal? olcu1, olcu2, kalinlik, boy;
                int toplamAdet;
                decimal? norm;

                //IDataObject dataInClipboard = Clipboard.GetDataObject();

                string stringInClipboard =
                    dataInClipboard.GetData(DataFormats.Text).ToString();

                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter,
                    StringSplitOptions.RemoveEmptyEntries);

                int boyut = rowsInClipboard.Length;

                int iRow = 0;
                while (iRow < rowsInClipboard.Length)
                {
                    // Split up rows to get individual cells:

                    string[] valuesInRow =
                        rowsInClipboard[iRow].Split(columnSplitter);

                    // Cycle through cells.
                    // Assign cell value only if within columns of grid:

                    //check the decimal values for calclation of norm
                    if (isDecimal(valuesInRow[5].ToString()))
                    {
                        olcu1 = DecimalControl(valuesInRow[5].ToString());
                    }
                    else olcu1 = null;

                    if (isDecimal(valuesInRow[6].ToString()))
                    {
                        olcu2 = DecimalControl(valuesInRow[6].ToString());
                    }
                    else olcu2 = null;

                    kalinlik = DecimalControl(valuesInRow[7]);
                    boy = DecimalControl(valuesInRow[8]);
                    toplamAdet = Convert.ToInt32(valuesInRow[10]);

                    norm = NormHesaplama(olcu1, olcu2, kalinlik, boy, toplamAdet);

                    temporaryMaliyetHesapTableAdapter.Insert(textBoxMamulKodu.Text,
                        valuesInRow[0],
                        StringControl(valuesInRow[1]),
                        StringControl(valuesInRow[2]),
                        StringControl(valuesInRow[3]),
                        StringControl(valuesInRow[4]),
                        StringControl(valuesInRow[5]),
                        StringControl(valuesInRow[6]),
                        DecimalControl(valuesInRow[7]),
                        DecimalControl(valuesInRow[8]),
                        Convert.ToInt32(valuesInRow[9]),
                        Convert.ToInt32(valuesInRow[10]),
                        Convert.ToDecimal(norm),
                        Convert.ToDecimal("0"),
                        Convert.ToInt32("0"),
                        Convert.ToDecimal("0"),
                        Convert.ToDecimal("0"));

                    iRow += 1;

                    double progres = (Convert.ToDouble(iRow) / boyut) * 100;
                    worker.ReportProgress(Convert.ToInt32(progres));
                    System.Threading.Thread.Sleep(5);
                } // end while

                ToplamHesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            alert.Message = "Hesaplama yapılıyor, lütfen bekleyiniz... " + e.ProgressPercentage.ToString() + "%";
            alert.ProgressValue = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.temporaryMaliyetHesapTableAdapter.FillByMamulID(this.databaseDataSet.temporaryMaliyetHesap, textBoxMamulKodu.Text);

            alert.Close();
        }

        private void numericUpDownAdet_ValueChanged(object sender, EventArgs e)
        {
            textBoxToplamAdet.Text = numericUpDownAdet.Value.ToString();

        }

        private void fillByGrubToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                saveToolStripButton_Click(sender, e);

                this.temporaryMaliyetHesapTableAdapter.FillByGrub(this.databaseDataSet.temporaryMaliyetHesap, parameterToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveToolStripButton_Click(sender, e);

                this.temporaryMaliyetHesapTableAdapter.Fill(this.databaseDataSet.temporaryMaliyetHesap);

                ToplamHesapla();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
