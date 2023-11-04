namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    partial class frmOrderDetailStaff
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
            btnWorking = new Button();
            lblStatus = new Label();
            txtStaffPhone = new TextBox();
            txtOrderDate = new TextBox();
            txtStaffName = new TextBox();
            txtPrice = new TextBox();
            txtCustomerPhone = new TextBox();
            txtCustomer = new TextBox();
            txtOrderId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvOrderDetail = new DataGridView();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnWorking);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(txtStaffPhone);
            groupBox1.Controls.Add(txtOrderDate);
            groupBox1.Controls.Add(txtStaffName);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtCustomerPhone);
            groupBox1.Controls.Add(txtCustomer);
            groupBox1.Controls.Add(txtOrderId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(19, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1086, 377);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
          
            // 
            // btnWorking
            // 
            btnWorking.Location = new Point(786, 307);
            btnWorking.Margin = new Padding(4, 5, 4, 5);
            btnWorking.Name = "btnWorking";
            btnWorking.Size = new Size(129, 38);
            btnWorking.TabIndex = 16;
            btnWorking.Text = "Working";
            btnWorking.UseVisualStyleBackColor = true;
            btnWorking.Click += btnComplete_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(659, 313);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 25);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Working";
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Location = new Point(659, 213);
            txtStaffPhone.Margin = new Padding(4, 5, 4, 5);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(143, 31);
            txtStaffPhone.TabIndex = 14;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(659, 43);
            txtOrderDate.Margin = new Padding(4, 5, 4, 5);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(253, 31);
            txtOrderDate.TabIndex = 13;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(659, 122);
            txtStaffName.Margin = new Padding(4, 5, 4, 5);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(253, 31);
            txtStaffName.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(129, 308);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 31);
            txtPrice.TabIndex = 11;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(129, 213);
            txtCustomerPhone.Margin = new Padding(4, 5, 4, 5);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(143, 31);
            txtCustomerPhone.TabIndex = 10;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(129, 122);
            txtCustomer.Margin = new Padding(4, 5, 4, 5);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(253, 31);
            txtCustomer.TabIndex = 9;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(129, 43);
            txtOrderId.Margin = new Padding(4, 5, 4, 5);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(143, 31);
            txtOrderId.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(554, 313);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(60, 25);
            label8.TabIndex = 7;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(554, 218);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 6;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(554, 127);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 5;
            label6.Text = "Staff";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(554, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 4;
            label5.Text = "Order date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 313);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 3;
            label4.Text = "Total price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(19, 475);
            dgvOrderDetail.Margin = new Padding(4, 5, 4, 5);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 25;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(1086, 245);
            dgvOrderDetail.TabIndex = 1;
            dgvOrderDetail.CellDoubleClick += dgvOrderDetail_CellDoubleClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 430);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(114, 25);
            label10.TabIndex = 2;
            label10.Text = "Order details";
            // 
            // frmOrderDetailStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 775);
            Controls.Add(label10);
            Controls.Add(dgvOrderDetail);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmOrderDetailStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Detail";
            Load += frmOrderDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtOrderId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblStatus;
        private TextBox txtStaffPhone;
        private TextBox txtOrderDate;
        private TextBox txtStaffName;
        private TextBox txtPrice;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomer;
        private Button btnWorking;
        private DataGridView dgvOrderDetail;
        private Label label10;
    }
}