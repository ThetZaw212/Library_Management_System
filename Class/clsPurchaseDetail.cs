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
    class clsPurchaseDetail
    {
        public int PID { get; set; }
        public string BOOKID { get; set; }
        public int PQTY { get; set; }
        public int PPRICE { get; set; }
        public int ACTION { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();
        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DatabaseConn();
                SqlCommand sql = new SqlCommand("Insert_PurchaseDetail", obj_clsMainDB.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@PurchaseID", PID);
                sql.Parameters.AddWithValue("@BookID", BOOKID);
                sql.Parameters.AddWithValue("@PurchaseQty", PQTY);
                sql.Parameters.AddWithValue("@PurchasePrice", PPRICE);
                sql.Parameters.AddWithValue("@action", ACTION);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error in Save Data");
            }
            finally
            {
                obj_clsMainDB.con.Close();
            }
        }
    }
}
