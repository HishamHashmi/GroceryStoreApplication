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
namespace GS
{
    public partial class Products : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GroceryStroreDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public Products()
        {
            InitializeComponent();
            BindDate();
        }
        private void BindDate()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].DisplayIndex = 0;
                dataGridView1.Columns["productName"].DisplayIndex = 1;
                dataGridView1.Columns["productCategory"].DisplayIndex = 2;
                dataGridView1.Columns["productCompany"].DisplayIndex = 3;
                dataGridView1.Columns["productPrice"].DisplayIndex = 4;
                dataGridView1.Columns["productQuantity"].DisplayIndex = 5;
                con.Close();
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT into Products(productName,productCategory,productCompany, productPrice, productQuantity)values('"+ proname.Text +"','"+procategory.Text+"','"+pcompany.Text+"','"+pprice.Text+"','"+pquantity.Text+"')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Successfully!!");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].DisplayIndex = 0;
                dataGridView1.Columns["productName"].DisplayIndex = 1;
                dataGridView1.Columns["productCategory"].DisplayIndex = 2;
                dataGridView1.Columns["productCompany"].DisplayIndex = 3;
                dataGridView1.Columns["productPrice"].DisplayIndex = 4;
                dataGridView1.Columns["productQuantity"].DisplayIndex = 5;
                con.Close();
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProducts dp = new DeleteProducts();
            dp.ShowDialog();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            proname.Text = "";
            pprice.Text = "";
            pquantity.Text = "";
            pcompany.Text = "";
            procategory.Text = "";
            BindDate();
        }
    }
}
