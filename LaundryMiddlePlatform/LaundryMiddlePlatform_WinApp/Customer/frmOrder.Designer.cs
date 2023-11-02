namespace LaundryMiddlePlatform_WinApp.Customer
{
    partial class frmOrder
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
            groupBox2 = new GroupBox();
            gbInformation = new GroupBox();
            groupBox1 = new GroupBox();
            lbOrderTitle = new Label();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(1, 364);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1359, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox1";
            // 
            // gbInformation
            // 
            gbInformation.Location = new Point(1, 65);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new Size(787, 125);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "groupBox1";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(1, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbOrderTitle
            // 
            lbOrderTitle.AutoSize = true;
            lbOrderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbOrderTitle.Location = new Point(1023, 65);
            lbOrderTitle.Name = "lbOrderTitle";
            lbOrderTitle.Size = new Size(172, 41);
            lbOrderTitle.TabIndex = 1;
            lbOrderTitle.Text = "Order Title";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 510);
            Controls.Add(lbOrderTitle);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(gbInformation);
            Name = "frmOrder";
            Text = "frmOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox gbInformation;
        private GroupBox groupBox1;
        private Label lbOrderTitle;
    }
}