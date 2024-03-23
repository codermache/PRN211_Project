namespace Program.Admin
{
    partial class frmStudent
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
            dgvStudent = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label5 = new Label();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnLoad = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtSrName = new TextBox();
            txtSrId = new TextBox();
            label7 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(437, 12);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.RowTemplate.Height = 33;
            dgvStudent.Size = new Size(653, 493);
            dgvStudent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 109);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 212);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 4;
            label4.Text = "Phone number";
            // 
            // txtId
            // 
            txtId.Location = new Point(138, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(229, 31);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 31);
            txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(138, 109);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(293, 91);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(138, 206);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(293, 31);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 72);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 243);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(319, 243);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(319, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 283);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSrId);
            groupBox1.Controls.Add(txtSrName);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(40, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 150);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 66);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 18;
            label6.Text = "Name";
            // 
            // txtSrName
            // 
            txtSrName.Location = new Point(154, 66);
            txtSrName.Name = "txtSrName";
            txtSrName.Size = new Size(195, 31);
            txtSrName.TabIndex = 17;
            // 
            // txtSrId
            // 
            txtSrId.Location = new Point(154, 20);
            txtSrId.Name = "txtSrId";
            txtSrId.Size = new Size(195, 31);
            txtSrId.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 26);
            label7.Name = "label7";
            label7.Size = new Size(28, 25);
            label7.TabIndex = 15;
            label7.Text = "Id";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(154, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(195, 34);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 517);
            Controls.Add(groupBox1);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudent);
            Name = "frmStudent";
            Text = "frmStudent";
            Load += frmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label5;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnLoad;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSrId;
        private TextBox txtSrName;
        private Label label7;
    }
}