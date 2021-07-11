using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class sellingForm : Form
    {

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
            textBoxName.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
