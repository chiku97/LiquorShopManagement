using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class sellingForm : Form
    {

        int n = 0;
        int Grdtotal = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\uttam\OneDrive\Documents\liquordb.mdf;
        Integrated Security=True;Connect Timeout=30");
        public sellingForm()
        {
            InitializeComponent();
        }


        private void sellingForm_Load(object sender, EventArgs e)
        {
            loadProductsData();
        }

        private void loadProductsData()
        {
            con.Open();
            String query = "select name,sellingprice from productTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            dataGridView3.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[i];
            textBoxName.Text = row.Cells[0].Value.ToString();
            textBoxPrice.Text = row.Cells[1].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public SafeFileHandle COMPROVANTE { get; private set; }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBoxQuantity.Text != "") {

                int total = Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxQuantity.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);
                n = n + 1;
                newRow.Cells[0].Value = n;
                newRow.Cells[1].Value = textBoxName.Text;
                newRow.Cells[2].Value = textBoxPrice.Text;
                newRow.Cells[3].Value = textBoxQuantity.Text;
                newRow.Cells[4].Value = Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxQuantity.Text);
                dataGridView2.Rows.Add(newRow);
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = Grdtotal.ToString();
            }
            else
            {
                MessageBox.Show("Enter Quantity");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into BillTable values (" + textBoxBillId.Text + "," +
                    "'" + textBoxName.Text + "','" + Datelb.Text + "','"+ Amtlbl.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Insterted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Liquor shop", new Font("Century Gothic",25,FontStyle.Bold),Brushes.Red,new Point(230));



            Bitmap bm = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            e.Graphics.DrawImage(bm,100, 100);


            e.Graphics.DrawString("Total Amount = " + Amtlbl.Text, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(130, 1000));

        }

    }
}
