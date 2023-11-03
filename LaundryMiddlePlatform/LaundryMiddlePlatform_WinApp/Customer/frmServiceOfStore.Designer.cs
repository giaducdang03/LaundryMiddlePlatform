namespace LaundryMiddlePlatform_WinApp.Customer
{
    partial class frmServiceOfStore
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
            dgvServices = new DataGridView();
            dgvServiceDetails = new DataGridView();
            lbService = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            lblStorePhone = new Label();
            lblStoreAddress = new Label();
            lblStoreName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            splitContainer1 = new SplitContainer();
            btnBuy = new Button();
            splitContainer2 = new SplitContainer();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(0, 0);
            dgvServices.Margin = new Padding(3, 2, 3, 2);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(792, 194);
            dgvServices.TabIndex = 0;
            dgvServices.CellDoubleClick += dgvServices_CellDoubleClick;
            // 
            // dgvServiceDetails
            // 
            dgvServiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceDetails.Location = new Point(0, 0);
            dgvServiceDetails.Margin = new Padding(3, 2, 3, 2);
            dgvServiceDetails.Name = "dgvServiceDetails";
            dgvServiceDetails.RowHeadersWidth = 51;
            dgvServiceDetails.RowTemplate.Height = 29;
            dgvServiceDetails.Size = new Size(793, 122);
            dgvServiceDetails.TabIndex = 0;
            // 
            // lbService
            // 
            lbService.AutoSize = true;
            lbService.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbService.Location = new Point(391, 9);
            lbService.Name = "lbService";
            lbService.Size = new Size(139, 30);
            lbService.TabIndex = 1;
            lbService.Text = "Service Table";
            lbService.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(164, 150);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(58, 22);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 149);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 23);
            txtSearch.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStorePhone);
            groupBox1.Controls.Add(lblStoreAddress);
            groupBox1.Controls.Add(lblStoreName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(896, 93);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Store";
            // 
            // lblStorePhone
            // 
            lblStorePhone.AutoSize = true;
            lblStorePhone.Location = new Point(364, 28);
            lblStorePhone.Name = "lblStorePhone";
            lblStorePhone.Size = new Size(38, 15);
            lblStorePhone.TabIndex = 5;
            lblStorePhone.Text = "label4";
            // 
            // lblStoreAddress
            // 
            lblStoreAddress.AutoSize = true;
            lblStoreAddress.Location = new Point(88, 62);
            lblStoreAddress.Name = "lblStoreAddress";
            lblStoreAddress.Size = new Size(38, 15);
            lblStoreAddress.TabIndex = 4;
            lblStoreAddress.Text = "label5";
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(88, 28);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(38, 15);
            lblStoreName.TabIndex = 3;
            lblStoreName.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 28);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Telephone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 62);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(159, 15);
            label4.TabIndex = 6;
            label4.Text = "* Double click to view details";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 213);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvServices);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnBuy);
            splitContainer1.Size = new Size(896, 194);
            splitContainer1.SplitterDistance = 791;
            splitContainer1.TabIndex = 7;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(2, 86);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(95, 23);
            btnBuy.TabIndex = 8;
            btnBuy.Text = "Buy now";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(12, 419);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvServiceDetails);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnClose);
            splitContainer2.Size = new Size(896, 122);
            splitContainer2.SplitterDistance = 792;
            splitContainer2.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(2, 46);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 22);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmServiceOfStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 550);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lbService);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmServiceOfStore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Of Store";
            Load += frmServiceOfStore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServices;
        private DataGridView dgvServiceDetails;
        private Label lbService;
        private Button btnSearch;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private Label lblStorePhone;
        private Label lblStoreAddress;
        private Label lblStoreName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private SplitContainer splitContainer1;
        private Button btnBuy;
        private SplitContainer splitContainer2;
        private Button btnClose;
    }
}