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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
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
            // BorrowList
            cmd = new SqlCommand("select borrow.ID,borrow.BookID, Book.Title, Member.ID as [Member ID],Member.[Name] " +
                "from borrow inner join Book on (Book.ID = borrow.BookID) inner join Member on Member.ID = borrow.MemberID;", Program.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dtgDatalist.DataSource = ds.Tables[0];

            // make read only
            dtgDatalist.ReadOnly = true;
        }
        private void Btnsearch_Click_1(object sender, EventArgs e)
        {
            dtgDatalist.Rows.Clear();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                if (txtsearch.Text == string.Empty)
                {
                    display();
                }
                else
                {
                    cmd = new SqlCommand("select borrow.ID,borrow.BookID, Book.Title, Member.ID as [Member ID],Member.[Name] " +
                "from borrow inner join Book on (Book.ID = borrow.BookID) inner join Member on Member.ID = borrow.MemberID where Title like @searchQuery or Member.ID like @searchQuery", Program.conn);
                    cmd.Parameters.AddWithValue("@searchQuery", "" + txtsearch.Text + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows == true)
                    {
                        while (reader.Read() == true)
                        {
                            int id = Convert.ToInt32(reader["ID"]);
                            string book = reader["BookID"].ToString();
                            string Title = reader["Title"].ToString();
                            string Member = reader["Member ID"].ToString();
                            string Name = reader["Name"].ToString();
                            dtgDatalist.Rows.Add(id, book, Title, Member, Name);
                        }
                        reader.Close();
                    }
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DtgDatalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Btnissue_Click(object sender, EventArgs e)
        {
            // open connection
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();

            // variables
            int book_id = 0;
            int user_id = 0;
            bool preliminaryAcceptedState = true;
            // check values
            try
            {
                book_id = int.Parse(txtbookID.Text);
            }
            catch
            {
                MessageBox.Show("Book ID should be an integer.");
                preliminaryAcceptedState = false;
            }
            try
            {
                user_id = int.Parse(txtUserID.Text);
            }
            catch
            {
                MessageBox.Show("User ID should be an interger.");
                preliminaryAcceptedState = false;
            }
            // delete record from the db
            if (preliminaryAcceptedState == true)
            {
                try
                {
                    cmd = new SqlCommand("delete from borrow where id = @book_id and id = @user_id",Program.conn);
                    cmd.Parameters.AddWithValue("@book_id", book_id);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Please enter a valid User ID and Book ID.\nInvalid Input.");
                    }
                    if (result == 1)
                    {
                        MessageBox.Show("Book successfully returned.");
                        display();
                    }
                }
                catch
                {
                    MessageBox.Show("Internal system error.\nPlease contact the developer.");
                }
            }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            dtgDatalist.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.conn;
            cmd.CommandText = "select borrow.ID,borrow.BookID, Book.Title, Member.ID as [Member ID],Member.[Name] " +
                "from borrow inner join Book on (Book.ID = borrow.BookID) inner join Member on Member.ID = borrow.MemberID;";
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read() == true)
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        string book = reader["BookID"].ToString();
                        string Title = reader["Title"].ToString();
                        string Member = reader["Member ID"].ToString();
                        string Name = reader["Name"].ToString();
                        dtgDatalist.Rows.Add(id, book, Title, Member, Name);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
