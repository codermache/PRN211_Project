namespace Program.Admin
{
    partial class frmSlot
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
            dgvSlot = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            label6 = new Label();
            txtSSlotId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSlot).BeginInit();
            SuspendLayout();
            // 
            // dgvSlot
            // 
            dgvSlot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlot.Location = new Point(309, 22);
            dgvSlot.Margin = new Padding(2);
            dgvSlot.Name = "dgvSlot";
            dgvSlot.RowHeadersWidth = 62;
            dgvSlot.RowTemplate.Height = 33;
            dgvSlot.Size = new Size(455, 321);
            dgvSlot.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "SlotId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "From Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 131);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "To Time";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 18);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 27);
            txtId.TabIndex = 4;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(105, 62);
            txtFrom.Margin = new Padding(2);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(150, 27);
            txtFrom.TabIndex = 5;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(105, 131);
            txtTo.Margin = new Padding(2);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(150, 27);
            txtTo.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 208);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(104, 208);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(198, 208);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(88, 316);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(156, 27);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 266);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 21;
            label6.Text = "SlotId";
            // 
            // txtSSlotId
            // 
            txtSSlotId.Location = new Point(87, 266);
            txtSSlotId.Margin = new Padding(2);
            txtSSlotId.Name = "txtSSlotId";
            txtSSlotId.Size = new Size(157, 27);
            txtSSlotId.TabIndex = 20;
            // 
            // frmSlot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 360);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(txtSSlotId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSlot);
            Margin = new Padding(2);
            Name = "frmSlot";
            Text = "frmSlot";
            Load += frmSlot_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSlot;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Label label6;
        private TextBox txtSSlotId;
    }
}