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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StandardMaliyetHesabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaliyetlendirmeForm form = new MaliyetlendirmeForm();

            form.Show();
        }

        private void MalzemeKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MalzemeKontrolForm form = new MalzemeKontrolForm();

            form.Show();
        }

        private void MamulKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamulKontrolForm form = new MamulKontrolForm();

            form.Show();
        }

        private void MaliyetHesabiKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaliyetlendirmeKontrolForm form = new MaliyetlendirmeKontrolForm();

            form.Show();
        }
    }
}
