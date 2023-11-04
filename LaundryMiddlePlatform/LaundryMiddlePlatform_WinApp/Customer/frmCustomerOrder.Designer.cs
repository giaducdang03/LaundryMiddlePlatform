namespace LaundryMiddlePlatform_WinApp.Customer
{
    partial class frmCustomerOrder
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
            lblCusPhone = new Label();
            lblCustomerAddr = new Label();
            lblCustomer = new Label();
            lblStorePhone = new Label();
            lblStroreAddr = new Label();
            lblStore = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblDuration = new Label();
            lblPrice = new Label();
            btnAddToCart = new Button();
            label10 = new Label();
            label9 = new Label();
            cboType = new ComboBox();
            label8 = new Label();
            cboServices = new ComboBox();
            label7 = new Label();
            dgvOrderDetail = new DataGridView();
            btnOrder = new Button();
            btnCancel = new Button();
            label13 = new Label();
            label11 = new Label();
            lblNotionalPrice = new Label();
            lblNotice = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCusPhone);
            groupBox1.Controls.Add(lblCustomerAddr);
            groupBox1.Controls.Add(lblCustomer);
            groupBox1.Controls.Add(lblStorePhone);
            groupBox1.Controls.Add(lblStroreAddr);
            groupBox1.Controls.Add(lblStore);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(961, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order infomation";
            // 
            // lblCusPhone
            // 
            lblCusPhone.AutoSize = true;
            lblCusPhone.Location = new Point(595, 106);
            lblCusPhone.Margin = new Padding(4, 0, 4, 0);
            lblCusPhone.Name = "lblCusPhone";
            lblCusPhone.Size = new Size(44, 15);
            lblCusPhone.TabIndex = 11;
            lblCusPhone.Text = "label12";
            // 
            // lblCustomerAddr
            // 
            lblCustomerAddr.AutoSize = true;
            lblCustomerAddr.Location = new Point(595, 68);
            lblCustomerAddr.Margin = new Padding(4, 0, 4, 0);
            lblCustomerAddr.Name = "lblCustomerAddr";
            lblCustomerAddr.Size = new Size(44, 15);
            lblCustomerAddr.TabIndex = 10;
            lblCustomerAddr.Text = "label11";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(595, 32);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(44, 15);
            lblCustomer.TabIndex = 9;
            lblCustomer.Text = "label10";
            // 
            // lblStorePhone
            // 
            lblStorePhone.AutoSize = true;
            lblStorePhone.Location = new Point(120, 106);
            lblStorePhone.Margin = new Padding(4, 0, 4, 0);
            lblStorePhone.Name = "lblStorePhone";
            lblStorePhone.Size = new Size(38, 15);
            lblStorePhone.TabIndex = 8;
            lblStorePhone.Text = "label9";
            // 
            // lblStroreAddr
            // 
            lblStroreAddr.AutoSize = true;
            lblStroreAddr.Location = new Point(120, 68);
            lblStroreAddr.Margin = new Padding(4, 0, 4, 0);
            lblStroreAddr.Name = "lblStroreAddr";
            lblStroreAddr.Size = new Size(38, 15);
            lblStroreAddr.TabIndex = 7;
            lblStroreAddr.Text = "label8";
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(120, 32);
            lblStore.Margin = new Padding(4, 0, 4, 0);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(38, 15);
            lblStore.TabIndex = 6;
            lblStore.Text = "label7";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(489, 106);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 5;
            label4.Text = "Telephone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(489, 68);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(489, 32);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 3;
            label6.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 106);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Telephone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 68);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Store:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblDuration);
            groupBox2.Controls.Add(lblPrice);
            groupBox2.Controls.Add(btnAddToCart);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cboType);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cboServices);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(10, 162);
            groupBox2.Margin = new Padding(4, 2, 4, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 2, 4, 2);
            groupBox2.Size = new Size(961, 89);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Service";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(620, 31);
            lblDuration.Margin = new Padding(4, 0, 4, 0);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(12, 15);
            lblDuration.TabIndex = 8;
            lblDuration.Text = "-";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Red;
            lblPrice.Location = new Point(827, 31);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(12, 15);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "-";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(844, 62);
            btnAddToCart.Margin = new Padding(4, 2, 4, 2);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(111, 22);
            btnAddToCart.TabIndex = 6;
            btnAddToCart.Text = "Add to cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(747, 31);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 5;
            label10.Text = "Price/5kg:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(545, 31);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 4;
            label9.Text = "Duration:";
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(338, 28);
            cboType.Margin = new Padding(4, 2, 4, 2);
            cboType.Name = "cboType";
            cboType.Size = new Size(185, 23);
            cboType.TabIndex = 3;
            cboType.SelectedIndexChanged += cboType_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(285, 31);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 2;
            label8.Text = "Type:";
            // 
            // cboServices
            // 
            cboServices.FormattingEnabled = true;
            cboServices.Location = new Point(88, 28);
            cboServices.Margin = new Padding(4, 2, 4, 2);
            cboServices.Name = "cboServices";
            cboServices.Size = new Size(176, 23);
            cboServices.TabIndex = 1;
            cboServices.SelectedIndexChanged += cboServices_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 31);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 0;
            label7.Text = "Service:";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(10, 273);
            dgvOrderDetail.Margin = new Padding(4, 2, 4, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.RowTemplate.Height = 29;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(961, 141);
            dgvOrderDetail.TabIndex = 2;
            dgvOrderDetail.CellDoubleClick += dgvOrderDetail_CellDoubleClick;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(856, 458);
            btnOrder.Margin = new Padding(4, 2, 4, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(115, 22);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(721, 458);
            btnCancel.Margin = new Padding(4, 2, 4, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 22);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(10, 256);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(208, 15);
            label13.TabIndex = 5;
            label13.Text = "* Double click on row to Remove item";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 428);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 6;
            label11.Text = "Notional price:";
            // 
            // lblNotionalPrice
            // 
            lblNotionalPrice.AutoSize = true;
            lblNotionalPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotionalPrice.ForeColor = Color.Red;
            lblNotionalPrice.Location = new Point(103, 428);
            lblNotionalPrice.Margin = new Padding(4, 0, 4, 0);
            lblNotionalPrice.Name = "lblNotionalPrice";
            lblNotionalPrice.Size = new Size(44, 15);
            lblNotionalPrice.TabIndex = 7;
            lblNotionalPrice.Text = "label12";
            // 
            // lblNotice
            // 
            lblNotice.AutoSize = true;
            lblNotice.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblNotice.Location = new Point(193, 428);
            lblNotice.Margin = new Padding(4, 0, 4, 0);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(38, 15);
            lblNotice.TabIndex = 8;
            lblNotice.Text = "(note)";
            // 
            // frmCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 491);
            Controls.Add(lblNotice);
            Controls.Add(lblNotionalPrice);
            Controls.Add(label11);
            Controls.Add(label13);
            Controls.Add(btnCancel);
            Controls.Add(btnOrder);
            Controls.Add(dgvOrderDetail);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmCustomerOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += frmCustomerOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblCusPhone;
        private Label lblCustomerAddr;
        private Label lblCustomer;
        private Label lblStorePhone;
        private Label lblStroreAddr;
        private Label lblStore;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox cboType;
        private Label label8;
        private ComboBox cboServices;
        private Label lblDuration;
        private Label lblPrice;
        private Button btnAddToCart;
        private Label label10;
        private Label label9;
        private DataGridView dgvOrderDetail;
        private Button btnOrder;
        private Button btnCancel;
        private Label label13;
        private Label label11;
        private Label lblNotionalPrice;
        private Label lblNotice;
    }
}