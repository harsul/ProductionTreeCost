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
    public partial class MalzemeSecForm : Form
    {
        MaliyetlendirmeForm maliyetlendirmeForm = null;
        public MalzemeSecForm(MaliyetlendirmeForm maliyetlendirmeForm)
        {
            InitializeComponent();

            this.maliyetlendirmeForm = maliyetlendirmeForm;
        }

        private void MalzemeSecForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kromelDBDataSet.Malzeme' table. You can move, or remove it, as needed.
            //this.malzemeTableAdapter.Fill(this.kromelDBDataSet.Malzeme);

        }

        private void FiltreleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.malzemeTableAdapter.Filtrele(this.kromelDBDataSet.Malzeme, parameterToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 0)
            {
                if (textBoxBirimFiyat.Text != "")
                {
                    try
                    {
                        maliyetlendirmeForm.SetMalzeme(
                        textBoxMalzemeID.Text, textBoxMalzemeAdi.Text, textBoxBirimFiyat.Text);

                        MessageBox.Show("Eklendi");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Malzeme Fiyat Eksik, lütfen giriniz!");
                }
            }
        }
    }
}
