using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KromelProgram.Forms.Maliyet
{
    public partial class GrafikForm : Form
    {
        public GrafikForm()
        {
            InitializeComponent();
        }

        private void GrafikForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.grafik' table. You can move, or remove it, as needed.
            this.grafikTableAdapter.Fill(this.databaseDataSet.grafik);
        }
    }
}
