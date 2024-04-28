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
    class clsMember
    {
        public int MemberNo { get; set; }
        public string MemberName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Action { get; set; }

        clsMainDB objClsmain = new clsMainDB();

        public void SaveData()
        {
            try
            {
                objClsmain.DatabaseConn();
                SqlCommand sql = new SqlCommand("Insert_Member", objClsmain.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@MemberNo", MemberNo);
                sql.Parameters.AddWithValue("@MemberName", MemberName);
                sql.Parameters.AddWithValue("@Phone", Phone);
                sql.Parameters.AddWithValue("@Address", Address);               
                sql.Parameters.AddWithValue("@action", Action);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In Save Data");
            }
            finally
            {
                objClsmain.con.Close();
            }
        }
    }
}
