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
    public partial class SallerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
        AttachDbFilename=C:\Users\uttam\OneDrive\Documents\liquordb.mdf;
        Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        public SallerForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "insert into sellersTable values (" + sallerid.Text + "," +
                    "'" + sallername.Text + "','" + sallerAge.Text + "','" + sallerPhone.Text + "',"+
                    "'" + sellerPasswoed.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insterted");
                loadSellersData();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SallerForm_Load(object sender, EventArgs e)
        {
            loadSellersData();
        }

        private void loadSellersData()
        {
            con.Open();
            String query = "select * from sellersTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var dataSet = new DataSet();
            sda.Fill(dataSet);
            sellerDataGrid.DataSource = dataSet.Tables[0];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm();
            pf.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sellerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //sellerDataGrid.Columns[0].Name = "sallerid";
            //sellerDataGrid.Columns[1].Name = "sallername";
            //sellerDataGrid.Columns[2].Name = "sallerAge";
            //sellerDataGrid.Columns[3].Name = "sallerPhone";
            //sellerDataGrid.Columns[4].Name = "sellerPasswoed";

            int i = e.RowIndex;
            DataGridViewRow row = sellerDataGrid.Rows[i];
            sallerid.Text = row.Cells[0].Value.ToString();
            sallername.Text = row.Cells[1].Value.ToString();
            sallerAge.Text = row.Cells[2].Value.ToString();
            sallerPhone.Text = row.Cells[3].Value.ToString();
            sellerPasswoed.Text = row.Cells[4].Value.ToString();


        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (sallerid.Text == "")
                {
                    MessageBox.Show("Select the product to Delet");
                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("update sellersTable set sellerName=@sellerName,sellerAge=@sellerAge,sellerPhone=@sellerPhone,sellerPassword=@sellerPassword where sellerId=@sellerId", con);
                    cmd.Parameters.AddWithValue("@sellerId", sallerid.Text);
                    cmd.Parameters.AddWithValue("@sellerName", sallername.Text);
                    cmd.Parameters.AddWithValue("@sellerAge", Int32.Parse(sallerAge.Text));
                    cmd.Parameters.AddWithValue("@sellerPhone", sallerPhone.Text);
                    cmd.Parameters.AddWithValue("@sellerPassword", sellerPasswoed.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product successfully update");
                    loadSellersData();
                    con.Close();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sallerid.Text == "")
                {
                    MessageBox.Show("Select the product to Delet");
                }
                else
                {
                    con.Open();
                    string query = "delete from sellersTable where sellerId=" + sallerid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted successfully");
                    con.Close();
                    loadSellersData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
 }
