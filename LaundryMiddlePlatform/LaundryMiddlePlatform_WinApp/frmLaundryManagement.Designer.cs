namespace LaundryMiddlePlatform_WinApp
{
    partial class frmLaundryManagement
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
            btnStoreManagement = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 34);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Store Management";
            // 
            // btnStoreManagement
            // 
            btnStoreManagement.Location = new Point(294, 34);
            btnStoreManagement.Name = "btnStoreManagement";
            btnStoreManagement.Size = new Size(112, 34);
            btnStoreManagement.TabIndex = 1;
            btnStoreManagement.Text = "Go";
            btnStoreManagement.UseVisualStyleBackColor = true;
            btnStoreManagement.Click += btnStoreManagement_Click;
            // 
            // frmLaundryManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 234);
            Controls.Add(btnStoreManagement);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLaundryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laundry Management";
            FormClosed += frmLaundryManagement_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStoreManagement;
    }
}