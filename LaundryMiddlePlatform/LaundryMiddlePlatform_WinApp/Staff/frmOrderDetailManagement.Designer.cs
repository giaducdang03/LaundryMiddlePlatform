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
            txtService = new TextBox();
            label2 = new Label();
            txtType = new TextBox();
            SuspendLayout();
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(33, 24);
            Id.Margin = new Padding(2, 0, 2, 0);
            Id.Name = "Id";
            Id.Size = new Size(92, 15);
            Id.TabIndex = 1;
            Id.Text = "Order deatail ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 146);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 149);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Weight (kg):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 151);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 21);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(76, 23);
            txtId.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(423, 146);
            txtWeight.Margin = new Padding(2);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(101, 23);
            txtWeight.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(669, 146);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(120, 23);
            txtPrice.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(134, 143);
            txtUnitPrice.Margin = new Padding(2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(152, 23);
            txtUnitPrice.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(600, 221);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(711, 221);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 85);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 13;
            label1.Text = "Service name:";
            // 
            // txtService
            // 
            txtService.Location = new Point(134, 81);
            txtService.Name = "txtService";
            txtService.ReadOnly = true;
            txtService.Size = new Size(152, 23);
            txtService.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 85);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Type:";
            // 
            // txtType
            // 
            txtType.Location = new Point(421, 81);
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(176, 23);
            txtType.TabIndex = 16;
            // 
            // frmOrderDetailManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 292);
            Controls.Add(txtType);
            Controls.Add(label2);
            Controls.Add(txtService);
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
            Margin = new Padding(2);
            Name = "frmOrderDetailManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Detail Management";
            Load += frmOrderDetailManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox txtService;
        private Label label2;
        private TextBox txtType;
    }
}