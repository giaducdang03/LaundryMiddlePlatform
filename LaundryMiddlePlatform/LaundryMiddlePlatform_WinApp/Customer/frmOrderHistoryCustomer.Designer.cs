namespace LaundryMiddlePlatform_WinApp.Customer
{
    partial class frmOrderHistoryCustomer
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
            dgvOrders = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox2 = new GroupBox();
            dtpTo = new DateTimePicker();
            label11 = new Label();
            dtpFrom = new DateTimePicker();
            label10 = new Label();
            cboSort = new ComboBox();
            label9 = new Label();
            groupBox3 = new GroupBox();
            lblTotalAmount = new Label();
            lblNumOfOrder = new Label();
            label16 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(16, 125);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1290, 430);
            dgvOrders.TabIndex = 11;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpTo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(dtpFrom);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboSort);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(16, 32);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(803, 65);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(559, 26);
            dtpTo.Margin = new Padding(3, 4, 3, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(238, 27);
            dtpTo.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(528, 29);
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
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 31);
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
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 29);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 0;
            label9.Text = "Sort by";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalAmount);
            groupBox3.Controls.Add(lblNumOfOrder);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(825, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(462, 65);
            groupBox3.TabIndex = 13;
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
            // frmOrderHistoryCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 881);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvOrders);
            Name = "frmOrderHistoryCustomer";
            Text = "frmOrderHistoryCustomer";
            Load += frmOrderHistoryCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrders;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox2;
        private DateTimePicker dtpTo;
        private Label label11;
        private DateTimePicker dtpFrom;
        private Label label10;
        private ComboBox cboSort;
        private Label label9;
        private GroupBox groupBox3;
        private Label lblTotalAmount;
        private Label lblNumOfOrder;
        private Label label16;
        private Label label15;
    }
}