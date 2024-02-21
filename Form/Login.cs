using BookShopManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopManagement
{
    public partial class Login : Form
    {
        /*public string password = "Econ1111034";
        public string user = "Econ";*/

        private Class1 _ObjUser = new Class1();
        private DataTable _DataTable = new DataTable();
        private bool status;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void X(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string pass = textBoxpass.Text.ToString();
            string userr = textBoxuser.Text.ToString();*/

            _ObjUser.UserId = textBoxuser.Text.ToString();
            _ObjUser.Password = textBoxpass.Text.ToString();

            _DataTable = new DataTable();
            _DataTable.Columns.Add("UserId");
            _DataTable.Columns.Add("Password");

            DataRow User2 = _DataTable.NewRow();
            User2["UserId"] = "Karib";
            User2["Password"] = "Karib041";
            _DataTable.Rows.Add(User2);

            DataRow User1 = _DataTable.NewRow();
            User1["UserId"] = "Saad";
            User1["Password"] = "Saad044";
            _DataTable.Rows.Add(User1);

            DataRow User3 = _DataTable.NewRow();
            User3["UserId"] = "Tamal";
            User3["Password"] = "Tamal038";
            _DataTable.Rows.Add(User3);

            DataRow User4 = _DataTable.NewRow();
            User4["UserId"] = "Atik";
            User4["Password"] = "Atik059";
            _DataTable.Rows.Add(User4);

            DataRow User5 = _DataTable.NewRow();
            User5["UserId"] = "Econ";
            User5["Password"] = "Econ034";
            _DataTable.Rows.Add(User5);


            foreach(DataRow dataRow in _DataTable.Rows)
            {
                if (_ObjUser.Password == dataRow["Password"].ToString() && _ObjUser.UserId == dataRow["UserId"].ToString())
                {
                    status = true;
                    break;
                }
                else
                {
                    status=false;
                }
            }
            if (status==false)
            {
                MessageBox.Show("Wrong Password");
            }
            else
            {
                Books form2 = new Books();
                form2.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin form2 = new admin();
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
