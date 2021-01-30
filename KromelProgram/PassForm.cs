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
    public partial class PassForm : Form
    {
        public PassForm()
        {
            InitializeComponent();
        }

        private void ButtonGiris_Click(object sender, EventArgs e)
        {
            if (textBoxKullanici.Text=="osevim" && textBoxParola.Text=="1980")
            {
                MainForm mainForm = new MainForm();

                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Hatali giris. Lutfer tekrar deneyin");
            }
        }
    }
}
