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


namespace N13310011
{
    public partial class FormOderMenu : Form
    {
        public FormOderMenu()
        {
            InitializeComponent();
            if (!File.Exists("OderData.csv")) ;
            File.WriteAllText("OderData.csv", "時間,主食,配菜,甜點,飲品\n",Encoding.UTF8);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDataTime = DateTime.Now;
            string formmattedDataTime= currentDataTime.ToString("yyyy/MM/dd HH:mm:ss");
            string food = "", sidefood = "", drink = "", dessert = "";

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        food = temp.Text;
                    }

                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        sidefood = temp.Text;
                    }
                }
            }
            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        dessert = temp.Text;
                    }
                }
            }
            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        drink = temp.Text;
                    }
                }
            }
            File.AppendAllText("OderData.csv", formmattedDataTime+"," +food + ","+ sidefood+ ","+ drink + ","+ dessert+"\n");
            MessageBox.Show("點餐完成!製作中請稍後");

        }
    }
}
