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
    public partial class Purchase : Form
    {
        DataTable DTPurchase =  new DataTable();
        clsMainDB objmain = new clsMainDB();
        clsPurchase objPurchase = new clsPurchase();
        clsBook objBook = new clsBook();
        clsPurchaseDetail objPurchaseDetail = new clsPurchaseDetail();
        DataTable Dt = new DataTable();
        string SpString = "";
        int _purchaseID = 0;
        int count = 0;

        public Purchase()
        {
            InitializeComponent();
        }
        public void CreateTable()
        {
            DTPurchase.Rows.Clear();
            DTPurchase.Columns.Clear();
            DTPurchase.Columns.Add("BookID");
            DTPurchase.Columns.Add("BookName");
            DTPurchase.Columns.Add("BookQty");
            DTPurchase.Columns.Add("BookPrice");
            DTPurchase.Columns.Add("Total");
            dgvPurchase.DataSource = DTPurchase;

            dgvPurchase.Columns[0].Width = (dgvPurchase.Width / 100) * 20;
            dgvPurchase.Columns[1].Width = (dgvPurchase.Width / 100) * 30;
            dgvPurchase.Columns[2].Width = (dgvPurchase.Width / 100) * 10;
            dgvPurchase.Columns[3].Width = (dgvPurchase.Width / 100) * 15;
            dgvPurchase.Columns[4].Width = (dgvPurchase.Width / 100) * 20;
          
        }
        private void CalculateToatal()
        {
            int Total = 0;
            if (DTPurchase.Rows.Count > 0)
            {
                foreach (DataRow  DR in DTPurchase.Rows)
                {
                    Total += Convert.ToInt32(DR["Total"]);                    
                }
                lblTotalamount.Text = Total.ToString();
            }
        }

        public void ShowData()
        {
            SpString = string.Format("Select_Book N'{0}',N'{1}',N'{2}'", "0", "0", "0");
            objmain.SelectData(SpString);
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            CreateTable();
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ok=0;
            if (txtBookID.Text==string.Empty)
            {
                MessageBox.Show("Please type BookID.");
                txtBookID.Focus();
            }
            else if (int.TryParse(txtBookID.Text, out ok) == false)
            {
                MessageBox.Show("Please type Number.");
                txtBookID.Focus();
                txtBookID.SelectAll();
            }
            else if (txtBookName.Text==string.Empty)
            {
                MessageBox.Show("Please type BookName.");
                txtBookName.Focus();
            }
            else if (txtBookQty.Text==string.Empty)
            {
                MessageBox.Show("Please type Qty.");
                txtBookQty.Focus();
            }
            else if (int.TryParse(txtBookQty.Text,out ok)==false)
            {
                MessageBox.Show("Qty Should Be Number.");
                txtBookQty.Focus();
                txtBookQty.SelectAll();
            }
            else if (txtBookPrice.Text == string.Empty)
            {
                MessageBox.Show("Please type Price.");
                txtBookPrice.Focus();
            }
            else if (int.TryParse(txtBookPrice.Text, out ok) == false)
            {
                MessageBox.Show("Please type Number.");
                txtBookPrice.Focus();
                txtBookPrice.SelectAll();
            }
            else if (Convert.ToInt32(txtBookPrice.Text.Trim().ToString()) <1000 || Convert.ToInt32(txtBookPrice.Text.Trim().ToString())>10000000)
            {
                MessageBox.Show("Price Should Be Between 1 Thousand And 100-Lakh");
                txtBookPrice.SelectAll();
                txtBookPrice.Focus();
            }
            else
            {
                if (DTPurchase.Rows.Count > 0)
                {
                    DataRow[] Ar_Dr = DTPurchase.Select("BookName='"+txtBookName.Text.ToString()+"'");
                    count = Ar_Dr.Length;
                    if (count != 0)
                    {
                        MessageBox.Show("This Book Is Aready Exit.");
                        return;
                    }
                }
                DataRow DR = DTPurchase.NewRow();
                DR["BookID"] = txtBookID.Text;
                DR["BookName"] = txtBookName.Text;
                DR["BookQty"] = txtBookQty.Text;
                DR["BookPrice"] = txtBookPrice.Text;
                DR["Total"] = Convert.ToInt32(txtBookQty.Text) * Convert.ToInt32(txtBookPrice.Text);
                DTPurchase.Rows.Add(DR);
                dgvPurchase.DataSource = DTPurchase;
                txtBookID.Clear();
                txtBookName.Clear();
                txtBookPrice.Clear();
                txtBookQty.Clear();
                lblTotalamount.Text = "";
                CalculateToatal();
            }
          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (DTPurchase.Rows.Count <= 0)
            {
                MessageBox.Show("There is no Data");
            }
            else if (dgvPurchase.CurrentRow.Cells["BookID"].Value.ToString()==string.Empty)
            {
                MessageBox.Show("There is no Data");
            }
            else
            {
                DataRow[] Arr_DR = DTPurchase.Select("BookID='" + dgvPurchase.CurrentRow.Cells["BookID"].Value.ToString() + "'");
                DataRow DR = Arr_DR[0];
                DR.Delete();
                dgvPurchase.DataSource = DTPurchase;
                CalculateToatal();
            }
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            objPurchase.PDate = dtpDate.Text;
            objPurchase.TotalAmount = Convert.ToInt32(lblTotalamount.Text);
            objPurchase.AdminNO = Program.AdminNo;
            objPurchase.Action = 0;
            objPurchase.SaveData();

            SpString = string.Format("Select_Puchase N'{0}',N'{1}',N'{2}'", "0", "0", "1");
            Dt = objmain.SelectData(SpString);
            _purchaseID = Convert.ToInt32(Dt.Rows[0]["PurchaseID"].ToString());

            for (int i = 0; i < DTPurchase.Rows.Count; i++)
            {
                objPurchaseDetail.PID = _purchaseID;
                objPurchaseDetail.BOOKID = DTPurchase.Rows[i]["BookID"].ToString();
                objPurchaseDetail.PQTY = Convert.ToInt32(DTPurchase.Rows[i]["BookQty"].ToString());
                objPurchaseDetail.PPRICE = Convert.ToInt32(DTPurchase.Rows[i]["BookPrice"].ToString());
                objPurchaseDetail.ACTION = 0;
                objPurchaseDetail.SaveData();
                int _BookID=Convert.ToInt32(DTPurchase.Rows[i]["BookID"].ToString());
                objBook.BookID = Convert.ToInt32(DTPurchase.Rows[i]["BookID"].ToString());
                objBook.BQTY = Convert.ToInt32(DTPurchase.Rows[i]["BookQty"].ToString());
                objBook.BPRICE = Convert.ToInt32(DTPurchase.Rows[i]["BookPrice"].ToString());
                SpString = string.Format("Select_Book N'{0}',N'{1}',N'{2}'", _BookID, "0", "7");
                Dt = objmain.SelectData(SpString);
                if (Dt.Rows.Count > 0)
                {                                       
                     objBook.ACTION = 5;
                     objBook.SaveData();
                                      
                }
                else
                {
                    objBook.BookName = DTPurchase.Rows[i]["BookName"].ToString();
                    objBook.ACTION = 0;
                    objBook.SaveData();
                }
            }

            if ( MessageBox.Show("SuccessFully Purchase.", "Successfully", MessageBoxButtons.OK)==DialogResult.OK)
            {
                DTPurchase.Rows.Clear();
                dgvPurchase.Focus();
                txtBookID.Clear();
                txtBookName.Clear();
                txtBookPrice.Clear();
                txtBookQty.Clear();
                lblTotalamount.Text = "";
            } 
           
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            SpString = string.Format("Select_PurchaseDetail N'{0}',N'{1}',N'{2}'", "0", "0", "1");
            dgvPurchase.DataSource = objmain.SelectData(SpString);
        }

        private void txtShowAll_TextChanged(object sender, EventArgs e)
        {
            SpString = string.Format("Select_PurchaseDetail N'{0}',N'{1}',N'{2}'",txtShowAll.Text.Trim().ToString(), "0", "2");
            dgvPurchase.DataSource = objmain.SelectData(SpString);
        }
    }
}
