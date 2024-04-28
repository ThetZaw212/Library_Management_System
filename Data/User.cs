using LMS.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LMS.Data
{
    public partial class User : Form
    {
        string SpString = "";
        clsMainDB obj_main= new clsMainDB();
        SignUp_Form frm = new SignUp_Form();
        clsAdmin obj_Admin = new clsAdmin();    
        public User()
        {
            InitializeComponent();
        }
        private void ShowData()
        {
            SpString = string.Format("Select_Admin N'{0}',N'{1}',N'{2}'", "0", "0", "2");
            dgvAdmin.DataSource = obj_main.SelectData(SpString);
        }



        private void ShowEntry()
        {
            if (dgvAdmin.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There Is No Data");
            }
            else
            {
                frm.lblSignUp.Text = "Edit Form";
                frm.SignUp.Text = "Edit";
                frm.LiLabel.Visible = false;
                frm.AdminNo = Convert.ToInt32(dgvAdmin.CurrentRow.Cells["AdminNo"].Value.ToString());
                frm.txtName.Text = dgvAdmin.CurrentRow.Cells["AdminName"].Value.ToString();
                frm.txtPassword.Text = dgvAdmin.CurrentRow.Cells["Password"].Value.ToString();
                frm.txtCoPass.Text = dgvAdmin.CurrentRow.Cells["Password"].Value.ToString();
                frm._Edit = true;
                frm.ShowDialog();
                ShowData();
            }
        }
        private void User_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void dgvAdmin_DoubleClick(object sender, EventArgs e)
        {
            ShowEntry();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdmin.CurrentRow.Cells[0].Value.ToString() == string.Empty)
            {
                MessageBox.Show("There Is No Data");
            }
            else
            {
                if (MessageBox.Show("Are You Want To Delete?","Comfirm",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    obj_Admin.AdminNO = Convert.ToInt32(dgvAdmin.CurrentRow.Cells["AdminNo"].Value.ToString());
                    obj_Admin.Action = 2;
                    obj_Admin.SaveData ();
                    MessageBox.Show("Successfully Delete.");
                    ShowData();
                }
            }
        }
    }
}
