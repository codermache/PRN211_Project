namespace Program
{
    partial class frmReservation
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
            dgvReservation = new DataGridView();
            btnDelete = new Button();
            txtLabId = new TextBox();
            txtSlotId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAddress = new TextBox();
            txtFTime = new TextBox();
            dtpDate = new DateTimePicker();
            txtTTime = new TextBox();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtWeekDay = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReservation
            // 
            dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservation.Location = new Point(491, 9);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 62;
            dgvReservation.RowTemplate.Height = 33;
            dgvReservation.Size = new Size(491, 362);
            dgvReservation.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(870, 404);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtLabId
            // 
            txtLabId.Location = new Point(162, 30);
            txtLabId.Name = "txtLabId";
            txtLabId.Size = new Size(295, 31);
            txtLabId.TabIndex = 3;
            // 
            // txtSlotId
            // 
            txtSlotId.Location = new Point(148, 33);
            txtSlotId.Name = "txtSlotId";
            txtSlotId.Size = new Size(295, 31);
            txtSlotId.TabIndex = 4;
            txtSlotId.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 36);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 6;
            label2.Text = "Lab Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 36);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 7;
            label3.Text = "Slot Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 49);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 8;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 77);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(162, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(295, 31);
            txtAddress.TabIndex = 11;
            // 
            // txtFTime
            // 
            txtFTime.Location = new Point(148, 80);
            txtFTime.Name = "txtFTime";
            txtFTime.Size = new Size(295, 31);
            txtFTime.TabIndex = 12;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(107, 49);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(362, 31);
            dtpDate.TabIndex = 13;
            // 
            // txtTTime
            // 
            txtTTime.Location = new Point(148, 135);
            txtTTime.Name = "txtTTime";
            txtTTime.Size = new Size(295, 31);
            txtTTime.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 86);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 15;
            label6.Text = "From";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 141);
            label7.Name = "label7";
            label7.Size = new Size(30, 25);
            label7.TabIndex = 16;
            label7.Text = "To";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSlotId);
            groupBox1.Controls.Add(txtTTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFTime);
            groupBox1.Location = new Point(12, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 178);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLabId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAddress);
            groupBox2.Location = new Point(12, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 150);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Location";
            // 
            // txtWeekDay
            // 
            txtWeekDay.Location = new Point(107, 15);
            txtWeekDay.Name = "txtWeekDay";
            txtWeekDay.Size = new Size(362, 31);
            txtWeekDay.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 19;
            label1.Text = "Week day";
            // 
            // button1
            // 
            button1.Location = new Point(491, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 20;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtWeekDay);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(dgvReservation);
            Name = "frmReservation";
            Text = "frmReservation";
            Load += frmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservation;
        private Button btnDelete;
        private TextBox txtLabId;
        private TextBox txtSlotId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtAddress;
        private TextBox txtFTime;
        private DateTimePicker dtpDate;
        private TextBox txtTTime;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtWeekDay;
        private Label label1;
        private Button button1;
    }
}