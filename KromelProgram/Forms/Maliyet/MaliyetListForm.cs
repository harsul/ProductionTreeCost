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
    public partial class MaliyetListForm : Form
    {
        public MaliyetListForm()
        {
            InitializeComponent();
        }

        private void MaliyetListForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.mamulTableAdapter.FillByUrunAgac(this.databaseDataSet.Mamul);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["mamulIDDataGridViewTextBoxColumn"].Value.ToString();

                if (e.ColumnIndex == 0)
                {
                    MaliyetlendirmeForm maliyetlendirme = new MaliyetlendirmeForm();

                    maliyetlendirme.SetMamul(id);

                    this.Close();
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

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mamulTableAdapter.FillByUrunAgacFilter(this.databaseDataSet.Mamul, parametreToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
