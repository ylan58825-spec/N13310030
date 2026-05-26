using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUl_Class_N13310030
{
    public partial class Formcheckbox : Form
    {
        public Formcheckbox()
        {
            InitializeComponent();
        }

        private void Formcheckbox_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("幹");
            }
           




        }
    }
}
