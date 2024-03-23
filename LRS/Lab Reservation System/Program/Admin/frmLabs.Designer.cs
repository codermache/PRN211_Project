namespace Program.Admin
{
    partial class frmLabs
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
            dgvLabs = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtComputer = new TextBox();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtSrAddress = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLabs).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLabs
            // 
            dgvLabs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLabs.Location = new Point(352, 113);
            dgvLabs.Margin = new Padding(2);
            dgvLabs.Name = "dgvLabs";
            dgvLabs.RowHeadersWidth = 62;
            dgvLabs.RowTemplate.Height = 33;
            dgvLabs.Size = new Size(603, 341);
            dgvLabs.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 32;
            label1.Text = "LabId";
            // 
            // txtId
            // 
            txtId.Location = new Point(131, 43);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(156, 27);
            txtId.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 113);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 34;
            label2.Text = "Lab Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(131, 110);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(156, 27);
            txtAddress.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 180);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 36;
            label3.Text = "No. Computers";
            // 
            // txtComputer
            // 
            txtComputer.Location = new Point(131, 177);
            txtComputer.Margin = new Padding(2);
            txtComputer.Name = "txtComputer";
            txtComputer.Size = new Size(156, 27);
            txtComputer.TabIndex = 35;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(38, 347);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 27);
            btnLoad.TabIndex = 40;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(217, 290);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(217, 347);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(38, 290);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(90, 27);
            btnInsert.TabIndex = 37;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSrAddress);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(352, 21);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(603, 85);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(387, 37);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 27);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSrAddress
            // 
            txtSrAddress.Location = new Point(168, 37);
            txtSrAddress.Margin = new Padding(2);
            txtSrAddress.Name = "txtSrAddress";
            txtSrAddress.Size = new Size(157, 27);
            txtSrAddress.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 37);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 15;
            label7.Text = "Lab Address";
            // 
            // frmLabs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 468);
            Controls.Add(groupBox1);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(txtComputer);
            Controls.Add(label2);
            Controls.Add(txtAddress);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(dgvLabs);
            Name = "frmLabs";
            Text = "frmLabs";
            Load += frmLabs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLabs).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLabs;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtComputer;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSrAddress;
        private Label label7;
    }
}