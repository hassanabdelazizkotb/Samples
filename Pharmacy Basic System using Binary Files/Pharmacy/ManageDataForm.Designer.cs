namespace Pharmacy
{
    partial class ManageDataForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;

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
            txtId = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnClose = new Button();
            btnAdd = new Button();
            btnCreate = new Button();
            btnSearch = new Button();
            btnDisplay = new Button();
            btnDelete = new Button();
            lblFileName = new Label();
            lblId = new Label();
            lblName = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(100, 20);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(150, 23);
            txtFileName.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(100, 140);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(261, 180);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(97, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(177, 180);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(261, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(261, 100);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 8;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(261, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(20, 23);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(63, 15);
            lblFileName.TabIndex = 10;
            lblFileName.Text = "File Name:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 63);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 11;
            lblId.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 103);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 12;
            lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 143);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Price:";
            // 
            // ManageDataForm
            // 
            ClientSize = new Size(410, 253);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(lblFileName);
            Controls.Add(btnDelete);
            Controls.Add(btnDisplay);
            Controls.Add(btnSearch);
            Controls.Add(btnCreate);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(txtFileName);
            Name = "ManageDataForm";
            Text = "Manage Data";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
