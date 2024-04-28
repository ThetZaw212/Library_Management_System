using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS.Class;

namespace LMS.Data
{
    public partial class Book : Form
    {
        DataTable Dt = new DataTable();
        clsBook objBook = new clsBook();
        clsMainDB objMain = new clsMainDB();
        int AV = 0;
        string SpString = "";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundRec(
            int LeftRec,
            int TopRec,
            int RightRec,
            int BottomRec,
            int Width,
            int Heigth
            );
        public Book()
        {
            InitializeComponent();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            AVPanel.Region = Region.FromHrgn(RoundRec(0, 0, AVPanel.Width, AVPanel.Height, 20, 20));
            UserPanel.Region = Region.FromHrgn(RoundRec(0, 0, UserPanel.Width, UserPanel.Height, 20, 20));
            AVPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            UserPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            SpString = String.Format("Select_Book N'{0}',N'{1}',N'{2}'", "0", "0", "8");
            Dt = objMain.SelectData(SpString);
            AV = Convert.ToInt32(Dt.Rows[0]["BookID"].ToString());
            lblBook.Text = AV.ToString();


            SpString = String.Format("Select_Admin N'{0}',N'{1}',N'{2}'", "0", "0", "1");
            Dt = objMain.SelectData(SpString);
            AV = Convert.ToInt32(Dt.Rows[0]["AdminNo"].ToString());
            lblUser.Text = AV.ToString();
        }
    }
}
