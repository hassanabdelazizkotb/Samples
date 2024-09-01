namespace Pharmacy
{
    partial class DisplayDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDisplay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFileName = new TextBox();
            txtAll = new TextBox();
            btnExit = new Button();
            btnBack = new Button();
            btnDisplay = new Button();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(20, 22);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(280, 23);
            txtFileName.TabIndex = 0;
            // 
            // txtAll
            // 
            txtAll.Location = new Point(20, 60);
            txtAll.Multiline = true;
            txtAll.Name = "txtAll";
            txtAll.ScrollBars = ScrollBars.Vertical;
            txtAll.Size = new Size(280, 150);
            txtAll.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(225, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 220);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(125, 220);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 4;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // DisplayDataForm
            // 
            ClientSize = new Size(320, 261);
            Controls.Add(btnDisplay);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(txtAll);
            Controls.Add(txtFileName);
            Name = "DisplayDataForm";
            Text = "Display Data";
            Load += DisplayDataForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
