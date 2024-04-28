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
    class clsPurchase
    {
        public int PID { get; set; }
        public string PDate { get; set; }
        public int AdminNO { get; set; }
        public int TotalAmount { get; set; }
        public int Action { get; set; }

        clsMainDB objMain = new clsMainDB();

        public void SaveData()
        {
            try
            {
                objMain.DatabaseConn();
                SqlCommand sql = new SqlCommand("Insert_Purchase", objMain.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@PurchaseID", PID);
                sql.Parameters.AddWithValue("@PurchaseDate", PDate);
                sql.Parameters.AddWithValue("@AdminNo", AdminNO);
                sql.Parameters.AddWithValue("@TotalAmount", TotalAmount);              
                sql.Parameters.AddWithValue("@action", Action);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in Save Data");
            }
            finally
            {
                objMain.con.Close();
            }
        }

    }
}
