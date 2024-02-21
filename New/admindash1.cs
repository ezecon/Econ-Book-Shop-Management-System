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
    public partial class admindash1 : Form
    {
        
        public admindash1()
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
            string query = "select * from UserListTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string selectedValue = comboBox1.SelectedItem.ToString();
            string temp = selectedValue;
            
            
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                
                if (temp.Equals("Users"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserListTable WHERE Users LIKE '%' + @Users + '%'", Con);
                    cmd.Parameters.AddWithValue("@Users", textBoxUSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    Con.Close();
                }
                else if(temp.Equals("Address"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserListTable WHERE Address LIKE '%' + @Address + '%'", Con);
                    cmd.Parameters.AddWithValue("@Address", textBoxUSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    Con.Close();
                }
                else if (temp.Equals("Password"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserListTable WHERE Password LIKE '%' + @Password + '%'", Con);
                    cmd.Parameters.AddWithValue("@Password", textBoxUSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    Con.Close();
                }
                else if (temp.Equals("Phone"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserListTable WHERE Phone LIKE '%' + @Phone + '%'", Con);
                    cmd.Parameters.AddWithValue("@Phone", textBoxUSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    Con.Close();
                }
                else if (temp.Equals("BId"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM UserListTable WHERE BId LIKE '%' + @BId + '%'", Con);
                    cmd.Parameters.AddWithValue("@BId", textBoxUSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    Con.Close();
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
