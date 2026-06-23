using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace GUl_Class_N13310030
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,好料,甜點,超跑大拍賣\n", Encoding.UTF8);
        }
        




        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime currentDataTime = DateTime.Now;
            string formattedDateTime = currentDataTime.ToString("yyyy/MM/dd HH:mm:ss");

            string food = "", geatDeals = "", desserts = "", supercars = "";





            foreach (Control c in Panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        food+=""+temp.Text;

                    }

                }
            }
            foreach (Control c in Panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        geatDeals+=""+temp.Text;
                    }

                }
            }
            foreach (Control c in Panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        desserts+=""+temp.Text;
                    }

                }
            }
            foreach (Control c in Panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked==true)
                    {
                        //MessageBox.Show(temp.Text);
                        supercars+=""+temp.Text;
                    }

                }
            }






            File.AppendAllText("OrderData.csv", formattedDateTime+","+food+","+ geatDeals+","+desserts+","+supercars+"\n");
            MessageBox.Show("點餐完成!製作中請稍等!");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
