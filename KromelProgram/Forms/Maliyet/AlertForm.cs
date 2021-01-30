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
    public partial class AlertForm : Form
    {
        public string Message
        {
            set { alert.Text = value; }
        }

        public int ProgressValue
        {
            set { progressBar.Value = value; }
        }

        public AlertForm()
        {
            InitializeComponent();
        }

    }
}
