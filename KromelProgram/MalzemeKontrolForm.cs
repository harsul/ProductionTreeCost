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
    public partial class MalzemeKontrolForm : Form
    {
        public MalzemeKontrolForm()
        {
            InitializeComponent();
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

        private void ToolStripButtonGuncele_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.malzemeBindingSource.EndEdit();
            this.malzemeTableAdapter.Update(this.kromelDBDataSet.Malzeme);

            MessageBox.Show("Update successful");
        }
    }
}
