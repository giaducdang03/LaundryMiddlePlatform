namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    partial class frmOrderManagement
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
            lblManager = new Label();
            lblStoreName = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblStatus = new Label();
            txtStaffPhone = new TextBox();
            txtStaffName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            txtPrice = new TextBox();
            txtOrderDate = new TextBox();
            txtPhone = new TextBox();
            txtCustomer = new TextBox();
            txtOrderId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dtpTo = new DateTimePicker();
            label11 = new Label();
            dtpFrom = new DateTimePicker();
            label10 = new Label();
            cboSort = new ComboBox();
            label9 = new Label();
            dgvOrders = new DataGridView();
            label14 = new Label();
            groupBox3 = new GroupBox();
            lblTotalAmount = new Label();
            lblNumOfOrder = new Label();
            label16 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Location = new Point(86, 51);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(46, 20);
            lblManager.TabIndex = 7;
            lblManager.Text = "name";
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(86, 12);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(46, 20);
            lblStoreName.TabIndex = 6;
            lblStoreName.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "Manager:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 4;
            label1.Text = "Store:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(txtStaffPhone);
            groupBox1.Controls.Add(txtStaffName);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtOrderDate);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtCustomer);
            groupBox1.Controls.Add(txtOrderId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(14, 86);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1290, 200);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Information";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(558, 155);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "label14";
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Location = new Point(976, 95);
            txtStaffPhone.Margin = new Padding(3, 4, 3, 4);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.Size = new Size(110, 27);
            txtStaffPhone.TabIndex = 15;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(976, 43);
            txtStaffName.Margin = new Padding(3, 4, 3, 4);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(209, 27);
            txtStaffName.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(881, 99);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 13;
            label13.Text = "Staff phone";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(881, 47);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 12;
            label12.Text = "Staff name";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(558, 95);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 10;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(558, 43);
            txtOrderDate.Margin = new Padding(3, 4, 3, 4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(209, 27);
            txtOrderDate.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(102, 151);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(246, 27);
            txtPhone.TabIndex = 8;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(102, 95);
            txtCustomer.Margin = new Padding(3, 4, 3, 4);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(246, 27);
            txtCustomer.TabIndex = 7;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(102, 43);
            txtOrderId.Margin = new Padding(3, 4, 3, 4);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(246, 27);
            txtOrderId.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(465, 155);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 5;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(465, 99);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "Total price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 47);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 3;
            label6.Text = "Order date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 155);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 2;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 47);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 0;
            label3.Text = "Order ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpTo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(dtpFrom);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboSort);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(524, 294);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(782, 65);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(559, 26);
            dtpTo.Margin = new Padding(3, 4, 3, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(212, 27);
            dtpTo.TabIndex = 5;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(528, 28);
            label11.Name = "label11";
            label11.Size = new Size(25, 20);
            label11.TabIndex = 4;
            label11.Text = "To";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(290, 26);
            dtpFrom.Margin = new Padding(3, 4, 3, 4);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(212, 27);
            dtpFrom.TabIndex = 3;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 30);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 2;
            label10.Text = "From";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "Newest", "Oldest" });
            cboSort.Location = new Point(81, 25);
            cboSort.Margin = new Padding(3, 4, 3, 4);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(138, 28);
            cboSort.TabIndex = 1;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 28);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 0;
            label9.Text = "Sort by";
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(14, 394);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1290, 430);
            dgvOrders.TabIndex = 10;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(14, 370);
            label14.Name = "label14";
            label14.Size = new Size(199, 20);
            label14.TabIndex = 11;
            label14.Text = "* Double click to view detail";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalAmount);
            groupBox3.Controls.Add(lblNumOfOrder);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(14, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 65);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.Red;
            lblTotalAmount.Location = new Point(344, 28);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(56, 20);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "label17";
            // 
            // lblNumOfOrder
            // 
            lblNumOfOrder.AutoSize = true;
            lblNumOfOrder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumOfOrder.Location = new Point(124, 28);
            lblNumOfOrder.Name = "lblNumOfOrder";
            lblNumOfOrder.Size = new Size(56, 20);
            lblNumOfOrder.TabIndex = 2;
            lblNumOfOrder.Text = "label17";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(238, 28);
            label16.Name = "label16";
            label16.Size = new Size(100, 20);
            label16.TabIndex = 1;
            label16.Text = "Total amount:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 28);
            label15.Name = "label15";
            label15.Size = new Size(108, 20);
            label15.TabIndex = 0;
            label15.Text = "Num of orders:";
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 881);
            Controls.Add(groupBox3);
            Controls.Add(label14);
            Controls.Add(dgvOrders);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblManager);
            Controls.Add(lblStoreName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderManagement";
            Text = "Order Management";
            Load += frmOrderManagement_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblManager;
        private Label lblStoreName;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtOrderDate;
        private TextBox txtPhone;
        private TextBox txtCustomer;
        private TextBox txtOrderId;
        private GroupBox groupBox2;
        private ComboBox cboSort;
        private Label label9;
        private DateTimePicker dtpTo;
        private Label label11;
        private DateTimePicker dtpFrom;
        private Label label10;
        private DataGridView dgvOrders;
        private TextBox txtStaffPhone;
        private TextBox txtStaffName;
        private Label label13;
        private Label label12;
        private Label lblStatus;
        private Label label14;
        private GroupBox groupBox3;
        private Label label15;
        private Label lblTotalAmount;
        private Label lblNumOfOrder;
        private Label label16;
    }
}