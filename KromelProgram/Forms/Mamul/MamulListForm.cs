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

namespace KromelProgram.Forms.Mamul
{
    public partial class MamulListForm : Form
    {
        public MamulListForm()
        {
            InitializeComponent();
        }

        private void MamulListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Mamul' table. You can move, or remove it, as needed.
            //this.mamulTableAdapter.Fill(this.databaseDataSet.Mamul);
        }

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mamulTableAdapter.FillByFilter(this.databaseDataSet.Mamul, parametreToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                FilterIndex = 2,
                RestoreDirectory = true,
                CheckFileExists = false,
                Title = "Makina Resim Seçiniz",
                Multiselect = false
            };

            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = file.FileName;
                    string DosyaAdi = file.SafeFileName;

                    textBoxResimYolu.Text = DosyaYolu;

                    pictureBoxResim.Image = Image.FromFile(DosyaYolu);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
            }
            finally
            {
                file.Dispose();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                mamulBindingSource.EndEdit();
                mamulTableAdapter.Update(this.databaseDataSet.Mamul);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["mamulIDDataGridViewTextBoxColumn"].Value.ToString();

                if (e.ColumnIndex == 0)
                {

                    UrunAgaciForm urunAgaciForm = new UrunAgaciForm();

                    urunAgaciForm.setMamul(id);

                    urunAgaciForm.Show();
                }
                else if (e.ColumnIndex == 5)
                {
                    if (!mamulTableAdapter.GetData().FindByMamulID(id).IsResimNull())
                    {

                        ResimGosterForm resimGosterForm = new ResimGosterForm(id);

                        resimGosterForm.Show();
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    
                    if (!mamulTableAdapter.GetData().FindByMamulID(id).IsCizimNull())
                    {
                        string file = mamulTableAdapter.GetData().FindByMamulID(id).Cizim;
                        Process.Start(file);
                    }
                    
                }
                else if (e.ColumnIndex == 7)
                {
                    if (!mamulTableAdapter.GetData().FindByMamulID(id).IsTeknikSartnameNull())
                    {
                        string file = mamulTableAdapter.GetData().FindByMamulID(id).TeknikSartname;
                        Process.Start(file);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonCizim_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                FilterIndex = 2,
                RestoreDirectory = true,
                CheckFileExists = false,
                Title = "Makina Çizim Seçiniz",
                Multiselect = false
            };

            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = file.FileName;

                    textBoxCizim.Text = DosyaYolu;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
            }
            finally
            {
                file.Dispose();
            }
        }

        private void buttonSartname_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                FilterIndex = 2,
                RestoreDirectory = true,
                CheckFileExists = false,
                Title = "Makina Çizim Seçiniz",
                Multiselect = false
            };

            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string DosyaYolu = file.FileName;

                    textBoxSartname.Text = DosyaYolu;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message);
            }
            finally
            {
                file.Dispose();
            }
        }
    }
}
