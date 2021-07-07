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
    }
}
