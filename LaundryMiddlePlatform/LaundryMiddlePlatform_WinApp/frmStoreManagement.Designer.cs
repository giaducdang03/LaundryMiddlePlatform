namespace LaundryMiddlePlatform_WinApp
{
    partial class frmStoreManagement
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
            dgvStore = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStoreID = new TextBox();
            txtIsAvaiable = new TextBox();
            txtManagement = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtStatus = new TextBox();
            btnCreate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            SuspendLayout();
            // 
            // dgvStore
            // 
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Location = new Point(706, 12);
            dgvStore.Name = "dgvStore";
            dgvStore.RowHeadersWidth = 62;
            dgvStore.RowTemplate.Height = 33;
            dgvStore.Size = new Size(461, 502);
            dgvStore.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Store Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 420);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 346);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 3;
            label3.Text = "Is Available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 277);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 4;
            label4.Text = "ManagementId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 211);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 5;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 147);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 82);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 7;
            label7.Text = "Name";
            // 
            // txtStoreID
            // 
            txtStoreID.Location = new Point(251, 22);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.Size = new Size(402, 31);
            txtStoreID.TabIndex = 8;
            // 
            // txtIsAvaiable
            // 
            txtIsAvaiable.Location = new Point(251, 340);
            txtIsAvaiable.Name = "txtIsAvaiable";
            txtIsAvaiable.Size = new Size(402, 31);
            txtIsAvaiable.TabIndex = 9;
            // 
            // txtManagement
            // 
            txtManagement.Location = new Point(251, 262);
            txtManagement.Name = "txtManagement";
            txtManagement.Size = new Size(402, 31);
            txtManagement.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(251, 205);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(402, 31);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(251, 141);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(402, 31);
            txtAddress.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(251, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(402, 31);
            txtName.TabIndex = 13;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(251, 414);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(402, 31);
            txtStatus.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(26, 480);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(185, 480);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(359, 480);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(541, 480);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmStoreManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 577);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(txtStatus);
            Controls.Add(txtName);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtManagement);
            Controls.Add(txtIsAvaiable);
            Controls.Add(txtStoreID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStore);
            Name = "frmStoreManagement";
            Text = "StoreManagement";
            Load += frmStoreManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStore;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtStoreID;
        private TextBox txtIsAvaiable;
        private TextBox txtManagement;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtStatus;
        private Button btnCreate;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
    }
}