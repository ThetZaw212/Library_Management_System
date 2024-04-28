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
    class clsBook
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int BQTY { get; set; }
        public int BPRICE { get; set; }
       
        public int ACTION { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DatabaseConn();
                SqlCommand sql = new SqlCommand("Insert_Book", obj_clsMainDB.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@BookID", BookID);
                sql.Parameters.AddWithValue("@BookName", BookName);
                sql.Parameters.AddWithValue("@BookQty", BQTY);
                sql.Parameters.AddWithValue("@BookPrice", BPRICE);
                
                sql.Parameters.AddWithValue("@action", ACTION);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In Save Data");
            }
            finally
            {
                obj_clsMainDB.con.Close();
            }
        }
    }
}
