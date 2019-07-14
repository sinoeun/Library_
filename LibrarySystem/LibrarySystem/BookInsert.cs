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
    public partial class BookInsert : Form
    {   Class1 Class1 = new Class1();
        public BookInsert()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.; Database= Library; Integrated Security = SSPI;");
        SqlCommand cmd = new SqlCommand();

        public void ClearForm()
        {
            foreach (Control item in this.Controls)
            {
                switch (item)
                {
                    case TextBoxBase txt: txt.Clear(); break;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn;
            //SqlCommand command = new SqlCommand("insert into book (ID,Title, Author,Genre,Publisher,Pulishcate) Values (" + ID.Text + ",'" + txtTitle.Text + "','" + txtauthor.Text + "'," +
            //    "'" + txtdetail.Text + "','" + txtPublisher.Text + "','" + txtPubCate.Text + "')", conn);
            try
            {   
                if (String.IsNullOrWhiteSpace(txtauthor.Text) || String.IsNullOrWhiteSpace(txtPublisher.Text)|| String.IsNullOrWhiteSpace(txtgenre.Text))
                {
                    MessageBox.Show("Data do not null!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(); 
                    SqlCommand command = new SqlCommand("insert into book (ID,Title, Author,Genre,Publisher,Pulishcate) " +
                        "Values (" + ID.Text + ",'" + txtTitle.Text + "','" + txtauthor.Text + "'," +
                        "'" + txtgenre.Text + "','" + txtPublisher.Text + "','" + txtPubCate.Text + "')",conn);
                    conn.Close();
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("1 row(s) was insert !");
                    dataGridView1.Rows.Add(Convert.ToInt32(ID.Text), txtTitle.Text, txtauthor.Text, txtgenre.Text,
                                        txtPublisher.Text, txtPubCate.Text);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ID.Text = Class1.GetAutoNumber("Book", "ID").ToString();
        }
        private void Close_Click(object sender, EventArgs e)
        {
                Form form = new MainForm();
                form.Show();
                this.Hide();      
        }

        private void BookInsert_Load(object sender, EventArgs e)
        {
           conn.Open();
            ID.Text = Class1.GetAutoNumber("Book", "ID").ToString();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM book;";
            try
            {
                SqlDataReader customer = cmd.ExecuteReader();
                if (customer.HasRows == true)
                {
                    while (customer.Read() == true)
                    {
                        
                        int id = Convert.ToInt32(customer["ID"]);
                        string title = customer["Title"].ToString();
                        string Author = customer["Author"].ToString();
                        string Genre = customer["Genre"].ToString();
                        string Publisher = customer["Publisher"].ToString();
                        string Publishcate = customer["Pulishcate"].ToString();
                        dataGridView1.Rows.Add(id,title,Author,Genre,Publisher,Publishcate);
                    }
                }
                customer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(contextMenuStrip1.Tag);
            //get row
            DataGridViewRow row = null;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == id)
                {
                    row = dataGridView1.Rows[i];
                    break;
                }
            }
            ID.Text = row.Cells[0].Value.ToString();
            txtTitle.Text = row.Cells[1].Value.ToString();
            txtauthor.Text = row.Cells[2].Value.ToString();
            txtgenre.Text = row.Cells[3].Value.ToString();
            txtPublisher.Text = row.Cells[4].Value.ToString();
            txtPubCate.Text = row.Cells[5].Value.ToString();

            txtTitle.Focus();
            btnSave.Click -= BtnSave_Click;
            btnSave.Click += BtnSaveChange_Click;    
        }
        private void BtnSaveChange_Click(object sender, EventArgs e)
        {
           // Program.conn.Open();
            int id = Convert.ToInt32(ID.Text.Trim());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Book SET " +
                              $"Title = N'{txtTitle.Text.Trim()}'," +
                              $"Author = N'{txtauthor.Text.Trim()}'," +
                              $"Genre ='{txtgenre.Text.Trim()}'," +
                              $"Publisher = '{ txtPublisher.Text.Trim()}'," +
                              $"Pulishcate = N'{txtPubCate.Text.Trim()}'" +
                              $"WHERE ID = {id}";
            try
            {
                cmd.ExecuteNonQuery();            
                btnrefresh.PerformClick();
                MessageBox.Show("1 row was updated!");
               // conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //
            btnSave.Click -= BtnSaveChange_Click;
            btnSave.Click += BtnSave_Click;
            this.ClearForm();
            ID.Text = Class1.GetAutoNumber("Book", "ID").ToString();
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this record!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(contextMenuStrip1.Tag);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM book WHERE ID = " + id;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("1 row was deleted!");
                    btnrefresh.PerformClick();
                    ID.Text = Class1.GetAutoNumber("Book", "ID").ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM book;";
            try
            {
                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.HasRows == true)
                {
                    while (sqlData.Read() == true)
                    {
                        int id = Convert.ToInt32(sqlData["ID"]);
                        string title = sqlData["Title"].ToString();
                        string Author = sqlData["Author"].ToString();
                        string Genre = sqlData["Genre"].ToString();
                        string Publisher = sqlData["Publisher"].ToString();
                        string Publishcate = sqlData["Pulishcate"].ToString();
                        dataGridView1.Rows.Add(id, title, Author, Genre, Publisher, Publishcate);
                    }
                }
                sqlData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                contextMenuStrip1.Tag = ID;
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();        
            SqlCommand cmd = new SqlCommand();
            if (OptionBoth.Checked == true)
            {
                cmd = new SqlCommand("Select * from book where Genre like @searchQuery", Program.conn);
                cmd.Parameters.AddWithValue("@searchQuery", ""+ txtSearch.Text + "%");

                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.HasRows == true)
                {
                    while (sqlData.Read() == true)
                    {

                        int id = Convert.ToInt32(sqlData["ID"]);
                        string title = sqlData["Title"].ToString();
                        string Author = sqlData["Author"].ToString();
                        string Genre = sqlData["Genre"].ToString();
                        string Publisher = sqlData["Publisher"].ToString();
                        string Publishcate = sqlData["Pulishcate"].ToString();
                        dataGridView1.Rows.Add(id, title, Author, Genre, Publisher, Publishcate);
                    }
                }
                sqlData.Close();
            }
            else if (optionTitle.Checked == true)
            {
                cmd = new SqlCommand("select * from book where title like @searchQuery", Program.conn);
                cmd.Parameters.AddWithValue("@searchQuery", "" + txtSearch.Text + "%");

                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.HasRows == true)
                {
                    while (sqlData.Read() == true)
                    {

                        int id = Convert.ToInt32(sqlData["ID"]);
                        string title = sqlData["Title"].ToString();
                        string Author = sqlData["Author"].ToString();
                        string Genre = sqlData["Genre"].ToString();
                        string Publisher = sqlData["Publisher"].ToString();
                        string Publishcate = sqlData["Pulishcate"].ToString();
                        dataGridView1.Rows.Add(id, title, Author, Genre, Publisher, Publishcate);
                    }
                }
                sqlData.Close();
            }
            else if (optionAuthor.Checked == true)
            {
                cmd = new SqlCommand("select  * from book where author like @searchQuery", Program.conn);
                cmd.Parameters.AddWithValue("@searchQuery", "" + txtSearch.Text + "%");

                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.HasRows == true)
                {
                    while (sqlData.Read() == true)
                    {
                        int id = Convert.ToInt32(sqlData["ID"]);
                        string title = sqlData["Title"].ToString();
                        string Author = sqlData["Author"].ToString();
                        string Genre = sqlData["Genre"].ToString();
                        string Publisher = sqlData["Publisher"].ToString();
                        string Publishcate = sqlData["Pulishcate"].ToString();
                        dataGridView1.Rows.Add(id, title, Author, Genre, Publisher, Publishcate);
                    }
                }
                sqlData.Close();
            }                             
        }

        private void OptionBoth_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
