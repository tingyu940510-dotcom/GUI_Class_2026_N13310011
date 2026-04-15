using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N13310011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clickme_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text=="按我一下")
                btn_ClickMe.Text="我已經被按過了";

            else if (btn_ClickMe.Text=="我已經被按過了")
                btn_ClickMe.Text="按我一下";
        }

        private void btn_ChangLabel_Click(object sender, EventArgs e)
        {
            lab_ChangeLabel.Text="按鈕被按過了";
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count= lab_Counter.Text;
            int sum=Int32.Parse(count)+1;
            lab_Counter.Text=sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormBtnBigger().Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            label2.Text = str;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum = Int32.Parse(count)-1;
            lab_Counter.Text=sum.ToString();
        }
    }
}
