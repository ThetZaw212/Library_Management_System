namespace LMS
{
    partial class SignUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp_Form));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Ps = new System.Windows.Forms.CheckBox();
            this.LiLabel = new System.Windows.Forms.LinkLabel();
            this.SignUp = new System.Windows.Forms.Button();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.txtCoPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Ps);
            this.MainPanel.Controls.Add(this.LiLabel);
            this.MainPanel.Controls.Add(this.SignUp);
            this.MainPanel.Controls.Add(this.lblSignUp);
            this.MainPanel.Controls.Add(this.txtCoPass);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.txtPassword);
            this.MainPanel.Controls.Add(this.txtName);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Location = new System.Drawing.Point(134, 101);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(433, 472);
            this.MainPanel.TabIndex = 0;
            // 
            // Ps
            // 
            this.Ps.AutoSize = true;
            this.Ps.BackColor = System.Drawing.Color.Transparent;
            this.Ps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ps.ForeColor = System.Drawing.Color.White;
            this.Ps.Location = new System.Drawing.Point(192, 347);
            this.Ps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ps.Name = "Ps";
            this.Ps.Size = new System.Drawing.Size(139, 24);
            this.Ps.TabIndex = 15;
            this.Ps.Text = "ShowPassword";
            this.Ps.UseVisualStyleBackColor = false;
            this.Ps.CheckedChanged += new System.EventHandler(this.Ps_CheckedChanged);
            // 
            // LiLabel
            // 
            this.LiLabel.AutoSize = true;
            this.LiLabel.BackColor = System.Drawing.Color.Transparent;
            this.LiLabel.LinkColor = System.Drawing.Color.White;
            this.LiLabel.Location = new System.Drawing.Point(115, 443);
            this.LiLabel.Name = "LiLabel";
            this.LiLabel.Size = new System.Drawing.Size(175, 20);
            this.LiLabel.TabIndex = 14;
            this.LiLabel.TabStop = true;
            this.LiLabel.Text = "Already Have Account?";
            this.LiLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LiLabel_LinkClicked);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.SkyBlue;
            this.SignUp.FlatAppearance.BorderSize = 0;
            this.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp.ForeColor = System.Drawing.Color.Transparent;
            this.SignUp.Location = new System.Drawing.Point(102, 391);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(213, 49);
            this.SignUp.TabIndex = 13;
            this.SignUp.Text = "SignUp";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(170, 32);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(96, 32);
            this.lblSignUp.TabIndex = 12;
            this.lblSignUp.Text = "SignUp";
            // 
            // txtCoPass
            // 
            this.txtCoPass.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCoPass.Location = new System.Drawing.Point(86, 311);
            this.txtCoPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCoPass.Name = "txtCoPass";
            this.txtCoPass.Size = new System.Drawing.Size(247, 26);
            this.txtCoPass.TabIndex = 11;
            this.txtCoPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Location = new System.Drawing.Point(84, 238);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(247, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtName.Location = new System.Drawing.Point(84, 155);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(247, 26);
            this.txtName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(79, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserName:";
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 689);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Form_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Ps;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtCoPass;
        public System.Windows.Forms.Label lblSignUp;
        public System.Windows.Forms.Button SignUp;
        public System.Windows.Forms.LinkLabel LiLabel;
    }
}