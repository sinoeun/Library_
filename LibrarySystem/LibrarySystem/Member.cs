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
    public partial class Member : Form
    {
        Class1 class1 = new Class1();
        public Member()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=.; Database= Library; Integrated Security = SSPI;");
        private void Label7_Click(object sender, EventArgs e)
        {

        }
        public void ClearForm()
        {
            foreach (Control item in this.Controls)
            {
                switch (item)
                {
                    case TextBoxBase txt: txt.Clear(); break;
                }
            }
            cboGender.SelectedIndex = -1;
        }
      
        private void Btnsave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (String.IsNullOrWhiteSpace(txtphone.Text)|| String.IsNullOrWhiteSpace(txtAdress.Text))
                {
                    MessageBox.Show("Data do not null!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand command = new SqlCommand("insert into Member Values(" + txtid.Text + ",'" + txtName.Text + "'," +
                        "'" + cboGender.Text + "','" + txtphone.Text + "','" + txtemail.Text + "','" + txtAdress.Text + "')",conn);
                    //conn.Open();
                    SqlDataReader dtareader = command.ExecuteReader();
                    //conn.Close();
                    MessageBox.Show("1 row(s) was insert !");
                    dataGridView1.Rows.Add(Convert.ToInt32(txtid.Text), txtName.Text, cboGender.Text, txtphone.Text,
                                        txtphone.Text, txtemail.Text);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtid.Text = class1.GetAutoNumber("member", "ID").ToString();
            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }
        private void Member_Load(object sender, EventArgs e)
        {
            //
            conn.Open();
            txtid.Text = class1.GetAutoNumber("Member", "Id").ToString();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM Member;";
            try
            {
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.HasRows == true)
                {
                    while (sqlDataReader.Read() == true)
                    {
                        int id = Convert.ToInt32(sqlDataReader["ID"]);
                        string name = sqlDataReader["Name"].ToString();
                        string gender = sqlDataReader["Gender"].ToString();
                        string Phone = sqlDataReader["Phone"].ToString();
                        string Email = sqlDataReader["Email"].ToString();
                        string Address = sqlDataReader["Address"].ToString();
                        dataGridView1.Rows.Add(id, name, gender, Phone, Email, Address);
                    }
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
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
            txtid.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            cboGender.SelectedItem = row.Cells[2].Value.ToString();
            txtphone.Text = row.Cells[3].Value.ToString();
            txtemail.Text = row.Cells[4].Value.ToString();
            txtAdress.Text = row.Cells[5].Value.ToString();

            //txtid.Text = row.Cells[0].Value.ToString();
            //txtName.Text = row.Cells[1].Value.ToString();
            //cboGender.Text = row.Cells[2].Value.ToString();
            //txtphone.Text = row.Cells[3].Value.ToString();
            //txtemail.Text = row.Cells[4].Value.ToString();
            //txtAdress.Text = row.Cells[5].Value.ToString();

            txtName.Focus();
            btnsave.Click -= Btnsave_Click;
            btnsave.Click += btnsavechange_Click;
        }

        private void btnsavechange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label.Text.Trim());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Book SET " +
                              $"Name = N'{txtName.Text.Trim()}'," +
                              $"Gender = N'{cboGender.Text.Trim()}'," +
                              $"Phone ='{txtphone.Text.Trim()}'," +
                              $"Email = '{ txtemail.Text.Trim()}'," +
                              $"Address = N'{txtAdress.Text.Trim()}'" +
                              $"WHERE ID = {id}";
            try
            {
                cmd.ExecuteNonQuery();
                btnLaod.PerformClick();
                MessageBox.Show("1 row was updated!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //
            btnsave.Click -= btnsavechange_Click;
            btnsave.Click += Btnsave_Click1;  
        }

        private void Btnsave_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLaod_Click(object sender, EventArgs e)
        {
           // conn.Open();
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM member;";
            try
            {
                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.HasRows == true)
                {
                    while (sqlData.Read() == true)
                    {
                        int id = Convert.ToInt32(sqlData["ID"]);
                        string name = sqlData["Name"].ToString();
                        string gender = sqlData["Gender"].ToString();
                        string phone = sqlData["Phone"].ToString();
                        string email = sqlData["Email"].ToString();
                        string address = sqlData["Address"].ToString();
                        dataGridView1.Rows.Add(id, name, gender, phone, email, address);
                    }
                }
                sqlData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearxh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"SELECT * FROM member WHERE name LIKE '{txtSearch.Text.Trim()}%', or ID like'{txtSearch.Text.Trim()}%';";
            try
            {
                SqlDataReader sqlData = cmd.ExecuteReader();
                if (sqlData.HasRows == true)
                {
                    while (sqlData.Read() == true)
                    {
                        int id = Convert.ToInt32(sqlData["ID"]);
                        string name = sqlData["Name"].ToString();
                        string Gender = sqlData["Gender"].ToString();
                        string Phone = sqlData["Phone"].ToString();
                        string Email = sqlData["Email"].ToString();
                        string Address = sqlData["Address"].ToString();
                        dataGridView1.Rows.Add(id, name, Gender, Phone, Email, Address);
                    }
                }
                sqlData.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this record!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(contextMenuStrip1.Tag);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM MEMBER WHERE ID = " + id;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("1 row was deleted!");
                    btnLaod.PerformClick();
                    txtid.Text =class1.GetAutoNumber("Member", "ID").ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //DialogResult dialogResult = MessageBox.Show("Do you want to delete this record!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    int id = Convert.ToInt32(contextMenuStrip1.Tag);
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandText = "DELETE FROM member WHERE ID = " + id;
            //    try
            //    {
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("1 row was deleted!");
            //        btnLaod.PerformClick();
            //        ClearForm();
            //        txtid.Text = class1.GetAutoNumber("member", "ID").ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }

            //}
        }
    }
}
