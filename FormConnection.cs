using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            #region When Form load Read Connection from text
            string fileName = @".\server.con";
            string read = File.ReadAllText(
                               path: fileName
                               );
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = read;
            txtServerName.Text = builder.DataSource;
            txtDatabasename.Text = builder.InitialCatalog;
            txtUserName.Text = builder.UserID;
            txtPassword.Text = builder.Password;
            #endregion
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            #region Save Connection into File
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = txtServerName.Text.Trim();
            builder.InitialCatalog = txtDatabasename.Text.Trim();
            builder.UserID = txtDatabasename.Text.Trim();
            builder.Password = txtPassword.Text.Trim();

            string fileName = @".\server.con";
            File.WriteAllText(
                path: fileName,
                contents: builder.ConnectionString
                );
            #endregion

            if (Program.conn != null && Program.conn.State != ConnectionState.Closed)
                Program.conn.Close();
                Program.conn = new SqlConnection(builder.ConnectionString);
                Program.conn.Open();
                MessageBox.Show("Save");
            this.Close();
        }
    }
}
