namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    partial class frmServiceManagement
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
            lblManager = new Label();
            lblStoreName = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvServices = new DataGridView();
            dgvServiceDetails = new DataGridView();
            splitContainer1 = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            splitContainer2 = new SplitContainer();
            button4 = new Button();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            txtServiceName = new TextBox();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Location = new Point(75, 38);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(37, 15);
            lblManager.TabIndex = 3;
            lblManager.Text = "name";
            // 
            // lblStoreName
            // 
            lblStoreName.AutoSize = true;
            lblStoreName.Location = new Point(75, 9);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(37, 15);
            lblStoreName.TabIndex = 2;
            lblStoreName.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Manager:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Store:";
            // 
            // dgvServices
            // 
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(0, 0);
            dgvServices.Name = "dgvServices";
            dgvServices.ReadOnly = true;
            dgvServices.RowTemplate.Height = 25;
            dgvServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServices.Size = new Size(1020, 204);
            dgvServices.TabIndex = 1;
            dgvServices.CellDoubleClick += dgvServices_CellDoubleClick;
            // 
            // dgvServiceDetails
            // 
            dgvServiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceDetails.Location = new Point(0, 0);
            dgvServiceDetails.Name = "dgvServiceDetails";
            dgvServiceDetails.ReadOnly = true;
            dgvServiceDetails.RowTemplate.Height = 25;
            dgvServiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceDetails.Size = new Size(1020, 148);
            dgvServiceDetails.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 231);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvServices);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(1129, 204);
            splitContainer1.SplitterDistance = 1019;
            splitContainer1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(3, 164);
            button3.Name = "button3";
            button3.Size = new Size(99, 23);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 91);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 13);
            button1.Name = "button1";
            button1.Size = new Size(99, 23);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(650, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 66);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 30);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Service name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(102, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(157, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(282, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(12, 472);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dgvServiceDetails);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button4);
            splitContainer2.Size = new Size(1129, 148);
            splitContainer2.SplitterDistance = 1019;
            splitContainer2.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(3, 61);
            button4.Name = "button4";
            button4.Size = new Size(99, 23);
            button4.TabIndex = 0;
            button4.Text = "Add detail";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDescription);
            groupBox2.Controls.Add(txtServiceName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 73);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(621, 152);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Service";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 43);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 0;
            label4.Text = "Service name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 86);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 1;
            label5.Text = "Description";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(114, 40);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(243, 23);
            txtServiceName.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(114, 83);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(243, 48);
            txtDescription.TabIndex = 3;
            // 
            // frmServiceManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 661);
            Controls.Add(groupBox2);
            Controls.Add(splitContainer2);
            Controls.Add(groupBox1);
            Controls.Add(lblManager);
            Controls.Add(splitContainer1);
            Controls.Add(lblStoreName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmServiceManagement";
            Text = "Service Management";
            Load += ServiceManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiceDetails).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblManager;
        private Label lblStoreName;
        private Label label2;
        private Label label1;
        private DataGridView dgvServices;
        private DataGridView dgvServiceDetails;
        private SplitContainer splitContainer1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label3;
        private SplitContainer splitContainer2;
        private Button button4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private TextBox txtDescription;
        private TextBox txtServiceName;
    }
}