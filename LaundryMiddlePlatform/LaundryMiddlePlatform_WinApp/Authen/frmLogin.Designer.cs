namespace LaundryMiddlePlatform_WinApp
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 29);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 0;
            label1.Text = "Laundry Middle Platform";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(103, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 137);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(161, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(277, 23);
            txtPassword.TabIndex = 3;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(161, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 90);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 36);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(529, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 276);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 3;
            label4.Text = "Do you don't have account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(264, 276);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register now";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 367);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += frmLogin_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Button btnLogin;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}