namespace LaundryMiddlePlatform_WinApp
{
    partial class frmProfileStaff
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
            dgvProfileStaff = new DataGridView();
            groupBox1 = new GroupBox();
            dtpBirthDate = new DateTimePicker();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtRole = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfileStaff).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProfileStaff
            // 
            dgvProfileStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfileStaff.Location = new Point(12, 322);
            dgvProfileStaff.Name = "dgvProfileStaff";
            dgvProfileStaff.RowHeadersWidth = 62;
            dgvProfileStaff.RowTemplate.Height = 33;
            dgvProfileStaff.Size = new Size(1377, 274);
            dgvProfileStaff.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Controls.Add(txtFullname);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1377, 263);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(321, 201);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(300, 31);
            dtpBirthDate.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(935, 37);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(353, 31);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(935, 119);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(353, 31);
            txtPhone.TabIndex = 9;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(935, 200);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(353, 31);
            txtRole.TabIndex = 8;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(321, 119);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(353, 31);
            txtFullname.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(321, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(353, 31);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(761, 206);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 5;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(761, 125);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(761, 40);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 206);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "BirthDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 125);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "FullName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1394, 374);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1395, 506);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmProfileStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 625);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Controls.Add(dgvProfileStaff);
            Name = "frmProfileStaff";
            Text = "Profile Staff";
            Load += frmProfileStaff_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProfileStaff).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProfileStaff;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtRole;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private DateTimePicker dtpBirthDate;
        private Button btnUpdate;
        private Button btnSave;
    }
}