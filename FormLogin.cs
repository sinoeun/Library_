using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormConnection frmconn = new FormConnection();
            this.Hide();
            frmconn.ShowDialog();
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string sql = "";
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
