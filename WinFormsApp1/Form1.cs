using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex > 0)
            {
                
                if (listBox1.SelectedItem.Equals("Admin"))
                {
                    if (textBox1.Text.ToLower() == "admin" && textBox2.Text.ToLower() == "admin")
                    {
                        ProductsForm p = new ProductsForm();
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Admin Credentials incorrect");
                    }
                }
                else if (listBox1.SelectedItem.Equals("Seller"))
                {
                    if (textBox1.Text.ToLower() == "seller" && textBox2.Text.ToLower() == "seller")
                    {
                        sellingForm sf = new sellingForm();
                        sf.Show();
                    }
                    else
                    {
                        MessageBox.Show("seller Credentials incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect credentials");
                }
            }
            else
            {
                MessageBox.Show("Please select login type");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
