namespace LaundryMiddlePlatform_WinApp
{
    partial class frmViewOrder
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
            btnUpdateStatus = new Button();
            txtCustomer = new TextBox();
            txtPhone = new TextBox();
            txtOrderDate = new TextBox();
            txtStaffName = new TextBox();
            txtStaffPhone = new TextBox();
            txtTotalPrice = new TextBox();
            txtOrderID = new TextBox();
            txtStatus = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUpdateStatus);
            groupBox1.Controls.Add(txtCustomer);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtOrderDate);
            groupBox1.Controls.Add(txtStaffName);
            groupBox1.Controls.Add(txtStaffPhone);
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(txtStatus);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(11, 27);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1131, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order information";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(621, 124);
            btnUpdateStatus.Margin = new Padding(2);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(84, 22);
            btnUpdateStatus.TabIndex = 18;
            btnUpdateStatus.Text = "Update";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Visible = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(120, 76);
            txtCustomer.Margin = new Padding(2);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(212, 23);
            txtCustomer.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 125);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(212, 23);
            txtPhone.TabIndex = 16;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(467, 26);
            txtOrderDate.Margin = new Padding(2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(238, 23);
            txtOrderDate.TabIndex = 15;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(860, 26);
            txtStaffName.Margin = new Padding(2);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(224, 23);
            txtStaffName.TabIndex = 14;
            // 
            // txtStaffPhone
            // 
            txtStaffPhone.Location = new Point(860, 74);
            txtStaffPhone.Margin = new Padding(2);
            txtStaffPhone.Name = "txtStaffPhone";
            txtStaffPhone.ReadOnly = true;
            txtStaffPhone.RightToLeft = RightToLeft.No;
            txtStaffPhone.Size = new Size(224, 23);
            txtStaffPhone.TabIndex = 13;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(467, 77);
            txtTotalPrice.Margin = new Padding(2);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(238, 23);
            txtTotalPrice.TabIndex = 11;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(120, 26);
            txtOrderID.Margin = new Padding(2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(212, 23);
            txtOrderID.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(467, 128);
            txtStatus.Margin = new Padding(2, 0, 2, 0);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(38, 15);
            txtStatus.TabIndex = 9;
            txtStatus.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(747, 80);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 8;
            label7.Text = "Staff phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(747, 29);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 7;
            label8.Text = "Staff name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 77);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 5;
            label6.Text = "Customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 128);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Total price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 252);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1131, 279);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // frmViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 630);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmViewOrder";
            Text = "View Order";
            Load += frmViewOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label txtStatus;
        private Label label7;
        private TextBox txtCustomer;
        private TextBox txtPhone;
        private TextBox txtOrderDate;
        private TextBox txtStaffName;
        private TextBox txtStaffPhone;
        private TextBox txtTotalPrice;
        private TextBox txtOrderID;
        private Button btnUpdateStatus;
    }
}