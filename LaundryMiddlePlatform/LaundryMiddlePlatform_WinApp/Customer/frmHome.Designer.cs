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
            txtFilter = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnSearch = new Button();
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
            dgvStore.Size = new Size(1259, 624);
            dgvStore.TabIndex = 0;
            dgvStore.DoubleClick += dgvStore_DoubleClick;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            lbHeader.Location = new Point(448, 9);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(390, 56);
            lbHeader.TabIndex = 1;
            lbHeader.Text = "Laundry Store";
            lbHeader.Click += lbHeader_Click;
            // 
            // txtFilter
            // 
            txtFilter.AutoSize = true;
            txtFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtFilter.Location = new Point(1129, 105);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(50, 20);
            txtFilter.TabIndex = 2;
            txtFilter.Text = "Fill by";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alphabet", "Rate" });
            comboBox1.Location = new Point(1185, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(62, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.ButtonHighlight;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(1, 97);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 30);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 752);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtFilter);
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
        private Label txtFilter;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnSearch;
    }
}