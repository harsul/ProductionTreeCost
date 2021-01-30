using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromelProgram.Forms.Malzeme
{
    public partial class MalzemeListForm : Form
    {
        public MalzemeListForm()
        {
            InitializeComponent();
        }

        private void MalzemeListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Malzeme' table. You can move, or remove it, as needed.
            //this.malzemeTableAdapter.Fill(this.databaseDataSet.Malzeme);

            ColoringDates();
        }

        private void ColoringDates()
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                double days = (DateTime.Now - Convert.ToDateTime(item.Cells["tarihDataGridViewTextBoxColumn"].Value)).TotalDays;

                if (days <= 30)
                {
                    dataGridView1.Rows[item.Index].Cells["tarihDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                }
                else if (days > 30 && days <= 60)
                {
                    dataGridView1.Rows[item.Index].Cells["tarihDataGridViewTextBoxColumn"].Style.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView1.Rows[item.Index].Cells["tarihDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                malzemeBindingSource.EndEdit();
                malzemeTableAdapter.Update(this.databaseDataSet.Malzeme);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                malzemeTableAdapter.FillByFilter(this.databaseDataSet.Malzeme, parameterToolStripTextBox.Text);
                ColoringDates();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

    }
}
