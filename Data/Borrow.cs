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
using LMS.Report;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace LMS.Data
{
    public partial class Borrow : Form
    {
        string Spstring = "";
        int _BQty = 0;
        clsMainDB objMain = new clsMainDB();
        DataTable DtBorrow = new DataTable();
        DataTable DT = new DataTable();
        clsBorrow obj_clsBorrow = new clsBorrow();
        clsBorrowDetail obj_clsBorrowDetail = new clsBorrowDetail();
        clsBook obj_clsBook = new clsBook();
        clsMember obj_clsMember = new clsMember();
        int Count = 0;
        int _BorrowID = 0;
        int DateDiff;
        public Borrow()
        {
            InitializeComponent();
        }
        private void CreateTable()
        {
            DtBorrow.Rows.Clear();
            DtBorrow.Columns.Clear();

            DtBorrow.Columns.Add("BookID");           
            DtBorrow.Columns.Add("BookName");
            DtBorrow.Columns.Add("MemberName");
            DtBorrow.Columns.Add("PhoneNumber");
            DtBorrow.Columns.Add("Address");
            DtBorrow.Columns.Add("BorrowDate");
            DtBorrow.Columns.Add("ReturnDate");
            DtBorrow.Columns.Add("Status");
            dgvBorrow.DataSource = DtBorrow;

            dgvBorrow.Columns[0].Width = (dgvBorrow.Width / 100) * 10;
            dgvBorrow.Columns[1].Width = (dgvBorrow.Width / 100) * 10;
            dgvBorrow.Columns[2].Width = (dgvBorrow.Width / 100) * 15;
            dgvBorrow.Columns[3].Width = (dgvBorrow.Width / 100) * 15;
            dgvBorrow.Columns[4].Width = (dgvBorrow.Width / 100) * 15;
            dgvBorrow.Columns[5].Width = (dgvBorrow.Width / 100) * 10;
            dgvBorrow.Columns[6].Width = (dgvBorrow.Width / 100) * 16;
           
        }
        private void Date()
        {
            Spstring = string.Format("Select_Borrow N'{0}',N'{1}',N'{2}'", dtpReturnDate.Text.Trim().ToString(), "0", "1");
            DT = objMain.SelectData(Spstring);
            DateDiff = Convert.ToInt32(DT.Rows[0]["No"]);
            if (DateDiff == 0)
            {
                MessageBox.Show("Please Check Return Date");
                dtpReturnDate.Text = DateTime.Now.ToShortDateString();
            }           
            else if (DateDiff >= 7)
            {
                MessageBox.Show("Please Check Date.");
                dtpReturnDate.Focus();
            }
            else if (DateDiff <= -7)
            {
                MessageBox.Show("Please Check Return Date");
                dtpReturnDate.Text = DateTime.Now.ToShortDateString();
            }
        }
        public void ShowData()
        {
            Spstring = string.Format("Select_Book N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            objMain.AddCombo(ref cboBk, Spstring, "BookName", "BookID");
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            CreateTable();
            ShowData();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            obj_clsMember.MemberName = txtName.Text.Trim().ToString();
            obj_clsMember.Phone = txtPhone.Text;
            obj_clsMember.Address = txtAddress.Text;
            obj_clsMember.Action = 0;
            obj_clsMember.SaveData();

            Spstring = string.Format("Select_Member N'{0}',N'{1}',N'{2}'", "0", "0", "2");
            DT = objMain.SelectData(Spstring);

            obj_clsBorrow.Ano = Program.AdminNo;
            obj_clsBorrow.MNO = Convert.ToInt32(DT.Rows[0]["MemberNo"].ToString());

            obj_clsBorrow.BorrowQty = Convert.ToInt32(BORROWQTY.Text);
            obj_clsBorrow.BorrowDate = dtpBorrowDate.Text;
            obj_clsBorrow.ReturnDate = dtpReturnDate.Text;
            obj_clsBorrow.FineAmount = 0;
            obj_clsBorrow.Status = "Not Return";
            obj_clsBorrow.ACTION = 0;
            obj_clsBorrow.SaveData();

            Spstring = string.Format("Select_Borrow N'{0}',N'{1}',N'{2}'", "0", "0", "2");
            DT = objMain.SelectData(Spstring);
            _BorrowID = Convert.ToInt32(DT.Rows[0]["BorrowID"].ToString());

            for (int i = 0; i < DtBorrow.Rows.Count; i++)
            {
                obj_clsBorrowDetail.BorrowID = _BorrowID;
                obj_clsBorrowDetail.BookID =Convert.ToInt32( DtBorrow.Rows[i]["BookID"].ToString());
                obj_clsBorrowDetail.Action = 0;
                obj_clsBorrowDetail.SaveData();

                
                obj_clsBook.BookID =  Convert.ToInt32(DtBorrow.Rows[i]["BookID"].ToString());
                obj_clsBook.ACTION = 4;
                obj_clsBook.SaveData();
            }


            if (MessageBox.Show("Successfully Save","Successfully",MessageBoxButtons.OK)==DialogResult.OK)
            {
                txtName.Clear();
                txtPhone.Clear();
                cboBk.SelectedIndex = 0;
                lblBID.Text = "";
                txtAddress.Text = "";
                BORROWQTY.Text = "";                
                ShowData();
            }
        }

        private void cboBk_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBID.Text = cboBk.SelectedValue.ToString();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int Ok = 0;
            if (txtName.Text ==string.Empty)
            {
                MessageBox.Show("Please Type Name.");
                txtName.Focus();
            }
            else if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Please Type phone Number.");
                txtPhone.Focus();
            }           
            else if(txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please Type Address.");
                txtAddress.Focus();
            }
            
            else
            {
                if (DtBorrow.Rows.Count > 0)
                {
                    DataRow[] Ar_Dr = DtBorrow.Select("BookID='" + cboBk.SelectedValue.ToString()+ "'");
                    Count = Ar_Dr.Length;
                    if (Count != 0)
                    {
                        MessageBox.Show("This Book Is Aready Borrowed.");
                        return;
                    }
                }
                if (DateDiff !=0 )
                {
                    lblFrom.Text = "Borrow From";
                    _BQty += 1;
                    BORROWQTY.Text = _BQty.ToString();
                    DataRow DR = DtBorrow.NewRow();
                    DR["BookID"] = lblBID.Text;
                    DR["BookName"] = cboBk.Text.ToString();
                    DR["MemberName"] = txtName.Text.ToString();
                    DR["PhoneNumber"] = txtPhone.Text.ToString();
                    DR["Address"] = txtAddress.Text.ToString();
                    DR["BorrowDate"] = dtpBorrowDate.Text;
                    DR["ReturnDate"] = dtpReturnDate.Text;
                    DR["Status"] = "Not Return";
                    DtBorrow.Rows.Add(DR);
                    dgvBorrow.DataSource = DtBorrow;
                    cboBk.SelectedValue = 0;
                    ShowData();
                }
                
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _BQty -= 1;
            BORROWQTY.Text = _BQty.ToString();

            if (DtBorrow.Rows.Count <= 0)
            {
                MessageBox.Show("There is no Data");
            }
            else if (dgvBorrow.CurrentRow.Cells["BookID"].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There is no Data");
            }
            else
            {
                DataRow[] Arr_DR = DtBorrow.Select("BookID='" + dgvBorrow.CurrentRow.Cells["BookID"].Value.ToString() + "'");
                DataRow DR = Arr_DR[0];
                DR.Delete();
                dgvBorrow.DataSource = DtBorrow;                
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            lblFrom.Text = "Borrowed Books";
            Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", "0", "0", "1");
            dgvBorrow.DataSource = objMain.SelectData(Spstring);
        }

        private void txtSearchWith_TextChanged(object sender, EventArgs e)
        {
            Spstring = string.Format("Select_BorrowDetail N'{0}',N'{1}',N'{2}'", txtShowAll.Text.Trim().ToString(), "0", "2");
            dgvBorrow.DataSource = objMain.SelectData(Spstring);
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            Date();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataTable Dt =new DataTable();
            Spstring = string.Format("Select_BorrowReport N'{0}',N'{1}',N'{2}'", "0", "0", "1");               
            Dt = objMain.SelectData(Spstring);
            Report_form frm = new Report_form();
            crpt_Borrow crpt = new crpt_Borrow();
            crpt.SetDataSource(Dt);
            frm.crystalReportViewer1.ReportSource = crpt;
            frm.ShowDialog();           
        }
    }
}
