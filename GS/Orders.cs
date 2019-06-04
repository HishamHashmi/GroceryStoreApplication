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
    public partial class Orders : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GroceryStroreDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public Orders()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from ProductOrders", con);
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

        private void Order_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                int price = 0, pricebyquantity = 0, quantity = 0, remainingQty = 0;
                SqlCommand cmd = new SqlCommand("SELECT productPrice from Products WHERE productName='" + proname.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader sdr = null;
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    price = int.Parse(sdr[0].ToString());
                }
                sdr.Close();
                pricebyquantity = price * int.Parse(pquantity.Text);
                SqlCommand Sqlcmd = new SqlCommand("INSERT into ProductOrders(productName, productCategory, productCompany, productPrice, productQuantity )values('"+proname.Text+"','"+procategory.Text+"','"+pcompany.Text+"','"+pricebyquantity+"','"+pquantity.Text+"')", con);
                Sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from ProductOrders",con);
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
                SqlCommand Objcmd = new SqlCommand("SELECT productQuantity from Products WHERE productName='" + proname.Text + "'", con);
                con.Open();
                Objcmd.ExecuteNonQuery();
                SqlDataReader Objsdr = null;
                Objsdr = Objcmd.ExecuteReader();
                while (Objsdr.Read())
                {
                    quantity = int.Parse(Objsdr[0].ToString());
                }
                con.Close();
                remainingQty = quantity - int.Parse(pquantity.Text);
                SqlCommand Objcmd1 = new SqlCommand("UPDATE Products SET productQuantity = '" + remainingQty + "' WHERE productName= '" + proname.Text + "'",con);
                con.Open();
                Objcmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DATA SAVED SUCCESSFULLY!!");
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void AddProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products p = new Products();
            p.ShowDialog();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteProducts dp = new DeleteProducts();
            dp.ShowDialog();
        }
    }
}
