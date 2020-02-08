using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_WndowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HAI","hlo");

            if ((textBox1.Text == "") || (textBox2.Text == ""))
                MessageBox.Show("Fields Cannot be Empty");
            else
            {
                double n1, n2;
                n1 = double.Parse(textBox1.Text);
                n2 = double.Parse(textBox2.Text);

                double res = 0;

                if (rdb_Add.Checked)
                {
                    res = n1 + n2;
                    label4.Text = "Sum : " + res;
                }

                else if (rdb_Sub.Checked)
                {
                    res = n1 - n2;
                    label4.Text = "Difference : " + res;
                }

                else if (rdb_Mul.Checked)
                {
                    res = n1 * n2;
                    label4.Text = "Product : " + res;
                }

                else if (rdb_Div.Checked)
                {
                    res = n1 / n2;
                    label4.Text = "Quotient : " + res;
                }
                else
                    label4.Text = "Enter Your choice";

            }
        }
    }
}
