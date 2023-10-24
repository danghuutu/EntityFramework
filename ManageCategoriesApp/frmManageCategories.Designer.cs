namespace ManageCategoriesApp
{
    partial class frmManageCategories
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
            lbCategoryID = new Label();
            lbCategoryName = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            dgvCategories = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(45, 32);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(84, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "CategoryID";
            // 
            // lbCategoryName
            // 
            lbCategoryName.AutoSize = true;
            lbCategoryName.Location = new Point(45, 80);
            lbCategoryName.Name = "lbCategoryName";
            lbCategoryName.Size = new Size(109, 20);
            lbCategoryName.TabIndex = 1;
            lbCategoryName.Text = "CategoryName";
            // 
            // txtCategoryID
            // 
            txtCategoryID.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryID.Location = new Point(191, 25);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(285, 27);
            txtCategoryID.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(191, 73);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(285, 27);
            txtCategoryName.TabIndex = 3;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(45, 129);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.RowTemplate.Height = 29;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(431, 188);
            dgvCategories.TabIndex = 4;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.Location = new Point(45, 358);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(220, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(382, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmManageCategories
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(537, 434);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvCategories);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(lbCategoryName);
            Controls.Add(lbCategoryID);
            Name = "frmManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += frmManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoryID;
        private Label lbCategoryName;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private DataGridView dgvCategories;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}