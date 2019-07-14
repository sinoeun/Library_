using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySystem
{
    class Class1
    {
        public IEnumerable<Control> Controls { get; private set; }
       public int GetAutoNumber(string table, string column)
       {
            string sql = $"SELECT MAX({column}) FROM {table}";
            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            try
            {
                object max = cmd.ExecuteScalar();
                if (max != DBNull.Value)
                    return Convert.ToInt32(max) + 1;
                else
                    return 1;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return 0;
       }

    }
}
