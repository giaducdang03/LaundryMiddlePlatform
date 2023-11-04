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
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new Point(8, 14);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(1134, 194);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(132, 128);
            dtpBirthDate.Margin = new Padding(2, 2, 2, 2);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(211, 23);
            dtpBirthDate.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(574, 31);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(248, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(574, 82);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(248, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(574, 130);
            txtRole.Margin = new Padding(2, 2, 2, 2);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(248, 23);
            txtRole.TabIndex = 8;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(132, 78);
            txtFullname.Margin = new Padding(2, 2, 2, 2);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(248, 23);
            txtFullname.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(132, 31);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 133);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 85);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 34);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "BirthDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "FullName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(614, 228);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(755, 228);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmProfileStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 630);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmProfileStaff";
            Text = "Profile Staff";
            Load += frmProfileStaff_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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