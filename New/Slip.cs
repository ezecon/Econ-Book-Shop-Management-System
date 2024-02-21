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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookShopManagement
{
    public partial class Slip : Form
    {
        public Slip()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(localDb)\BookShopMan;Initial Catalog=MyBookShop;Integrated Security=True");

            
            Con.Open();
            SqlCommand cmd = new SqlCommand("select distinct BookAuthor from BookSellTable where BookId=@BookId", Con);
            cmd.Parameters.AddWithValue("@BookId", textpassadmin.Text);
            string result = (string)cmd.ExecuteScalar();
            string recordText1 = string.Format("Author: "+result);
            SqlCommand amd = new SqlCommand("SELECT SUM(BookQuan) FROM BookSellTable WHERE BookId=@BookId", Con);
            amd.Parameters.AddWithValue("@BookId", textpassadmin.Text);
            int result1 = (int)amd.ExecuteScalar();
            string recordText2 = string.Format("Quantity: " + result1);
            SqlCommand bmd = new SqlCommand("SELECT SUM(Amount) FROM BookSellTable WHERE BookId=@BookId", Con);
            bmd.Parameters.AddWithValue("@BookId", textpassadmin.Text);
            int result2 = (int)bmd.ExecuteScalar();
            string recordText3 = string.Format("Amount: " + result2);
            Con.Close();

            string line1 = "EconBookShop"+"\n"+"--------------------" + "\n"+"Payment Slip: ";
            string line2 = recordText1 + "\n" + recordText2 + "\n" + recordText3;
            Font font1 = new Font("Arial", 10);
            Font font2 = new Font("Arial", 7);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Calculate the required size of the bounding rectangles
            SizeF size1 = e.Graphics.MeasureString(line1, font1);
            SizeF size2 = e.Graphics.MeasureString(line2, font2);

            // Calculate the bounds of the text
            RectangleF bounds1 = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, 0, size1.Height);
            RectangleF bounds2 = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top + size1.Height, e.MarginBounds.Width, size2.Height);

            // Draw the text on the page, using different font sizes for each line
            e.Graphics.DrawString(line1, font1, brush, bounds1);
            e.Graphics.DrawString(line2, font2, brush, bounds2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Econ Book Shop", 285, 200);
            printPreviewDialog1.ShowDialog();

        }
    }
}
