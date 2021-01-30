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
    public partial class MamulKontrolForm : Form
    {
        public MamulKontrolForm()
        {
            InitializeComponent();
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

        private void ToolStripButtonMamulGunceleme_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mamulBindingSource.EndEdit();
            this.mamulTableAdapter.Update(this.kromelDBDataSet.Mamul);

            MessageBox.Show("Update successful");
        }
    }
}
