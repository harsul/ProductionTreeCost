using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromelProgram.Forms.Mamul
{
    public partial class ResimGosterForm : Form
    {
        public ResimGosterForm(string id)
        {
            InitializeComponent();

            try
            {
                string DosyaYolu = mamulTableAdapter.GetData().FindByMamulID(id).Resim;
                pictureBoxResim.Image = Image.FromFile(DosyaYolu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
