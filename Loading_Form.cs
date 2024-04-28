using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width > 374)
            {
                timer1.Stop();
                this.Hide();
                LoginForm frm = new LoginForm();
                frm.ShowDialog();
                
            }
        }

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
    }
}
