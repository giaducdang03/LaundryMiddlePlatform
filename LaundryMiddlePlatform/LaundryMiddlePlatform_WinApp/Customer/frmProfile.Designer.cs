namespace LaundryMiddlePlatform_WinApp.Customer
{
    partial class frmProfile
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
            groupBox1 = new GroupBox();
            btnResetPw = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            txtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboRole = new ComboBox();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            lblAccount = new Label();
            lblDate = new Label();
            button1 = new Button();
            splitter1 = new Splitter();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitter1);
            groupBox1.Controls.Add(btnResetPw);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(cboRole);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(-2, 35);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1304, 369);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Your Profile";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnResetPw
            // 
            btnResetPw.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetPw.Location = new Point(955, 168);
            btnResetPw.Margin = new Padding(3, 4, 3, 4);
            btnResetPw.Name = "btnResetPw";
            btnResetPw.Size = new Size(86, 31);
            btnResetPw.TabIndex = 15;
            btnResetPw.Text = "Reset";
            btnResetPw.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(825, 213);
            label11.Name = "label11";
            label11.Size = new Size(88, 20);
            label11.TabIndex = 14;
            label11.Text = "*Default is 1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(825, 168);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(114, 30);
            textBox1.TabIndex = 13;
            textBox1.Text = "1234";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(732, 168);
            label10.Name = "label10";
            label10.Size = new Size(85, 23);
            label10.TabIndex = 12;
            label10.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(825, 99);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Mask = "0000000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(114, 30);
            txtPhone.TabIndex = 11;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthDate.Location = new Point(194, 168);
            dtpBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(274, 30);
            dtpBirthDate.TabIndex = 10;
            // 
            // cboRole
            // 
            cboRole.Enabled = false;
            cboRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Staff", "Store", "User" });
            cboRole.Location = new Point(194, 228);
            cboRole.Margin = new Padding(3, 4, 3, 4);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(138, 31);
            cboRole.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(825, 39);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(274, 30);
            txtAddress.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(194, 105);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(274, 30);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(194, 39);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 35);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(95, 228);
            label6.Name = "label6";
            label6.Size = new Size(45, 23);
            label6.TabIndex = 5;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(732, 99);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(732, 40);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 168);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 2;
            label3.Text = "Birthdate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 106);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "Full name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(95, 49);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 0;
            label7.Text = "Email";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.ForeColor = Color.Red;
            lblAccount.Location = new Point(28, 448);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(63, 20);
            lblAccount.TabIndex = 5;
            lblAccount.Text = "Account";
            lblAccount.Click += lblAccount_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(-2, 408);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(542, 430);
            button1.Name = "button1";
            button1.Size = new Size(180, 50);
            button1.TabIndex = 16;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(1297, 32);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 333);
            splitter1.TabIndex = 16;
            splitter1.TabStop = false;
            // 
            // frmProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 506);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(lblAccount);
            Controls.Add(lblDate);
            Name = "frmProfile";
            Text = "frmProfile";
            Load += frmProfile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnResetPw;
        private Label label11;
        private TextBox textBox1;
        private Label label10;
        private MaskedTextBox txtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboRole;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label lblAccount;
        private Label lblDate;
        private Button button1;
        private Splitter splitter1;
    }
}