using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LMS.Class
{
    class clsBorrowDetail
    {
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public int Action { get; set; }
        clsMainDB objclsmain = new clsMainDB();

        public void SaveData()
        {
            try
            {
                objclsmain.DatabaseConn();
                SqlCommand sql = new SqlCommand("Insert_BorrowDetail", objclsmain.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@BorrowID", BorrowID);
                sql.Parameters.AddWithValue("@BookID", BookID);              
                sql.Parameters.AddWithValue("@action", Action);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In Save Data");
            }
            finally
            {
                objclsmain.con.Close();
            }
        }
    }
}
