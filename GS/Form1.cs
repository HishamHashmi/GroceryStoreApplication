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
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GroceryStroreDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
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
        private void SearchButton_Click(object sender, EventArgs e)
        {
           using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (pName.Text != null && pQty.Text == null && pPrice.Text == null && Cpy.Text == null && categry.Text == null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productName='" + pName.Text + "'", con);
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
                else if (pName.Text == null && pQty.Text != null && pPrice.Text == null && Cpy.Text == null && categry.Text == null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productQuantity= '" + pQty.Text + "'", con);
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
                else if (pName.Text == null && pQty.Text == null && pPrice.Text != null && Cpy.Text == null && categry.Text == null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productPrice= '" + pPrice.Text + "'", con);
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
                else if (pName.Text == null && pQty.Text == null && pPrice.Text == null && Cpy.Text == null && categry.Text == null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productCompany= '" + Cpy.Text + "'", con);
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
                else if (pName.Text == null && pQty.Text == null && pPrice.Text == null && Cpy.Text == null && categry.Text != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productCategory= '" + categry.Text + "'", con);
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
                else if (pName.Text != null && pQty.Text != null && pPrice.Text != null && Cpy.Text != null && categry.Text != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products WHERE productName='" + pName.Text + "' OR productQuantity= '" + pQty.Text + "' OR productPrice= '" + pPrice.Text + "' OR productCompany= '" + Cpy.Text + "'  OR productCategory= '" + categry.Text + "'", con);
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
                else if (pName.Text == null && pQty.Text == null && pPrice.Text == null && Cpy.Text == null && categry.Text == null)
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
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            pName.Text = "";
            pPrice.Text = "";
            pQty.Text = "";
            Cpy.Text = "";
            categry.Text = "";
            BindDate();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products p = new Products();
            p.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProducts dp = new DeleteProducts();
            dp.ShowDialog();
        }
    }
}
