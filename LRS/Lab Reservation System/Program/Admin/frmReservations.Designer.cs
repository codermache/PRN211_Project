namespace Program.Admin
{
    partial class frmReservations
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDate = new TextBox();
            txtSlot = new TextBox();
            txtStd = new TextBox();
            txtId = new TextBox();
            dgvReservation = new DataGridView();
            btnLoad = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            label5 = new Label();
            txtSrDate = new TextBox();
            label6 = new Label();
            txtSrLabId = new TextBox();
            label7 = new Label();
            txtSrStdId = new TextBox();
            label8 = new Label();
            txtSrSlot = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 120);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 20;
            label4.Text = "Student Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 19;
            label3.Text = "Slot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 50);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 18;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 17;
            label1.Text = "Lab Id";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(124, 47);
            txtDate.Margin = new Padding(2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(194, 31);
            txtDate.TabIndex = 16;
            // 
            // txtSlot
            // 
            txtSlot.Location = new Point(124, 82);
            txtSlot.Margin = new Padding(2);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(194, 31);
            txtSlot.TabIndex = 15;
            // 
            // txtStd
            // 
            txtStd.Location = new Point(124, 117);
            txtStd.Margin = new Padding(2);
            txtStd.Name = "txtStd";
            txtStd.Size = new Size(194, 31);
            txtStd.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(124, 12);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(194, 31);
            txtId.TabIndex = 13;
            // 
            // dgvReservation
            // 
            dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservation.Location = new Point(407, 14);
            dgvReservation.Margin = new Padding(2);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 62;
            dgvReservation.RowTemplate.Height = 33;
            dgvReservation.Size = new Size(778, 536);
            dgvReservation.TabIndex = 11;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(11, 225);
            btnLoad.Margin = new Padding(2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 44;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(238, 170);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 43;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(238, 225);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(11, 170);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 34);
            btnInsert.TabIndex = 41;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSrDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSrLabId);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSrStdId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSrSlot);
            groupBox1.Location = new Point(11, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 246);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(178, 197);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 34);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 131);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 53;
            label5.Text = "Student Id";
            // 
            // txtSrDate
            // 
            txtSrDate.Location = new Point(178, 58);
            txtSrDate.Margin = new Padding(2);
            txtSrDate.Name = "txtSrDate";
            txtSrDate.Size = new Size(194, 31);
            txtSrDate.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 99);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 25);
            label6.TabIndex = 52;
            label6.Text = "Slot";
            // 
            // txtSrLabId
            // 
            txtSrLabId.Location = new Point(178, 23);
            txtSrLabId.Margin = new Padding(2);
            txtSrLabId.Name = "txtSrLabId";
            txtSrLabId.Size = new Size(194, 31);
            txtSrLabId.TabIndex = 46;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 61);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 51;
            label7.Text = "Date";
            // 
            // txtSrStdId
            // 
            txtSrStdId.Location = new Point(178, 128);
            txtSrStdId.Margin = new Padding(2);
            txtSrStdId.Name = "txtSrStdId";
            txtSrStdId.Size = new Size(194, 31);
            txtSrStdId.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 26);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 25);
            label8.TabIndex = 50;
            label8.Text = "Lab Id";
            // 
            // txtSrSlot
            // 
            txtSrSlot.Location = new Point(178, 93);
            txtSrSlot.Margin = new Padding(2);
            txtSrSlot.Name = "txtSrSlot";
            txtSrSlot.Size = new Size(194, 31);
            txtSrSlot.TabIndex = 48;
            // 
            // frmReservations
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 562);
            Controls.Add(groupBox1);
            Controls.Add(btnLoad);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDate);
            Controls.Add(txtSlot);
            Controls.Add(txtStd);
            Controls.Add(txtId);
            Controls.Add(dgvReservation);
            Margin = new Padding(4);
            Name = "frmReservations";
            Text = "frmReservation";
            Load += frmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDate;
        private TextBox txtSlot;
        private TextBox txtStd;
        private TextBox txtId;
        private DataGridView dgvReservation;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label5;
        private TextBox txtSrDate;
        private Label label6;
        private TextBox txtSrLabId;
        private Label label7;
        private TextBox txtSrStdId;
        private Label label8;
        private TextBox txtSrSlot;
    }
}