using KromelProgram.Forms.Maliyet;
using KromelProgram.Forms.Malzeme;
using KromelProgram.Forms.Mamul;
using System;
using System.Windows.Forms;

namespace KromelProgram
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void malzemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MalzemeListForm malzemeListForm= new MalzemeListForm();

            malzemeListForm.Show();
        }

        private void mamulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamulListForm mamulListForm = new MamulListForm();

            mamulListForm.Show();
        }

        private void maliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaliyetListForm maliyetForm = new MaliyetListForm();

            maliyetForm.Show();
        }

        private void maliyetHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MamulSecForm mamulSecForm = new MamulSecForm(this);

            mamulSecForm.Show();
        }
    }
}
