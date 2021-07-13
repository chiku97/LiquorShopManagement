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
                string query = "insert into productTable values ("+productid.Text+"," +
                    "'"+productname.Text+"','"+productquantity.Text+"','"+listBoxsize.SelectedItem.ToString()+"'," +
                    "'"+costprice.Text+"','"+sellingprice.Text+"','"+listBoxCategory.SelectedItem.ToString()+"')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insterted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SallerForm s = new SallerForm();
            s.Show();

        }

        private void ProductsForm_Load_1(object sender, EventArgs e)
        {
            loadProductsData();
        }


        private void loadProductsData()
        {
            con.Open();
            String query = "select * from productTable";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            productDGV.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (productid.Text == "")
                {
                    MessageBox.Show("Select the product to Delet");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update productTable set name=@name,quantity=@quantity,productsize=@productsize,costprice=@costprice," +
                        "sellingprice=@sellingprice,category=@category where Id=@productId", con);
                    cmd.Parameters.AddWithValue("@productId", productid.Text);
                    cmd.Parameters.AddWithValue("@name", productname.Text);
                    cmd.Parameters.AddWithValue("@quantity", productquantity.Text);
                    cmd.Parameters.AddWithValue("@productsize", listBoxsize.SelectedItem);
                    cmd.Parameters.AddWithValue("@costprice", costprice.Text);
                    cmd.Parameters.AddWithValue("@sellingprice", sellingprice.Text);
                    cmd.Parameters.AddWithValue("@category", listBoxCategory.SelectedItem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully update");
                    con.Close();
                    loadProductsData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = productDGV.Rows[i];
            productid.Text = row.Cells[0].Value.ToString();
            productname.Text = row.Cells[1].Value.ToString();
            productquantity.Text = row.Cells[2].Value.ToString();
            listBoxsize.SelectedItem = row.Cells[3].Value.ToString();
            costprice.Text = row.Cells[4].Value.ToString();
            sellingprice.Text = row.Cells[5].Value.ToString();
            listBoxCategory.SelectedItem = row.Cells[6].Value.ToString();

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (productid.Text == "")
                {
                    MessageBox.Show("Select the product to Delet");
                }
                else
                {
                    con.Open();
                    string query = "delete from productTable where id=" + productid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted successfully");
                    con.Close();
                    loadProductsData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
               // string query = "select * from productTable where category=" + listBoxViewCategory.SelectedItem + "";
                SqlCommand cmd = new SqlCommand("select * from productTable where category=@category", con);
                cmd.Parameters.AddWithValue("@category", listBoxViewCategory.SelectedItem);
                cmd.ExecuteNonQuery();
                //SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                var dataSet = new DataSet();
                sda.Fill(dataSet);
                productDGV.DataSource = dataSet.Tables[0];
                MessageBox.Show("Refreshed successfully");
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
