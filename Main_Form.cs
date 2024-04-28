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
using LMS.Data;

namespace LMS
{
    public partial class Main_Form : Form
    {
        public Point MouseLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundRec(
           int LeftRec,
           int TopRec,
           int RightRec,
           int BottomRec,
           int Width,
           int Heigth
           );
        public Main_Form(string val)
        {
            InitializeComponent();
            lblname.Text = val;
        }

        

        public void Loadform(object Form)
        {
            btnbook.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, btnbook.Width, btnbook.Height, 20, 20));
            btnpurchase.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, btnpurchase.Width, btnpurchase.Height, 20, 20));
            Borrow.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, Borrow.Width, Borrow.Height, 20, 20));
            Return.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, Return.Width, Return.Height, 20, 20));
            Logout.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, Logout.Width, Logout.Height, 20, 20));
            User.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, User.Width, User.Height, 20, 20));
            if (this.Mainpanel.Controls.Count > 0)
            {
                this.Mainpanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;           
            f.Show();
        }

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            
            Loadform(new Purchase());
        }

        

        private void Book_Click(object sender, EventArgs e)
        {
            Loadform(new Book());
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Loadform(new Book());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout","Confirm",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                 LoginForm frm = new LoginForm();
            frm.Show();

            this.Close();
            }
           
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            Loadform(new Borrow());
        }

        private void Return_Click(object sender, EventArgs e)
        {
            Loadform(new Return());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            MouseLocation = new Point(-e.X, -e.Y);
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousepoint = Control.MousePosition;
                mousepoint.Offset(MouseLocation.X, MouseLocation.Y);
                Location = mousepoint;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Loadform(new User());   
        }
    }
}
