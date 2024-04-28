namespace LMS
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.Sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.LightGray;
            this.Sidepanel.Controls.Add(this.User);
            this.Sidepanel.Controls.Add(this.btnbook);
            this.Sidepanel.Controls.Add(this.label3);
            this.Sidepanel.Controls.Add(this.lblname);
            this.Sidepanel.Controls.Add(this.pictureBox5);
            this.Sidepanel.Controls.Add(this.Logout);
            this.Sidepanel.Controls.Add(this.Return);
            this.Sidepanel.Controls.Add(this.Borrow);
            this.Sidepanel.Controls.Add(this.btnpurchase);
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidepanel.Location = new System.Drawing.Point(0, 0);
            this.Sidepanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(182, 598);
            this.Sidepanel.TabIndex = 0;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.DarkGray;
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Black;
            this.User.Image = ((System.Drawing.Image)(resources.GetObject("User.Image")));
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(0, 540);
            this.User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(182, 45);
            this.User.TabIndex = 16;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = false;
            this.User.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.DarkGray;
            this.btnbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbook.FlatAppearance.BorderSize = 0;
            this.btnbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbook.ForeColor = System.Drawing.Color.Black;
            this.btnbook.Image = ((System.Drawing.Image)(resources.GetObject("btnbook.Image")));
            this.btnbook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbook.Location = new System.Drawing.Point(0, 190);
            this.btnbook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(182, 45);
            this.btnbook.TabIndex = 15;
            this.btnbook.Text = "Book";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.Book_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Welcome Admin";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(6, 95);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(168, 28);
            this.lblname.TabIndex = 11;
            this.lblname.Text = "Admin Name";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 34);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.DarkGray;
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(0, 478);
            this.Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(182, 45);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.DarkGray;
            this.Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return.FlatAppearance.BorderSize = 0;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.Color.Black;
            this.Return.Image = ((System.Drawing.Image)(resources.GetObject("Return.Image")));
            this.Return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Return.Location = new System.Drawing.Point(0, 383);
            this.Return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(182, 45);
            this.Return.TabIndex = 6;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.DarkGray;
            this.Borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Borrow.FlatAppearance.BorderSize = 0;
            this.Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow.ForeColor = System.Drawing.Color.Black;
            this.Borrow.Image = ((System.Drawing.Image)(resources.GetObject("Borrow.Image")));
            this.Borrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Borrow.Location = new System.Drawing.Point(-3, 315);
            this.Borrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(185, 45);
            this.Borrow.TabIndex = 4;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // btnpurchase
            // 
            this.btnpurchase.BackColor = System.Drawing.Color.DarkGray;
            this.btnpurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpurchase.FlatAppearance.BorderSize = 0;
            this.btnpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpurchase.ForeColor = System.Drawing.Color.Black;
            this.btnpurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnpurchase.Image")));
            this.btnpurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpurchase.Location = new System.Drawing.Point(0, 249);
            this.btnpurchase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(182, 45);
            this.btnpurchase.TabIndex = 2;
            this.btnpurchase.Text = "  Purchase";
            this.btnpurchase.UseVisualStyleBackColor = false;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.LightGray;
            this.Headerpanel.Controls.Add(this.button4);
            this.Headerpanel.Controls.Add(this.label1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(182, 0);
            this.Headerpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(987, 34);
            this.Headerpanel.TabIndex = 1;
            this.Headerpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Headerpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(931, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "LIBRARY DEPERMENT";
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(182, 34);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(987, 564);
            this.Mainpanel.TabIndex = 2;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1169, 598);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.Sidepanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Sidepanel.ResumeLayout(false);
            this.Sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Headerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button User;
    }
}

