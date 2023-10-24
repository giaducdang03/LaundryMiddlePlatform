namespace LaundryMiddlePlatform_WinApp.Authen
{
    partial class frmRegister
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
            label2 = new Label();
            groupBox1 = new GroupBox();
            dtpBirthday = new DateTimePicker();
            txtPhone = new MaskedTextBox();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 18);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 2;
            label2.Text = "Register Account";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpBirthday);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 266);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(129, 220);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(129, 172);
            txtPhone.Mask = "0000000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(105, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(129, 123);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(294, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(129, 76);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(294, 23);
            txtFullName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 23);
            txtEmail.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 226);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 4;
            label6.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 175);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 3;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 126);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 2;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 79);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Full name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Your email";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtConfirm);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(40, 357);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 124);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Password";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(129, 81);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(200, 23);
            txtConfirm.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(129, 32);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 84);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 1;
            label8.Text = "Confirm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 35);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 0;
            label7.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(436, 498);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(337, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 551);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DateTimePicker dtpBirthday;
        private MaskedTextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private GroupBox groupBox2;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private Label label8;
        private Label label7;
        private Button btnRegister;
        private Button btnCancel;
    }
}