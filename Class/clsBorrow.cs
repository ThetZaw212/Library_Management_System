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
    class clsBorrow
    {
        public int BorrowID { get; set; }
        public int MNO { get; set; }
        public int Ano { get; set; }
        public int BorrowQty { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public int FineAmount { get; set; }
        public string Status { get; set; }
        public int ACTION { get; set; }

        clsMainDB obj_clsMainDB = new clsMainDB();

        public void SaveData()
        {
            try
            {
                obj_clsMainDB.DatabaseConn();
                SqlCommand sql = new SqlCommand("Insert_Borrow", obj_clsMainDB.con);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@BorrowID", BorrowID);                
                sql.Parameters.AddWithValue("@MemberNo", MNO);
                sql.Parameters.AddWithValue("@AdminNo", Ano);
                sql.Parameters.AddWithValue("@BorrowQty", BorrowQty);
                sql.Parameters.AddWithValue("@BorrowDate", BorrowDate);
                sql.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                sql.Parameters.AddWithValue("@FineAmount", FineAmount);
                sql.Parameters.AddWithValue("@Status", Status);

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
