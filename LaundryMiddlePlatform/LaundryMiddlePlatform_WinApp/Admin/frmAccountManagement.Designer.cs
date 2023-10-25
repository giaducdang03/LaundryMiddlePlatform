namespace LaundryMiddlePlatform_WinApp.Admin
{
    partial class frmAccountManagement
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
            lblDate = new Label();
            lblAccount = new Label();
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
            label1 = new Label();
            dgvAccounts = new DataGridView();
            splitContainer1 = new SplitContainer();
            btnClose = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btnSearch = new Button();
            txtSearchBox = new TextBox();
            cboSort = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            cboFilterRole = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(932, 9);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = true;
            lblAccount.ForeColor = Color.Red;
            lblAccount.Location = new Point(932, 34);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(52, 15);
            lblAccount.TabIndex = 1;
            lblAccount.Text = "Account";
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 167);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // btnResetPw
            // 
            btnResetPw.Location = new Point(987, 120);
            btnResetPw.Name = "btnResetPw";
            btnResetPw.Size = new Size(75, 23);
            btnResetPw.TabIndex = 15;
            btnResetPw.Text = "Reset";
            btnResetPw.UseVisualStyleBackColor = true;
            btnResetPw.Click += btnResetPw_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(872, 146);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 14;
            label11.Text = "*Default is 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(872, 120);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "1234";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(802, 123);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 12;
            label10.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(529, 73);
            txtPhone.Mask = "0000000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 11;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(120, 120);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(240, 23);
            dtpBirthDate.TabIndex = 10;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Staff", "Store", "User" });
            cboRole.Location = new Point(529, 120);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(121, 23);
            cboRole.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(529, 31);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(120, 73);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(240, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 31);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(462, 123);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 76);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 34);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 123);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Birthdate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 76);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Full name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // dgvAccounts
            // 
            dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccounts.Location = new Point(0, 0);
            dgvAccounts.Name = "dgvAccounts";
            dgvAccounts.ReadOnly = true;
            dgvAccounts.RowTemplate.Height = 25;
            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccounts.Size = new Size(1027, 247);
            dgvAccounts.TabIndex = 0;
            dgvAccounts.CellDoubleClick += dgvAccounts_CellDoubleClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 317);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.None;
            splitContainer1.Panel1.Controls.Add(dgvAccounts);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(btnDelete);
            splitContainer1.Panel2.Controls.Add(btnSave);
            splitContainer1.Panel2.Controls.Add(btnAdd);
            splitContainer1.Size = new Size(1129, 247);
            splitContainer1.SplitterDistance = 1027;
            splitContainer1.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(2, 203);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(2, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 76);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearchBox);
            groupBox2.Location = new Point(12, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 66);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 27);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 3;
            label8.Text = "Name";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(285, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(91, 24);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(175, 23);
            txtSearchBox.TabIndex = 1;
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "None", "Name: A -> Z", "Name: Z -> A" });
            cboSort.Location = new Point(250, 25);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(121, 23);
            cboSort.TabIndex = 3;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 28);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = "Sort by";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 28);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 4;
            label9.Text = "Role";
            // 
            // cboFilterRole
            // 
            cboFilterRole.FormattingEnabled = true;
            cboFilterRole.Items.AddRange(new object[] { "All", "Admin", "Staff", "Store", "User" });
            cboFilterRole.Location = new Point(58, 25);
            cboFilterRole.Name = "cboFilterRole";
            cboFilterRole.Size = new Size(121, 23);
            cboFilterRole.TabIndex = 5;
            cboFilterRole.SelectedIndexChanged += cboFilterRole_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboFilterRole);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cboSort);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(649, 234);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(390, 66);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter";
            // 
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox1);
            Controls.Add(lblAccount);
            Controls.Add(lblDate);
            Name = "frmAccountManagement";
            Text = "Account Management";
            Load += frmAccountManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccounts).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private Label lblAccount;
        private GroupBox groupBox1;
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
        private Label label1;
        private MaskedTextBox txtPhone;
        private DataGridView dgvAccounts;
        private SplitContainer splitContainer1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtSearchBox;
        private ComboBox cboFilterRole;
        private Label label9;
        private Label label8;
        private ComboBox cboSort;
        private Label label7;
        private GroupBox groupBox3;
        private Label label11;
        private TextBox textBox1;
        private Label label10;
        private Button btnResetPw;
    }
}