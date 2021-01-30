using KromelProgram.Forms.Maliyet;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace KromelProgram.Forms.Mamul
{
    public partial class MamulSecForm : Form
    {
        MaliyetForm maliyetForm = null;
        Main Main = null;

        public MamulSecForm()
        {
            InitializeComponent();
        }

        public MamulSecForm(MaliyetForm maliyetForm)
        {
            InitializeComponent();

            this.maliyetForm = maliyetForm;
        }

        public MamulSecForm(Main maliyetHesapForm)
        {
            InitializeComponent();

            this.Main = maliyetHesapForm;
        }

        private void MamulSecForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Mamul' table. You can move, or remove it, as needed.
            this.mamulTableAdapter.Fill(this.databaseDataSet.Mamul);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridClick(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void DataGridClick(DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["mamulIDDataGridViewTextBoxColumn"].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if (Main!=null)
                {

                    MaliyetHesapForm maliyetHesapForm = new MaliyetHesapForm();

                    maliyetHesapForm.SetMamul(id);

                    maliyetHesapForm.Show();

                }
                else if (maliyetForm!=null)
                {

                    maliyetForm.SetMamul(id);
                }

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

        private void fillByFilterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mamulTableAdapter.FillByFilter(this.databaseDataSet.Mamul, parameterToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
