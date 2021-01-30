using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromERP
{
    public partial class MalzemeForm : Form
    {
        public MalzemeForm()
        {
            InitializeComponent();
        }

        private void MalzemeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kromelDatabaseDataSet1.Malzeme' table. You can move, or remove it, as needed.
            this.malzemeTableAdapter1.Fill(this.kromelDatabaseDataSet1.Malzeme);

        }

        private void fillByIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.malzemeTableAdapter.FillByID(this.kromelDatabaseDataSet.Malzeme, parameterToolStripTextBox.Text);

                if (dataGridViewMalzeme.Rows.Count == 0)
                {
                    MessageBox.Show("Filtrenize uygun sonuçlar bulunamadı!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    //labelMesaj.Text = "Filtrenize uygun sonuçlar bulunamadı!";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata:"+ ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                malzemeBindingSource1.EndEdit();
                malzemeTableAdapter1.Update(this.kromelDatabaseDataSet.Malzeme);

                labelMesaj.Text = DateTime.Now + " Günceleme işlemi başarılı.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
