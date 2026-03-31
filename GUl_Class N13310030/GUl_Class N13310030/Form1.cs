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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ClickMe_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text == "按我一下")
                btn_ClickMe.Text = "我被點過了";
            else if (btn_ClickMe.Text == "我被點過了")
                btn_ClickMe.Text = "按我一下";
        }

        private void btn_ChangeLable_Click(object sender, EventArgs e)
        {
            lab_CHangeLabel.Text="按鈕被按過了";
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum = Int32.Parse(count)+1;
            lab_Counter.Text = sum.ToString();
        }
    }
}
