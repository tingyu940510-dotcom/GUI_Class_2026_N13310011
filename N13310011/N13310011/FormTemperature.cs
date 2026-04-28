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
    public partial class FormTemperature : Form
    {
        public FormTemperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = this.c.Text;
            double c = double.Parse(this.c.Text);
            double f = c*(9/5.0)+32;
            label3.Text =f.ToString();

        }
    }
}
