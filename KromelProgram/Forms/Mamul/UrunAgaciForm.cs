using KromelProgram.Forms.Malzeme;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KromelProgram.Forms.Mamul
{
    public partial class UrunAgaciForm : Form
    {
        public UrunAgaciForm()
        {
            InitializeComponent();
        }

        private void UrunAgaciForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.UrunAgac' table. You can move, or remove it, as needed.
            //this.urunAgacTableAdapter.Fill(this.databaseDataSet.UrunAgac);
        }

        public void setMalzeme(string id)
        {
            textBoxMalzemeKodu.Text = id;
            textBoxMalzemeAdi.Text = malzemeTableAdapter.GetData().FindByMalzemeID(id).MalzemeAdi;
            textBoxMalzeme.Text = !malzemeTableAdapter.GetData().FindByMalzemeID(id).IsMalzemeGrubuNull() ?
                malzemeTableAdapter.GetData().FindByMalzemeID(id).MalzemeGrubu : null;
        }

        public void setMamul(string id)
        {
            textBoxMamulKodu.Text = id;
            textBoxMamulAdi.Text = mamulTableAdapter.GetData().FindByMamulID(id).MamulAdi;
            //textBoxKapasite.Text= mamulTableAdapter.GetData().FindByMamulID(id).Kapasite;
            //textBoxTip.Text= mamulTableAdapter.GetData().FindByMamulID(id).Tip;

            try
            {
                this.urunAgacTableAdapter.FillByID(this.databaseDataSet.UrunAgac, id);
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
                this.urunAgacTableAdapter.FillByFilter(this.databaseDataSet.UrunAgac, parameterToolStripTextBox.Text,textBoxMamulKodu.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
        private string StringControl(string veri)
        {
            if (veri != "")
            {
                return veri;
            }
            else return null;
        }

        private void excelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
                char columnSplitter = '\t';         // Tab.

                IDataObject dataInClipboard = Clipboard.GetDataObject();

                string stringInClipboard =
                    dataInClipboard.GetData(DataFormats.Text).ToString();

                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter,
                    StringSplitOptions.RemoveEmptyEntries);

                int iRow = 0;
                while (iRow < rowsInClipboard.Length)
                {
                    // Split up rows to get individual cells:

                    string[] valuesInRow =
                        rowsInClipboard[iRow].Split(columnSplitter);

                    // Cycle through cells.
                    // Assign cell value only if within columns of grid:

                    urunAgacTableAdapter.Insert(textBoxMamulKodu.Text, valuesInRow[0],
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
                        Convert.ToInt32("0"));

                    iRow += 1;
                } // end while


                try
                {
                    this.urunAgacTableAdapter.FillByID(this.databaseDataSet.UrunAgac, textBoxMamulKodu.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
                Validate();
                urunAgacBindingSource.EndEdit();
                urunAgacTableAdapter.Update(this.databaseDataSet.UrunAgac);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                parameterToolStripTextBox.Text = null;
                this.urunAgacTableAdapter.FillByID(this.databaseDataSet.UrunAgac, textBoxMamulKodu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMalzemeSec_Click(object sender, EventArgs e)
        {
            MalzemeSecForm malzemeSecForm = new MalzemeSecForm(this);

            malzemeSecForm.Show();
        }


        private void buttonResim_Click_1(object sender, EventArgs e)
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

    }
}
