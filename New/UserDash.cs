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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopManagement
{
    public partial class UserDash : Form
    {
        public UserDash()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");

        private void UserDash_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Slip form2 = new Slip();
            form2.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Books form2 = new Books();
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
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                string selectedValue = comboBox1.SelectedItem.ToString();
                string temp = selectedValue;
                if (temp.Equals("BookNamer"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from BookSellTable where BookNamer=@Booknamer", Con);
                    cmd.Parameters.AddWithValue("@BookNamer", textBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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
                    dataGridView1.DataSource = dt;
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
                    dataGridView1.DataSource = dt;
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
                    dataGridView1.DataSource = dt;

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
