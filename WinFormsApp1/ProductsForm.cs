using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class ProductsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\uttam\OneDrive\Documents\liquordb.mdf;
        Integrated Security=True;Connect Timeout=30");
       // SqlDataReader dr;
        public ProductsForm()
        {
            InitializeComponent();
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("productTable");
            con.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productid_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                String query = "insert into productTable values ("+productid.Text+"," +
                    "'"+productname.Text+"','"+productquantity.Text+"','"+listBoxsize.SelectedItem+"'," +
                    "'"+costprice.Text+"','"+sellingprice.Text+"','"+listBoxCategory.SelectedItem+"')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insterted");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
