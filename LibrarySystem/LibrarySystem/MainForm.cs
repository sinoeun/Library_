using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit !", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            Form form = new BookInsert();
            form.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form fm = new Member();
            fm.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form fm = new Borrow();
            fm.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form form = new Return();
            form.Show();
            this.Hide();
        }
    }
}
