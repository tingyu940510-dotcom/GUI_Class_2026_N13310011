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
    }
}
