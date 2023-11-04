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
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            txtStatus = new TextBox();
            btnCreate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            cboIsAvailable = new ComboBox();
            cbxManagement = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStore
            // 
            dgvStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Location = new Point(42, 218);
            dgvStore.Margin = new Padding(2);
            dgvStore.Name = "dgvStore";
            dgvStore.ReadOnly = true;
            dgvStore.RowHeadersWidth = 62;
            dgvStore.RowTemplate.Height = 33;
            dgvStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStore.Size = new Size(933, 224);
            dgvStore.TabIndex = 0;
            dgvStore.CellDoubleClick += dgvStore_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Store Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 108);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Is Available";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 150);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 5;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 109);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 67);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 7;
            label7.Text = "Name";
            // 
            // txtStoreID
            // 
            txtStoreID.Location = new Point(113, 25);
            txtStoreID.Margin = new Padding(2);
            txtStoreID.Name = "txtStoreID";
            txtStoreID.ReadOnly = true;
            txtStoreID.Size = new Size(122, 23);
            txtStoreID.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(113, 147);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(152, 23);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(113, 106);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(283, 23);
            txtAddress.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 64);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 23);
            txtName.TabIndex = 13;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(631, 105);
            txtStatus.Margin = new Padding(2);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(122, 23);
            txtStatus.TabIndex = 14;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(998, 218);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(78, 23);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(998, 285);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(998, 351);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(998, 419);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(78, 23);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboIsAvailable);
            groupBox1.Controls.Add(cbxManagement);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtStoreID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(42, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(933, 191);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Store Information";
            // 
            // cboIsAvailable
            // 
            cboIsAvailable.FormattingEnabled = true;
            cboIsAvailable.Items.AddRange(new object[] { "True", "False" });
            cboIsAvailable.Location = new Point(631, 64);
            cboIsAvailable.Name = "cboIsAvailable";
            cboIsAvailable.Size = new Size(121, 23);
            cboIsAvailable.TabIndex = 16;
            // 
            // cbxManagement
            // 
            cbxManagement.Enabled = false;
            cbxManagement.FormattingEnabled = true;
            cbxManagement.Location = new Point(631, 23);
            cbxManagement.Margin = new Padding(2);
            cbxManagement.Name = "cbxManagement";
            cbxManagement.Size = new Size(283, 23);
            cbxManagement.TabIndex = 15;
            // 
            // frmStoreManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 449);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCreate);
            Controls.Add(dgvStore);
            Margin = new Padding(2);
            Name = "frmStoreManagement";
            Text = "StoreManagement";
            Load += frmStoreManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtName;
        private TextBox txtStatus;
        private Button btnCreate;
        private Button btnSave;
        private Button btnDelete;
        private Button btnExit;
        private GroupBox groupBox1;
        private ComboBox cbxManagement;
        private ComboBox cboIsAvailable;
    }
}