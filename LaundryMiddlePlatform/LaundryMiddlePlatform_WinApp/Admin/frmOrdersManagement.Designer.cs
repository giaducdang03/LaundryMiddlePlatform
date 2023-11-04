namespace LaundryMiddlePlatform_WinApp.Admin
{
    partial class frmOrdersManagement
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
            lbFilter = new Label();
            cboStore = new ComboBox();
            groupBox3 = new GroupBox();
            lblNumOfOrder = new Label();
            label15 = new Label();
            groupBox2 = new GroupBox();
            dtpTo = new DateTimePicker();
            label11 = new Label();
            dtpFrom = new DateTimePicker();
            label10 = new Label();
            cboSort = new ComboBox();
            label9 = new Label();
            lblTotalAmount = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 130);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 29;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1294, 484);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Location = new Point(12, 95);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(124, 20);
            lbFilter.TabIndex = 1;
            lbFilter.Text = "Filter By Store  ID";
            // 
            // cboStore
            // 
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(136, 92);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(151, 28);
            cboStore.TabIndex = 2;
            cboStore.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalAmount);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(lblNumOfOrder);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(418, 65);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(10, 28);
            label15.Name = "label15";
            label15.Size = new Size(108, 20);
            label15.TabIndex = 0;
            label15.Text = "Num of orders:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpTo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(dtpFrom);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboSort);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(503, 58);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(803, 65);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(559, 26);
            dtpTo.Margin = new Padding(3, 4, 3, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(238, 27);
            dtpTo.TabIndex = 5;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(528, 30);
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
            label10.Location = new Point(241, 32);
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
            label9.Location = new Point(13, 30);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 0;
            label9.Text = "Sort by";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.ForeColor = Color.Red;
            lblTotalAmount.Location = new Point(327, 28);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(56, 20);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "label17";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(221, 28);
            label16.Name = "label16";
            label16.Size = new Size(100, 20);
            label16.TabIndex = 4;
            label16.Text = "Total amount:";
            // 
            // frmOrdersManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 840);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(cboStore);
            Controls.Add(lbFilter);
            Controls.Add(dgvOrders);
            Name = "frmOrdersManagement";
            Text = "Orders Management";
            Load += frmOrdersManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Label lbFilter;
        private ComboBox cboStore;
        private GroupBox groupBox3;
        private Label lblNumOfOrder;
        private Label label15;
        private GroupBox groupBox2;
        private DateTimePicker dtpTo;
        private Label label11;
        private DateTimePicker dtpFrom;
        private Label label10;
        private ComboBox cboSort;
        private Label label9;
        private Label lblTotalAmount;
        private Label label16;
    }
}