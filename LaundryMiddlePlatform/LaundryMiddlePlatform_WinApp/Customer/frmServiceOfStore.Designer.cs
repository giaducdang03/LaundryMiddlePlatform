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
            btnOrder = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(-8, 52);
            dgvServices.Margin = new Padding(3, 2, 3, 2);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(1015, 187);
            dgvServices.TabIndex = 0;
            dgvServices.CellDoubleClick += dgvServices_CellDoubleClick;
            // 
            // dgvServiceDetails
            // 
            dgvServiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceDetails.Location = new Point(1, 244);
            dgvServiceDetails.Margin = new Padding(3, 2, 3, 2);
            dgvServiceDetails.Name = "dgvServiceDetails";
            dgvServiceDetails.RowHeadersWidth = 51;
            dgvServiceDetails.RowTemplate.Height = 29;
            dgvServiceDetails.Size = new Size(1006, 141);
            dgvServiceDetails.TabIndex = 0;
            // 
            // lbService
            // 
            lbService.AutoSize = true;
            lbService.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbService.Location = new Point(836, 20);
            lbService.Name = "lbService";
            lbService.Size = new Size(156, 32);
            lbService.TabIndex = 1;
            lbService.Text = "Service Table";
            lbService.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(1012, 214);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(79, 60);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1, 28);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(58, 22);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(64, 29);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 23);
            txtSearch.TabIndex = 4;
            // 
            // frmServiceOfStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 377);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnOrder);
            Controls.Add(lbService);
            Controls.Add(dgvServiceDetails);
            Controls.Add(dgvServices);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmServiceOfStore";
            Text = "Service Of Store";
            Load += frmServiceOfStore_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServices;
        private DataGridView dgvServiceDetails;
        private Label lbService;
        private Button btnOrder;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}