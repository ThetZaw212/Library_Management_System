using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LMS.Class
{
    internal class clsAdmin
    {
        public int AdminNO { get; set; }

        public string AdminName { get; set; }
        public string Password { get; set; }
        public int Action { get; set; }

        clsMainDB obj_MainDb = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_MainDb.DatabaseConn();
                SqlCommand Sql =new SqlCommand("Insert_Admin", obj_MainDb.con);
                Sql.CommandType = CommandType.StoredProcedure;
                Sql.Parameters.AddWithValue("@AdminNO", AdminNO);
                Sql.Parameters.AddWithValue("@AdminName", AdminName);
                Sql.Parameters.AddWithValue("@Password", Password);
                Sql.Parameters.AddWithValue("@action", Action);
                Sql.ExecuteNonQuery();
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.ToString(), "Error In Save Data.");
            }
            finally
            {
                obj_MainDb.con.Close();
            }
        }
    }
    
}
