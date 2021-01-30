using System;
using System.Windows.Forms;

namespace KromelProgram
{
    public partial class MaliyetlendirmeKontrolForm : Form
    {
        public MaliyetlendirmeKontrolForm()
        {
            InitializeComponent();

            //make right alignment for money columns
            this.dataGridView1.Columns["birimFiyatiDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridView1.Columns["tutariDataGridViewTextBoxColumn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void ButtonMamulSec_Click(object sender, EventArgs e)
        {
            MamulSecForm form = new MamulSecForm(this);

            form.Show();
        }

        public void SetMamul(string mamulid,string mamuladi)
        {
            textBoxMamulID.Text = mamulid;
            textBoxMamulAdi.Text = mamuladi;

            // TODO: This line of code loads data into the 'kromelDBDataSet.UrunAgaci' table. You can move, or remove it, as needed.
            this.urunAgaciCopyTableAdapter.Fill(this.kromelDBDataSet.UrunAgaciCopy, textBoxMamulID.Text);

            // TODO: This line of code loads data into the 'kromelDBDataSet.Maliyet' table. You can move, or remove it, as needed.
            this.maliyetTableAdapter.FillBy(this.kromelDBDataSet.Maliyet,textBoxMamulID.Text);

            textBoxToplamMaliyeti.Text =
                (Convert.ToDouble(textBoxMalzemeMaliyeti.Text) +
                Convert.ToDouble(textBoxIscilikMaliyeti.Text)).ToString();

            
        }

        private void MaliyetlendirmeKontrolForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kromelDBDataSet.IscilikGiderleri' table. You can move, or remove it, as needed.
            this.iscilikGiderleriTableAdapter.Fill(this.kromelDBDataSet.IscilikGiderleri);

        }

        private void ButtonMaliyetDetay_Click(object sender, EventArgs e)
        {
            MaliyetDetayForm form = new MaliyetDetayForm(textBoxMamulAdi.Text, textBoxIscilik.Text, textBoxMalzemeMaliyeti.Text);

            form.Show();
        }

        private void ButtonRapor_Click(object sender, EventArgs e)
        {
        }
    }
}
