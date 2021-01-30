using KromelProgram.Forms.Malzeme;
using KromelProgram.Forms.Mamul;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace KromelProgram.Forms.Maliyet
{
    public partial class MaliyetlendirmeForm : Form
    {
        private DataTable dataTable;
        AlertForm alert;

        public MaliyetlendirmeForm()
        {
            InitializeComponent();
        }

        private void MaliyetlendirmeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.temporaryMaliyetlendirme' table. You can move, or remove it, as needed.
            //this.temporaryMaliyetlendirmeTableAdapter.Fill(this.databaseDataSet.temporaryMaliyetlendirme);
            
            this.dataGridView1.Columns["birimFiyatDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["iscilikMaliyetDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["MalzemeMaliyetDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            FillDatagrid();
        }

        private void MaliyetlendirmeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporaryMaliyetlendirmeTableAdapter.DeleteQueryData();
        }

        private void FillDatagrid()
        {
            IscilikDakikaHesapla();
            IscilikMaliyetiHesapla();
            MalzemeMaliyetiHesapla();
            ToplamMaliyetHesapla();
        }

        public void SetMamul(string id)
        {
            textBoxMamulKodu.Text = id;
            textBoxMamulAdi.Text = mamulTableAdapter.GetData().FindByMamulID(id).MamulAdi;
          
            if (backgroundWorker.IsBusy != true)
            {
                // create a new instance of the alert form
                alert = new AlertForm();
                alert.Show();
                // Start the asynchronous operation.
                backgroundWorker.RunWorkerAsync();
            }
        }

        public void setMalzeme(string id)
        {
            textBoxMalzemeID.Text = id;
            textBoxMalzemeAdi.Text = malzemeTableAdapter.GetData().FindByMalzemeID(id).MalzemeAdi;
        }

        #region Calculations

        public decimal? MalzemeTutariHesapla(decimal? norm, decimal fiyat)
        {
            return norm * fiyat;
        }

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

                textBoxIscilikSaat.Text = (total/60).ToString("#,##0.00");

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

            textBoxToplamMaliyet.Text = toplam.ToString("#,##0.00");
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

        #endregion

        #region DataControl

        public int? IntegerControl(string veri)
        {
            if (veri != "")
            {
                return Convert.ToInt32(veri);
            }
            else return 0;
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

        private decimal? DecimalControl(string veri)
        {
            if (veri != "")
            {
                return Convert.ToDecimal(veri);
            }
            else return null;
        }

        public string StringControl(string veri)
        {
            return veri != "" ? veri : null;
        }
        #endregion


        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                temporaryMaliyetlendirmeTableAdapter.FillByFilter(this.databaseDataSet.temporaryMaliyetlendirme, parametreToolStripTextBox.Text);
                FillDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            try
            {
                dataTable = urunAgacTableAdapter.GetDataByID(textBoxMamulKodu.Text);

                double boyut = dataTable.Rows.Count;

                double i = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    decimal birimfiyat = !malzemeTableAdapter.GetData().FindByMalzemeID(item["MalzemeID"].ToString()).IsFiyatNull() ?
                        malzemeTableAdapter.GetData().FindByMalzemeID(item["MalzemeID"].ToString()).Fiyat : 0;
                    string malzemeGrubu= !malzemeTableAdapter.GetData().FindByMalzemeID(item["MalzemeID"].ToString()).IsMalzemeGrubuNull() ?
                        malzemeTableAdapter.GetData().FindByMalzemeID(item["MalzemeID"].ToString()).MalzemeGrubu : null;

                    decimal? olcu1,olcu2;
                    decimal iscilik= Convert.ToDecimal(IntegerControl(item["IscilikDakika"].ToString())/60*19);

                    if (isDecimal(item["Olcu1"].ToString()))
                    {
                        olcu1 = DecimalControl(item["Olcu1"].ToString());
                    }
                    else olcu1 = null; 

                    if (isDecimal(item["Olcu2"].ToString()))
                    {
                        olcu2 = DecimalControl(item["Olcu2"].ToString());
                    }
                    else olcu2 = null;

                    decimal? norm = NormHesaplama(
                        olcu1,
                        olcu2,
                        DecimalControl(item["Kalinlik"].ToString()),
                        DecimalControl(item["Boy"].ToString()),
                        Convert.ToInt32(item["ToplamAdet"].ToString()));

                    decimal? tutar = MalzemeTutariHesapla(norm, birimfiyat);

                    temporaryMaliyetlendirmeTableAdapter.Insert(
                        textBoxMalzemeID.Text,
                        StringControl(item["MontajGrubu"].ToString()),
                        StringControl(item["Aciklama"].ToString()),
                        item["MalzemeID"].ToString(),
                        item["MalzemeAdi"].ToString(),
                        StringControl(malzemeGrubu),
                        StringControl(item["Olcu1"].ToString()),
                        StringControl(item["Olcu2"].ToString()),
                        DecimalControl(item["Kalinlik"].ToString()),
                        DecimalControl(item["Boy"].ToString()),
                        Convert.ToInt32(item["Adet"].ToString()),
                        Convert.ToInt32(item["ToplamAdet"].ToString()),
                        norm,
                        birimfiyat,
                        IntegerControl(item["IscilikDakika"].ToString()),
                        iscilik,
                        tutar
                        );

                    double progres = (i++ / boyut) * 100;
                    worker.ReportProgress(Convert.ToInt32(progres));
                    System.Threading.Thread.Sleep(5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            alert.Message = "Hesaplama yapılıyor, lütfen bekleyiniz... " + e.ProgressPercentage.ToString() + "%";
            alert.ProgressValue = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.temporaryMaliyetlendirmeTableAdapter.Fill(this.databaseDataSet.temporaryMaliyetlendirme);

            alert.Close();

            this.Show();
        }

        private void buttonMalzemeSec_Click(object sender, EventArgs e)
        {
            MalzemeSecForm malzemeSecForm = new MalzemeSecForm(this);

            malzemeSecForm.Show();
        }

        private void MalzemeUcretHesapla()
        {
            try
            {
                if (textBoxNorm.Text != "" && textBoxBirimFiyati.Text != "")
                {
                    decimal norm = Convert.ToDecimal(textBoxNorm.Text);
                    decimal birimFiyat = Convert.ToDecimal(textBoxBirimFiyati.Text);

                    decimal malzemeUcreti = Math.Round(norm * birimFiyat, 2);

                    textBoxMalzemeUcreti.Text = malzemeUcreti.ToString();

                    FillDatagrid();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelMesaj.Text = ex.Message;
            }
            
        }
        private void textBoxNorm_TextChanged(object sender, EventArgs e)
        {
            MalzemeUcretHesapla();
        }

        private void textBoxBirimFiyati_TextChanged(object sender, EventArgs e)
        {
            MalzemeUcretHesapla();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            FillDatagrid();
        }

        private void fillByMontajGrubuToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.temporaryMaliyetlendirmeTableAdapter.FillByMontajGrubu(this.databaseDataSet.temporaryMaliyetlendirme, parameterToolStripTextBox.Text);

                FillDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate();
                //temporaryMaliyetlendirmeBindingSource.EndEdit();
                //temporaryMaliyetlendirmeTableAdapter.Update(databaseDataSet.temporaryMaliyetlendirme);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void textBoxIscilikDakika_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIscilikDakika.Text!="")
            {
                decimal dakika = Convert.ToDecimal(textBoxIscilikDakika.Text);
                decimal ucret= Convert.ToDecimal(textBoxIscilikUcreti.Text);

                decimal toplam = Math.Round(dakika / 60 * ucret,2);

                textBoxIscilikMaliyet.Text = toplam.ToString();
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
                MessageBox.Show("Resim yüklenmedi!","Mesaj", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            GrafikForm grafikForm = new GrafikForm();

            grafikForm.Show();
        }

        private void toolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                this.temporaryMaliyetlendirmeTableAdapter.Fill(this.databaseDataSet.temporaryMaliyetlendirme);

                FillDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
