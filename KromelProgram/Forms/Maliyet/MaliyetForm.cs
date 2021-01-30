using KromelProgram.Forms.Mamul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromelProgram.Forms.Maliyet
{
    public partial class MaliyetForm : Form
    {
        public MaliyetForm()
        {
            InitializeComponent();
        }

        public void SetMamul(string id)
        {
            textBoxMamulKodu.Text = id;
            textBoxMamulAdi.Text = mamulTableAdapter.GetData().FindByMamulID(id).MamulAdi;
        }

        private void MaliyetForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Maliyet' table. You can move, or remove it, as needed.
            
            //this.maliyetTableAdapter.Fill(this.databaseDataSet.Maliyet);
           
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBoxMamulKodu.Text!="")
            {
                try
                {
                    Validate();
                    maliyetBindingSource.EndEdit();
                    maliyetTableAdapter.Update(this.databaseDataSet.Maliyet);

                    fillByToolStripButton_Click(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen mamül seçiniz!");

                buttonMamulSec_Click(sender, e);
            }
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.maliyetTableAdapter.FillBy(this.databaseDataSet.Maliyet, parametreToolStripTextBox.Text);

                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    string mamuladi = mamulTableAdapter.GetData().FindByMamulID(item.Cells["mamulIDDataGridViewTextBoxColumn"].Value.ToString()).MamulAdi;
                    item.Cells["MamulAdi"].Value = mamuladi;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonMamulSec_Click(object sender, EventArgs e)
        {
            MamulSecForm mamulSecForm = new MamulSecForm(this);

            mamulSecForm.Show();
        }

        private void textBoxMamulKodu_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMamulKodu.Text != "")
            {
                string mamuladi = mamulTableAdapter.GetData().FindByMamulID(textBoxMamulKodu.Text).MamulAdi;

                textBoxMamulAdi.Text = mamuladi;
            }
            else textBoxMamulAdi.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {

                MaliyetlendirmeForm maliyetlendirmeForm = new MaliyetlendirmeForm();

                maliyetlendirmeForm.SetMamul(textBoxMaliyetID.Text);

                //maliyetlendirmeForm.Show();
            }
        }

    }
}
