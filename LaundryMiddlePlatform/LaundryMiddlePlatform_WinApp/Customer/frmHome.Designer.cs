namespace LaundryMiddlePlatform_WinApp.Customer
{
    partial class frmHome
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
            dgvStore = new DataGridView();
            lbHeader = new Label();
            txtSortBy = new Label();
            cboSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStore).BeginInit();
            SuspendLayout();
            // 
            // dgvStore
            // 
            dgvStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Location = new Point(14, 129);
            dgvStore.Name = "dgvStore";
            dgvStore.ReadOnly = true;
            dgvStore.RowHeadersWidth = 51;
            dgvStore.RowTemplate.Height = 29;
            dgvStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStore.Size = new Size(1292, 609);
            dgvStore.TabIndex = 0;
            dgvStore.CellDoubleClick += dgvStore_CellDoubleClick;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbHeader.Location = new Point(488, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(390, 56);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Laundry Store";
            lbHeader.Click += lbHeader_Click;
            // 
            // txtSortBy
            // 
            txtSortBy.AutoSize = true;
            txtSortBy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSortBy.Location = new Point(14, 91);
            txtSortBy.Name = "txtSortBy";
            txtSortBy.Size = new Size(60, 20);
            txtSortBy.TabIndex = 2;
            txtSortBy.Text = "Sort By";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "Name: A -> Z", "Name: Z -> A" });
            cboSort.Location = new Point(89, 87);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(171, 28);
            cboSort.TabIndex = 3;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 840);
            Controls.Add(cboSort);
            Controls.Add(txtSortBy);
            Controls.Add(lbHeader);
            Controls.Add(dgvStore);
            Name = "frmHome";
            Text = "Home";
            Load += frmHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStore;
        private Label lbHeader;
        private Label txtSortBy;
        private ComboBox cboSort;
    }
}