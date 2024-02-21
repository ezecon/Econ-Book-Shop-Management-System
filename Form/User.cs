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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin form2 = new admin();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AdminDash form2 = new AdminDash();
            form2.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "" || textBoxPass.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Missing information.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand bmd = new SqlCommand("insert into UserListTable values ( @Users, @Password, @Phone, @Address)", con);
                    bmd.Parameters.AddWithValue("@Users", textBoxUser.Text);
                    bmd.Parameters.AddWithValue("@Password", textBoxPass.Text);
                    bmd.Parameters.AddWithValue("@Phone", int.Parse(textBox2.Text));
                    bmd.Parameters.AddWithValue("@Address", textBox4.Text);
                    bmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved.");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserListTable set Password = @Password, Phone = @Phone,Address=@Address where Users=@Users", Con);
                cmd.Parameters.AddWithValue("@Users", textBoxUser.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPass.Text);
                cmd.Parameters.AddWithValue("@Phone", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@Address", textBox4.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved.");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from UserListTable where Users=@Users", Con);
                cmd.Parameters.AddWithValue("@Users", textBoxUser.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Successfully Deleted.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
