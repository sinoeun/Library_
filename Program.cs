using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection("");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Catch Connection in TextFile to Use
            string fileName = @".\server.con";
            if (File.Exists(fileName) == true)
            {
                try
                {
                    string read = File.ReadAllText(
                                       path: fileName
                                       );
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.ConnectionString = read;
                    conn = new SqlConnection(builder.ConnectionString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            #endregion

            #region Open Connection
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XtraForm2());

            #region Close Connection
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
    }
}
