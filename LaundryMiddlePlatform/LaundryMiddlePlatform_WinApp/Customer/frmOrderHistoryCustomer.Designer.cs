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
            groupBox3 = new GroupBox();
            lblTotalAmount = new Label();
            lblNumOfOrder = new Label();
            label16 = new Label();
            label15 = new Label();
            cboSort = new ComboBox();
            label9 = new Label();
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
            groupBox2.Controls.Add(groupBox3);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalAmount);
            groupBox3.Controls.Add(lblNumOfOrder);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(341, 0);
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
            label9.Location = new Point(13, 29);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 0;
            label9.Text = "Sort by";
            // 
            // frmOrderHistoryCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 881);
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
        private ComboBox cboSort;
        private Label label9;
        private GroupBox groupBox3;
        private Label lblTotalAmount;
        private Label lblNumOfOrder;
        private Label label16;
        private Label label15;
    }
}