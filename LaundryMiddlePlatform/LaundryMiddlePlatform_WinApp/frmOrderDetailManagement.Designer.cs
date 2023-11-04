namespace LaundryMiddlePlatform_WinApp
{
    partial class frmOrderDetailManagement
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
            dgvOrderDetail = new DataGridView();
            Id = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtWeight = new TextBox();
            txtPrice = new TextBox();
            txtUnitPrice = new TextBox();
            btnUpdate = new Button();
            btnSave = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(49, 248);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 62;
            dgvOrderDetail.RowTemplate.Height = 33;
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetail.Size = new Size(1031, 277);
            dgvOrderDetail.TabIndex = 0;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(49, 28);
            Id.Name = "Id";
            Id.Size = new Size(28, 25);
            Id.TabIndex = 1;
            Id.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 138);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 3;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 138);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 4;
            label4.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(601, 28);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(338, 31);
            txtId.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(754, 135);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(338, 31);
            txtWeight.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(754, 25);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(338, 31);
            txtPrice.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(158, 132);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(338, 31);
            txtUnitPrice.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1084, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1086, 437);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 209);
            label1.Name = "label1";
            label1.Size = new Size(258, 25);
            label1.TabIndex = 13;
            label1.Text = "Double Click To Update Weight";
            // 
            // frmOrderDetailManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 571);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtPrice);
            Controls.Add(txtWeight);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Id);
            Controls.Add(dgvOrderDetail);
            Name = "frmOrderDetailManagement";
            Text = "Order Detail Management";
            Load += frmOrderDetailManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetail;
        private Label Id;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtId;
        private TextBox txtWeight;
        private TextBox txtPrice;
        private TextBox txtUnitPrice;
        private Button btnUpdate;
        private Button btnSave;
        private Label label1;
    }
}