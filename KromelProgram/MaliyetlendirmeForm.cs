using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KromelProgram
{
    public partial class MaliyetlendirmeForm : Form
    {
        public MaliyetlendirmeForm()
        {
            InitializeComponent();
        }


        private void MaliyetlendirmeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kromelDBDataSet.Mamul' table. You can move, or remove it, as needed.
            //this.mamulTableAdapter.Fill(this.kromelDBDataSet.Mamul);

            // TODO: This line of code loads data into the 'kromelDBDataSet.Malzeme' table. You can move, or remove it, as needed.
            //this.malzemeTableAdapter.Fill(this.kromelDBDataSet.Malzeme);

            // TODO: This line of code loads data into the 'kromelDBDataSet.TemporaryUrunAgac' table. You can move, or remove it, as needed.
            //this.temporaryUrunAgacTableAdapter.Fill(this.kromelDBDataSet.TemporaryUrunAgac);

            this.dataGridView1.Columns["birimFiyatiDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["tutariDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void ButtonMamulSec_Click(object sender, EventArgs e)
        {
            MamulSecForm form = new MamulSecForm(this);

            form.Show();
        }

        private void ButtonMalzemeSec_Click(object sender, EventArgs e)
        {
            MalzemeSecForm form = new MalzemeSecForm(this);

            form.Show();
        }

        /// <summary>
        /// Setting the data for the product that is coming from another form 
        /// </summary>
        /// <param name="mamulid"></param>
        /// <param name="mamuladi"></param>
        public void SetMamul(string mamulid,string mamuladi)
        {
            textBoxMamulID.Text = mamulid;
            textBoxMamulAdi.Text = mamuladi;

        }

        /// <summary>
        /// Setting the data for the piece that is coming from another form 
        /// </summary>
        /// <param name="malzemeid"></param>
        /// <param name="malzemeadi"></param>
        /// <param name="birimfiyat"></param>
        public void SetMalzeme(string malzemeid, string malzemeadi,string birimfiyat)
        {
            textBoxMalzemeID.Text = malzemeid;
            textBoxMalzemeAdi.Text = malzemeadi;
            textBoxBirimFiyati.Text = birimfiyat;

            TutariHesapla();

            try
            {
                //Ekleme
                temporaryUrunAgacTableAdapter.Insert(
                    textBoxMamulID.Text, null, null, textBoxMalzemeID.Text, textBoxMalzemeAdi.Text,
                    null, null, null,null, null,numericUpDownMiktar.Value, null,null, null,
                    Convert.ToDecimal(textBoxBirimFiyati.Text),Convert.ToDecimal(textBoxTutari.Text));

                this.temporaryUrunAgacTableAdapter.Fill(this.kromelDBDataSet.TemporaryUrunAgac);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        /// <summary>
        /// Calculating the weight of the piece
        /// </summary>
        private void AgirlikHesapla()
        {
            try
            {
                double agirlik = 0;
                //converting data from textboxes
                double ebat1 = Convert.ToDouble(textBoxOlcu1.Text);
                double ebat2 = Convert.ToDouble(textBoxOlcu2.Text);
                int miktar = Convert.ToInt32(numericUpDownMiktar.Value.ToString());

                //control if thickness is not null
                if (textBoxKalinlik.Text != "")
                {
                    double kalinlik = Convert.ToDouble(textBoxKalinlik.Text);
                    //calculating weight
                    agirlik = ebat1 * ebat2 * kalinlik * 8 / 1000000 * miktar;
                }
                //calculating the price of rounded pieces
                else if (textBoxBoy.Text == "" && textBoxKalinlik.Text == "")
                {
                    agirlik = ebat1 * ebat1 * ebat2 * Math.PI / 4 * 8 / 1000000 * miktar;

                }
                //round weigth value to 2 decimals
                textBoxAgirlik.Text = Math.Round(agirlik, 2).ToString();

                TutariHesapla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
                
            }
        }

        /// <summary>
        /// Calculating the total price of material by weight or quantity
        /// </summary>
        private void TutariHesapla()
        {
            try
            {
                double tutari = 0.0;
                //converting values to textbox
                //string[] textfiyat = textBoxBirimFiyati.Text.Split('€');
                double birimfiyat = Convert.ToDouble(textBoxBirimFiyati.Text);
                int miktar = Convert.ToInt32(numericUpDownMiktar.Value.ToString());

                //checking if the weight value is null
                //if weight is not null total price will be calculated by weight and piece price
                if (textBoxAgirlik.Text == "" && textBoxBoy.Text == "")
                {
                    tutari = miktar * birimfiyat;
                }
                else if (textBoxAgirlik.Text != "")
                {
                    double agirlik = Convert.ToDouble(textBoxAgirlik.Text);

                    tutari = agirlik * birimfiyat;
                }
                else if (textBoxBoy.Text != "")
                {
                    //calculate price by size  
                    double boy = Convert.ToDouble(textBoxBoy.Text);

                    tutari = boy * miktar * birimfiyat / 1000;
                }

                tutari = Math.Round(tutari, 2);
                //set textbox value
                textBoxTutari.Text = tutari.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
            }
        }

        /// <summary>
        /// //calculate the total price value using all rows in datagrid view
        /// </summary>
        private void ToplamTutarHesapla()
        {
            try
            {
                double toplamMaliyet = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    double tutar = Convert.ToDouble(dataGridView1.Rows[i].Cells["tutariDataGridViewTextBoxColumn"].Value.ToString());

                    toplamMaliyet += tutar;
                }

                //set total price textbox value
                textBoxMalzemeMaliyeti.Text = toplamMaliyet.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        /// <summary>
        /// Calculate the total woring hours and prices
        /// </summary>
        private void IscilikHesapla()
        {
            try
            {
                double iscilik = Convert.ToDouble(textBoxIscilik.Text);
                double ucret = Convert.ToDouble(textBoxIscilikUcret.Text);

                double toplamiscilik = iscilik * ucret;

                textBoxIscilikMaliyeti.Text = toplamiscilik.ToString("#,##0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// Calculating the total price of the product with taxes
        /// </summary>
        private void GenelTutarHesapla()
        {
            try
            {
                if (textBoxMalzemeMaliyeti.Text != "" && textBoxIscilikMaliyeti.Text != "")
                {
                    double malzememaliyet = Convert.ToDouble(textBoxMalzemeMaliyeti.Text);
                    double iscilikmaliyet = Convert.ToDouble(textBoxIscilikMaliyeti.Text);
                    double toplammaliyet = malzememaliyet + iscilikmaliyet;

                    double damgavergisi =Math.Round((toplammaliyet + toplammaliyet * 0.25) * 0.01,2);

                    double genelmaliyet =Math.Round(toplammaliyet + damgavergisi,2);

                    textBoxToplamMaliyeti.Text = toplammaliyet.ToString("#,##0.00");
                    textBoxDamgaVergisi.Text = damgavergisi.ToString("#,##0.00");
                    textBoxGenelToplam.Text = genelmaliyet.ToString("#,##0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonAgirlikHesapla_Click(object sender, EventArgs e)
        {
            AgirlikHesapla();
        }

        private decimal DecimalControl(string veri)
        {
            if (veri != "")
            {
                return Convert.ToDecimal(veri);
            }
            else
                return Convert.ToDecimal(null);
        }

        private void ToolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxMamulID.Text!="")
            {
                DialogResult dialog = MessageBox.Show("Maliyet Hesabı Kaydedilsin Mi?", "Kaydetme", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        KromelDBDataSetTableAdapters.UrunAgaciTableAdapter urunAgaciTableAdapter = new KromelDBDataSetTableAdapters.UrunAgaciTableAdapter();

                        DataTable dataTable = temporaryUrunAgacTableAdapter.GetData();

                        foreach (DataRow item in dataTable.Rows)
                        {
                            urunAgaciTableAdapter.Insert(
                                item["MamulID"].ToString(),
                                item["Aciklama"].ToString(),
                                item["Grup"].ToString(),
                                item["MalzemeID"].ToString(),

                                DecimalControl(item["Olcu1"].ToString()),
                                DecimalControl(item["Olcu2"].ToString()),
                                DecimalControl(item["Kalinlik"].ToString()),
                                DecimalControl(item["Boy"].ToString()),
                                DecimalControl(item["Agirlik"].ToString()),

                                Convert.ToInt32(item["Miktar"].ToString()),
                                item["Birim"].ToString(),
                                Convert.ToInt32(item["Iscilik"].ToString()),
                                DecimalControl(item["IscilikTutari"].ToString()),
                                DecimalControl(item["BirimFiyati"].ToString()),
                                DecimalControl(item["Tutari"].ToString())
                                );
                        }

                        temporaryUrunAgacTableAdapter.DeleteQuery();

                        MessageBox.Show("Başarılı");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        KromelDBDataSetTableAdapters.MaliyetTableAdapter maliyetTableAdapter = new KromelDBDataSetTableAdapters.MaliyetTableAdapter();

                        maliyetTableAdapter.Insert(
                            textBoxMamulID.Text,
                            Convert.ToDecimal(textBoxMalzemeMaliyeti.Text),
                            Convert.ToInt16(textBoxIscilik.Text),
                            Convert.ToDecimal(textBoxIscilikUcret.Text),
                            Convert.ToDecimal(textBoxIscilikMaliyeti.Text),
                            Convert.ToDecimal(textBoxDamgaVergisi.Text),
                            Convert.ToDecimal(textBoxGenelToplam.Text)
                            );

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    this.temporaryUrunAgacTableAdapter.Fill(this.kromelDBDataSet.TemporaryUrunAgac);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Mamül Seçiniz!");
            }


        }

        private void ToolStripButtonGuncele_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.temporaryUrunAgacBindingSource.EndEdit();
                this.temporaryUrunAgacTableAdapter.Update(this.kromelDBDataSet.TemporaryUrunAgac);

                ToplamTutarHesapla();
                GenelTutarHesapla();

                MessageBox.Show("Update successful");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed"+ex.Message);
            }
        }

        private void TextBoxIscilik_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIscilik.Text != "")
            {
                IscilikHesapla();
                GenelTutarHesapla();
            }
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ToplamTutarHesapla();
            IscilikHesapla();
            GenelTutarHesapla();
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ToplamTutarHesapla();
            IscilikHesapla();
            GenelTutarHesapla();
        }

        private void FiltreleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.temporaryUrunAgacTableAdapter.Filtrele(this.kromelDBDataSet.TemporaryUrunAgac, parametreToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ToolStripButtonTemizle_Click(object sender, EventArgs e)
        {
            temporaryUrunAgacTableAdapter.Fill(kromelDBDataSet.TemporaryUrunAgac);
        }

        private void ButtonTutariHesapla_Click(object sender, EventArgs e)
        {
            TutariHesapla();
        }

        private void NumericUpDownMiktar_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxAgirlik.Text!="")
            {
                AgirlikHesapla();
            }
            else
            {
                TutariHesapla();
            }
        }

        private void NumericUpDownMiktar_ValueChanged(object sender, EventArgs e)
        {
            if (textBoxAgirlik.Text != "")
            {
                AgirlikHesapla();
            }
            else
            {
                TutariHesapla();
            }
        }

        private void TextBoxKalinlik_Leave(object sender, EventArgs e)
        {
            if (textBoxOlcu1.Text != "" && textBoxOlcu2.Text != "" && textBoxKalinlik.Text!="")
            {
                AgirlikHesapla();
            }
        }

        private void TextBoxBoy_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBoy.Text!="")
            {
                textBoxAgirlik.Text = "";

                TutariHesapla();
            }
        }

        private void TextBoxOlcu2_Leave(object sender, EventArgs e)
        {
            if (textBoxOlcu1.Text != "" && textBoxOlcu2.Text != "")
            {
                AgirlikHesapla();
            }
        }
    }
}
