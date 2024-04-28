using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Class;

namespace LMS.Data
{
    public partial class Return : Form
    {
        string Spstring="";
        clsMainDB objMain = new clsMainDB();
        int _BorrowID = 0;
        clsBorrow objBorrow = new clsBorrow();
        clsBook objBook = new clsBook();
        DataTable Dt = new DataTable();
        DataTable DTBOOK = new DataTable();
        public Return()
        {
            InitializeComponent();
        }
        public void DeleteTable()
        {
            DTBOOK.Rows.Clear();
            dgvBookList.DataSource = DTBOOK;
        }

        private void Return_Load(object sender, EventArgs e)
        {
            Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", "Not Return", "0", "3");
            dgvReturn.DataSource = objMain.SelectData(Spstring);
        }

        private void dgvReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           _BorrowID = Convert.ToInt32(dgvReturn.CurrentRow.Cells["BorrowID"].Value.ToString());
           Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", _BorrowID, "0", "4");
           dgvBookList.DataSource = objMain.SelectData(Spstring);

            dgvBookList.Columns[0].Visible= false;
            dgvBookList.Columns[1].Width = (dgvBookList.Width / 100) * 50;
            dgvBookList.Columns[2].Visible = false;
            dgvBookList.Columns[3].Width = (dgvBookList.Width / 100) * 50;
            dgvBookList.Columns[4].Visible = false;
            dgvBookList.Columns[5].Visible = false;
            dgvBookList.Columns[6].Visible = false;
            dgvBookList.Columns[7].Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtFineAmount.Text.Trim().ToString()==string.Empty)
            {
                MessageBox.Show("Please Type fine Amount.");
                txtFineAmount.Focus();
            }
            
            else
            {
                objBorrow.FineAmount = Convert.ToInt32(txtFineAmount.Text);
                objBorrow.Status = "Return";
                objBorrow.BorrowID = _BorrowID;
                objBorrow.ACTION = 2;
                objBorrow.SaveData();

                _BorrowID = Convert.ToInt32(dgvReturn.CurrentRow.Cells["BorrowID"].Value.ToString());
                Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", _BorrowID, "0", "4");
                Dt = objMain.SelectData(Spstring);

                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    objBook.BookID = Convert.ToInt32(Dt.Rows[i]["BookID"].ToString());
                    objBook.ACTION = 3;
                    objBook.SaveData();
                }

                MessageBox.Show("Successfully Return", "Successfully", MessageBoxButtons.OK);
                Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", "Not Return", "0", "3");
                dgvReturn.DataSource = objMain.SelectData(Spstring);
                DeleteTable();
                txtFineAmount.Text = "";
            }
            
            
        }

        private void txtShowAll_TextChanged(object sender, EventArgs e)
        {
            Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", txtShowAll.Text.Trim().ToString(), "Not Return", "5");
            dgvReturn.DataSource = objMain.SelectData(Spstring);
        }
    }
}
