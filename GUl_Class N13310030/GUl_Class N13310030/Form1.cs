using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
        private void button2_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum = Int32.Parse(count)-1;
            lab_Counter.Text = sum.ToString();


        }


        private void btnBigger_Click(object sender, EventArgs e)
        {
            new FormBtnBigger().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label2.Text= str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Counter = Int32.Parse(label222.Text.Replace("秒", ""));
            Counter += 1; //Counter = Counter+1;
            label222.Text = Counter.ToString() + "秒";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label222.Text = "0秒"; ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Formcheckbox().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             new FormLayout().Show();
            
        }
    }
}
