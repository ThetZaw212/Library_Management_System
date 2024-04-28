using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Data;
using LMS.Class;
using System.CodeDom;

namespace LMS
{
    public partial class LoginForm : Form
    {
        public Point MouseLocation;
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ps_CheckedChanged(object sender, EventArgs e)
        {
            if (Ps.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
                clsMainDB objclsmain = new clsMainDB();
                DataTable DT = new DataTable();
                string UserName = "";
                string Password = "";

            Start:
                if (txtusername.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please Type UserName.");
                    txtusername.Focus();
                    return;
                }
                UserName = txtusername.Text;

                if (txtpassword.Text.Trim().ToString() == string.Empty)
                {
                    MessageBox.Show("Please Type Password.");
                    txtpassword.Focus();
                    return;
                }
                Password = txtpassword.Text;
                string SpString = string.Format("Select_Admin N'{0}',N'{1}',N'{2}'", txtusername.Text.Trim().ToString(), txtpassword.Text.Trim().ToString(), "0");
                DT=objclsmain.SelectData(SpString);
                if (DT.Rows.Count > 0)
                {
                    this.Hide();
                    Program.AdminNo = Convert.ToInt32(DT.Rows[0]["AdminNo"].ToString());
                    string user = txtusername.Text;
                    Main_Form frm = new Main_Form(char.ToUpper(user[0]) + user.Substring(1));
                    frm.ShowDialog();
                }
                else
                {
                MessageBox.Show("Invalid UserName OR Password.");
                }                                              
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtusername.Focus ();
        }

      

        private void mouse_down(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X,-e.Y);    
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousepoint = Control.MousePosition;
                mousepoint.Offset(MouseLocation.X,MouseLocation.Y);
                Location = mousepoint;
            }
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp_Form frm = new SignUp_Form();
            frm.ShowDialog();
        }
    }
}
