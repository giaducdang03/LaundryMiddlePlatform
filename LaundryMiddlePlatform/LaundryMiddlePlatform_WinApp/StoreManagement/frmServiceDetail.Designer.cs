namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    partial class frmServiceDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTitle = new Label();
            txtServiceName = new TextBox();
            cboWashType = new ComboBox();
            cboWashOption = new ComboBox();
            txtPrice = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtDuration = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Service name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 93);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Wash type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 93);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Wash option";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 154);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Completion time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 206);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 4;
            label5.Text = "Price per 5 kg";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(301, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 21);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "SERVICE DETAIL";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(162, 37);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(182, 23);
            txtServiceName.TabIndex = 6;
            // 
            // cboWashType
            // 
            cboWashType.FormattingEnabled = true;
            cboWashType.Items.AddRange(new object[] { "Giặt thường", "Giặt nhanh", "Giặt siêu tốc" });
            cboWashType.Location = new Point(162, 90);
            cboWashType.Name = "cboWashType";
            cboWashType.Size = new Size(182, 23);
            cboWashType.TabIndex = 7;
            // 
            // cboWashOption
            // 
            cboWashOption.FormattingEnabled = true;
            cboWashOption.Items.AddRange(new object[] { "Giặt sấy", "Giặt ướt", "Giặt hấp" });
            cboWashOption.Location = new Point(463, 90);
            cboWashOption.Name = "cboWashOption";
            cboWashOption.Size = new Size(182, 23);
            cboWashOption.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(162, 203);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 23);
            txtPrice.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 206);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 11;
            label7.Text = "(VND)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(306, 154);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 12;
            label8.Text = "(hours)";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(162, 151);
            txtDuration.Mask = "00:00:00";
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(137, 23);
            txtDuration.TabIndex = 13;
            txtDuration.ValidatingType = typeof(DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDuration);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(cboWashOption);
            groupBox1.Controls.Add(cboWashType);
            groupBox1.Controls.Add(txtServiceName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 260);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Service";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(512, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 16;
            btnClose.Text = "&Cancel";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(614, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmServiceDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 396);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "frmServiceDetail";
            Text = "Service Detail";
            Load += frmServiceDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTitle;
        private TextBox txtServiceName;
        private ComboBox cboWashType;
        private ComboBox cboWashOption;
        private TextBox txtPrice;
        private Label label7;
        private Label label8;
        private MaskedTextBox txtDuration;
        private GroupBox groupBox1;
        private Button btnClose;
        private Button btnAdd;
    }
}