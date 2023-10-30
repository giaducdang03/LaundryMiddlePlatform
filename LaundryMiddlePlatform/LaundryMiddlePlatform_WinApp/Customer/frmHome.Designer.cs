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
            dgvStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStore.Location = new Point(1, 128);
            dgvStore.Name = "dgvStore";
            dgvStore.RowHeadersWidth = 51;
            dgvStore.RowTemplate.Height = 29;
            dgvStore.Size = new Size(628, 624);
            dgvStore.TabIndex = 0;
            dgvStore.CellDoubleClick += dgvStore_CellDoubleClick;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbHeader.Location = new Point(114, 9);
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
            txtSortBy.Location = new Point(1, 97);
            txtSortBy.Name = "txtSortBy";
            txtSortBy.Size = new Size(60, 20);
            txtSortBy.TabIndex = 2;
            txtSortBy.Text = "Sort By";
            // 
            // cboSort
            // 
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "None", "Name: A -> Z", "Name: Z -> A" });
            cboSort.Location = new Point(67, 94);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(62, 28);
            cboSort.TabIndex = 3;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 752);
            Controls.Add(cboSort);
            Controls.Add(txtSortBy);
            Controls.Add(lbHeader);
            Controls.Add(dgvStore);
            Name = "frmHome";
            Text = "frmHome";
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