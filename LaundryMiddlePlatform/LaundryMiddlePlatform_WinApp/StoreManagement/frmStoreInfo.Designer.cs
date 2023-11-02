namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    partial class frmStoreInfo
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
            txtPhone = new MaskedTextBox();
            btnChange = new Button();
            lblStatus = new Label();
            txtAddress = new TextBox();
            txtStoreName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblManager = new Label();
            lblStoreName = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            btnUpdate = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(btnChange);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtStoreName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Store info";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(124, 164);
            txtPhone.Mask = "0000000000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(157, 23);
            txtPhone.TabIndex = 9;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(391, 229);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(75, 23);
            btnChange.TabIndex = 8;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(124, 233);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label7";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(124, 96);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(342, 23);
            txtAddress.TabIndex = 5;
            // 
            // txtStoreName
            // 
            txtStoreName.Location = new Point(124, 35);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Size = new Size(342, 23);
            txtStoreName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 233);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 3;
            label6.Text = "Is available";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 167);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 2;
            label5.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 99);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 38);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Store name";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Location = new Point(75, 38);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(37, 15);
            lblManager.TabIndex = 7;
            lblManager.Text = "name";
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(75, 9);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(37, 15);
            lblStoreName.TabIndex = 6;
            lblStoreName.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Manager:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Store:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Location = new Point(12, 377);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 62);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(375, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(475, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(179, 233);
            label7.Name = "label7";
            label7.Size = new Size(203, 15);
            label7.TabIndex = 10;
            label7.Text = "(True: accept order, False: deny order)";
            // 
            // frmStoreInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 661);
            Controls.Add(groupBox2);
            Controls.Add(lblManager);
            Controls.Add(lblStoreName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmStoreInfo";
            Text = "Store Infomation";
            Load += frmStoreInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblManager;
        private Label lblStoreName;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtStoreName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnChange;
        private Label lblStatus;
        private MaskedTextBox txtPhone;
        private GroupBox groupBox2;
        private Button btnSave;
        private Button btnUpdate;
        private Label label7;
    }
}