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

namespace BookShopManagement
{
    public partial class admindash2 : Form
    {
        public admindash2()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");


        private void button3_Click(object sender, EventArgs e)
        {
            User form2 = new User();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDash form2 = new AdminDash();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin form2 = new admin();
            form2.Show();
            this.Hide();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from BookSellTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView13.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select * from BookSellTable where BookId=@BookId", Con);
                cmd.Parameters.AddWithValue("@BookId", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView13.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            string temp = selectedValue;

            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                if (temp.Equals("BookNamer"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from BookSellTable where BookNamer=@Booknamer", Con);
                    cmd.Parameters.AddWithValue("@BookNamer", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView13.DataSource = dt;
                    Con.Close();
                }
                else if (temp.Equals("BookId"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from BookSellTable where BookId=@BookId", Con);
                    cmd.Parameters.AddWithValue("@BookId", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView13.DataSource = dt;
                    Con.Close();
                }
                else if (temp.Equals("BookCat"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from BookSellTable where BookCat=@BookCat", Con);
                    cmd.Parameters.AddWithValue("@BookCat", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView13.DataSource = dt;
                    Con.Close();
                }
                else if (temp.Equals("BookAuthor"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from BookSellTable where BookAuthor=@BookAuthor", Con);
                    cmd.Parameters.AddWithValue("@BookAuthor", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView13.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Wrong Selection.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
