using LMS.Class;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS
{
    public partial class SignUp_Form : Form
    {
        clsAdmin obj_clsAdmin= new clsAdmin();
        clsMainDB Obj_Main = new clsMainDB();
        DataTable DT = new DataTable();
        public bool _Edit = false;
        string SpString = "";
        public int AdminNo = 0;
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundRec(
           int LeftRec,
           int TopRec,
           int RightRec,
           int BottomRec,
           int Width,
           int Heigth
           );
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            MainPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            MainPanel.Region = Region.FromHrgn(RoundRec(0, 0, MainPanel.Width, MainPanel.Height, 20, 20));            
        }

        private void LiLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().ToString() == string.Empty)
            {
                MessageBox.Show("Please Type UserName");
                txtName.Focus();
            }
            else if (txtPassword.Text.Trim().ToString() ==string.Empty)
            {
                MessageBox.Show("Please Type Password");
                txtPassword.Focus();
            }
            else if (txtCoPass.Text.Trim().ToString()==string.Empty)
            {
                MessageBox.Show("Please Type Comfirm Password");
                txtCoPass.Focus();
            }
            else if (txtPassword.Text.Trim().ToString() != txtCoPass.Text.Trim().ToString())
            {
                MessageBox.Show("Password and Comfirm Password Ard Should Be Same");
                txtCoPass.SelectAll();
                txtCoPass.Focus();
            }
            else
            {
                SpString = string.Format("Select_Admin N'{0}',N'{1}',N'{2}'", txtName.Text.Trim().ToString(), txtPassword.Text.Trim().ToString(), "0");
                DT = Obj_Main.SelectData(SpString);
                if (DT.Rows.Count > 0 && AdminNo != Convert.ToInt32(DT.Rows[0]["AdminNo"].ToString()))
                {
                    MessageBox.Show("This Admin Is Already Exist.");
                    txtName.Focus ();
                    txtPassword.Focus ();
                }
                else
                {
                    obj_clsAdmin.AdminName = txtName.Text;
                    obj_clsAdmin.Password = txtPassword.Text;
                    if (_Edit)
                    {
                        obj_clsAdmin.AdminNO = AdminNo;
                        obj_clsAdmin.Action = 1;
                        obj_clsAdmin.SaveData();
                        MessageBox.Show("Successfully Edit","Successfully",MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        
                        obj_clsAdmin.Action = 0;
                        obj_clsAdmin.SaveData();
                        MessageBox.Show("Successfully SignUp", "Successfully", MessageBoxButtons.OK);
                        string user = txtName.Text;
                        Main_Form frm = new Main_Form(char.ToUpper(user[0]) + user.Substring(1));
                        this.Hide();
                        frm.ShowDialog();                      
                    }
                }
            }
        }

        private void Ps_CheckedChanged(object sender, EventArgs e)
        {
            if (Ps.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtCoPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtCoPass.UseSystemPasswordChar = true;
            }
        }
    }
}
