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
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(-9, 70);
            dgvServices.Name = "dgvServices";
            dgvServices.RowHeadersWidth = 51;
            dgvServices.RowTemplate.Height = 29;
            dgvServices.Size = new Size(1160, 249);
            dgvServices.TabIndex = 0;
            dgvServices.CellDoubleClick += dgvServices_CellDoubleClick;
            // 
            // dgvServiceDetails
            // 
            dgvServiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceDetails.Location = new Point(1, 325);
            dgvServiceDetails.Name = "dgvServiceDetails";
            dgvServiceDetails.RowHeadersWidth = 51;
            dgvServiceDetails.RowTemplate.Height = 29;
            dgvServiceDetails.Size = new Size(1150, 188);
            dgvServiceDetails.TabIndex = 0;
            // 
            // lbService
            // 
            lbService.AutoSize = true;
            lbService.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbService.Location = new Point(956, 26);
            lbService.Name = "lbService";
            lbService.Size = new Size(195, 41);
            lbService.TabIndex = 1;
            lbService.Text = "Service Table";
            lbService.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.Location = new Point(1157, 285);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(90, 80);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(66, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // frmServiceOfStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 503);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnOrder);
            Controls.Add(lbService);
            Controls.Add(dgvServiceDetails);
            Controls.Add(dgvServices);
            Name = "frmServiceOfStore";
            Text = "frmServiceOfStore";
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
        private TextBox textBox1;
    }
}