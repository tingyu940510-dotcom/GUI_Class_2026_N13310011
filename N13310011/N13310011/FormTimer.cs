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
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labCounter.Text.Replace("秒",""));
            counter+=1; //counter = counter+1
            labCounter.Text=counter.ToString()+"秒";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int counter = Int32.Parse(labCounter2.Text.Replace("秒",""));
            counter+=1;//counter = counter+1;
            labCounter2.Text=counter.ToString()+"秒";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labCounter2.Text="0秒";
        }
    }
}
