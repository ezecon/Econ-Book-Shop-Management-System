using BookShopManagement.Entity;
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
    public partial class Books : Form
    {
        


        public Books()
        {
            InitializeComponent();
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();
            form2.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update BookSellTable set BookNamer = @BookNamer,BookAuthor=@BookAuthor, BookCat = @BookCat,BookQuan=@BookQuan, BookPrice=@BookPrice, Amount=@Amount where BookId=@BookId", Con);
                cmd.Parameters.AddWithValue("@BookId", textBox3.Text);
                cmd.Parameters.AddWithValue("@BookNamer", textBox1.Text);
                cmd.Parameters.AddWithValue("@BookAuthor", textBox2.Text);
                cmd.Parameters.AddWithValue("@BookCat", textBox6.Text);
                cmd.Parameters.AddWithValue("@BookQuan", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@BookPrice", int.Parse(textBox5.Text));
                cmd.Parameters.AddWithValue("@Amount", int.Parse(textBox5.Text) * int.Parse(textBox4.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved.");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text == "" || textBox6.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Missing information.");
            }
            else 
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into BookSellTable values ( @BookId, @BookNamer,@BookAuthor, @BookCat,@BookQuan, @BookPrice, @Amount)", Con);
                    cmd.Parameters.AddWithValue("@BookId", textBox3.Text);
                    cmd.Parameters.AddWithValue("@BookNamer", textBox1.Text);
                    cmd.Parameters.AddWithValue("@BookAuthor", textBox2.Text);
                    cmd.Parameters.AddWithValue("@BookCat", textBox6.Text);
                    cmd.Parameters.AddWithValue("@BookQuan", int.Parse(textBox4.Text));
                    cmd.Parameters.AddWithValue("@BookPrice", int.Parse(textBox5.Text));
                    cmd.Parameters.AddWithValue("@Amount", int.Parse(textBox5.Text)* int.Parse(textBox4.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved.");
                    Con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
                
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserDash form2 = new UserDash();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("delete from BookSellTable where BookId=@BookId", Con);
                cmd.Parameters.AddWithValue("@BookId", textBox3.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Successfully Deleted.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
