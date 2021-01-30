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
    public partial class MamulSecForm : Form
    {
        MaliyetlendirmeForm maliyetlendirmeForm = null;
        MaliyetlendirmeKontrolForm maliyetlendirmeKontrolForm = null;

        public MamulSecForm(MaliyetlendirmeForm maliyetlendirmeForm)
        {
            InitializeComponent();

            this.maliyetlendirmeForm = maliyetlendirmeForm;

            maliyetlendirmeKontrolForm = null;
        }

        public MamulSecForm(MaliyetlendirmeKontrolForm maliyetlendirmeKontrolForm)
        {
            InitializeComponent();

            this.maliyetlendirmeKontrolForm = maliyetlendirmeKontrolForm;

            maliyetlendirmeForm = null;
        }

        private void MamulSecForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kromelDBDataSet.Mamul' table. You can move, or remove it, as needed.
            this.mamulTableAdapter.Fill(this.kromelDBDataSet.Mamul);

        }

        private void FiltreleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mamulTableAdapter.Filtrele(this.kromelDBDataSet.Mamul, parametreToolStripTextBox.Text);
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
                try
                {
                    if (maliyetlendirmeForm!=null)
                    {
                        maliyetlendirmeForm.SetMamul(
                        textBoxMamulID.Text, textBoxMamulAdi.Text);
                    }
                    else if (maliyetlendirmeKontrolForm!=null)
                    {
                       maliyetlendirmeKontrolForm.SetMamul(
                       textBoxMamulID.Text, textBoxMamulAdi.Text);
                    }

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
        }
    }
}
