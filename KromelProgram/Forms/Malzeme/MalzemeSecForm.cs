using KromelProgram.Forms.Maliyet;
using KromelProgram.Forms.Mamul;
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
    public partial class MalzemeSecForm : Form
    {

        UrunAgaciForm urunAgaciForm = null;
        MaliyetlendirmeForm maliyetlendirmeForm = null;
        MaliyetHesapForm MaliyetHesapForm = null;

        public MalzemeSecForm()
        {
            InitializeComponent();
        }

        public MalzemeSecForm(UrunAgaciForm urunAgaciForm)
        {
            InitializeComponent();

            this.urunAgaciForm = urunAgaciForm;
        }
        public MalzemeSecForm(MaliyetlendirmeForm maliyetlendirmeForm)
        {
            InitializeComponent();

            this.maliyetlendirmeForm = maliyetlendirmeForm;
        }

        public MalzemeSecForm(MaliyetHesapForm maliyetHesapForm)
        {
            InitializeComponent();

            MaliyetHesapForm = maliyetHesapForm;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        { 
            MalzemeListForm malzemeListForm = new MalzemeListForm();

            malzemeListForm.Show();
        }

        private void MalzemeSecForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Malzeme' table. You can move, or remove it, as needed.
            //this.malzemeTableAdapter.Fill(this.databaseDataSet.Malzeme);
        }

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.malzemeTableAdapter.FillByFilter(this.databaseDataSet.Malzeme, parameterToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["malzemeIDDataGridViewTextBoxColumn"].Value.ToString();

                if (urunAgaciForm!=null)
                {

                    urunAgaciForm.setMalzeme(id);

                }
                else if (maliyetlendirmeForm!=null)
                {
                    maliyetlendirmeForm.setMalzeme(id);
                }
                else
                {
                    MaliyetHesapForm.setMalzeme(id);
                }

                this.Close();
            }
        }
    }
}
