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

namespace LibrarySystem
{
    public partial class Borrow : Form
    {
        Class1 class1 = new Class1();
        public Borrow()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlCommand cmd = new SqlCommand();
        public void clearFields()
        {
            txtsearch.Text = string.Empty;
            txtbookID.Text = string.Empty;
            txtUserID.Text = string.Empty;
        }
        public void display()
        {
            // on intialise display books table
            cmd = new SqlCommand("select * from book where id not in ( select bookID from Borrow)", Program.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dtgDatalist.DataSource = ds.Tables[0];

            // make read only
            dtgDatalist.ReadOnly = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // display table
            display();

            // select both radio button by default
            optboth.Select();
        }

        private void DtgDatalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when not column header
            if (e.RowIndex != -1 && e.RowIndex != dtgDatalist.Rows.Count - 1)
            {
                dtgDatalist.Text = Convert.ToString(dtgDatalist.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void Btnissue_Click(object sender, EventArgs e)
        {
            // open connection
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();

            // variables
            int user_id = 0;
            int book_id = 0;

            bool preliminaryAcceptedState = true;

            // check credentials
            try
            {
                user_id = int.Parse(txtUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an integer.");
            preliminaryAcceptedState = false;
            }
            try
            {
                book_id = int.Parse(txtbookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an interger.");
              preliminaryAcceptedState = false;
            }


            // check two issues
            cmd = new SqlCommand("select * from member where ID = @user_id", Program.conn);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            int rows = ds.Tables[0].Rows.Count;

            if (rows >= 2)
            {
                MessageBox.Show("Cannot issue more books.\nA user can only issue 2 books.");
                preliminaryAcceptedState = false;
            }

            // check someone already issued
            cmd = new SqlCommand("select * from borrow where BookID = @book_id", Program.conn);
            cmd.Parameters.AddWithValue("@book_id", book_id);
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            int rows1 = ds1.Tables[0].Rows.Count;

            if (rows1 > 0)
            {
                MessageBox.Show("The book has already been borrowed by someone else.\nCannot issue book.");
                preliminaryAcceptedState = false;
            }

         //   issue entry in table
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("insert into borrow  values( @book_id, @user_id)", Program.conn);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    int result = cmd.ExecuteNonQuery();
                   // if (result == 1)
                  //  {
                        MessageBox.Show("Book successfully Borrowed!.");
                        display();
                        clearFields();
                   // }
                }
                catch
                {
                    MessageBox.Show("Please make sure that the the Book ID and User ID is valid.\nIf you still get an error Please report to admin");
                }

            }
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            if (optboth.Checked == true)
            {
                cmd = new SqlCommand("Select * from book where title like @searchQuery or author like @searchQuery", Program.conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + txtsearch.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dtgDatalist.DataSource = ds.Tables[0];
            }
            else if (opttitle.Checked == true)
            {
                cmd = new SqlCommand("select * from book where title like @searchQuery", Program.conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + txtsearch.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dtgDatalist.DataSource = ds.Tables[0];
            }
            else if (optauthor.Checked == true)
            {
                cmd = new SqlCommand("select  * from book where author like @searchQuery", Program.conn);
                cmd.Parameters.AddWithValue("@searchQuery", "%" + txtsearch.Text + "%");

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                dtgDatalist.DataSource = ds.Tables[0];
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can borrow 2 books!/n" +
                "if the book was borrowed you can't borrow!");
        }
    }
}
