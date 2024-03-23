namespace Program
{
    partial class frmAvailable
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
            dgvAvailable = new DataGridView();
            btnSave = new Button();
            txtId = new TextBox();
            txtAvailable = new TextBox();
            txtSlot = new TextBox();
            txtDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnReservation = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailable
            // 
            dgvAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailable.Location = new Point(255, 8);
            dgvAvailable.Margin = new Padding(2, 2, 2, 2);
            dgvAvailable.Name = "dgvAvailable";
            dgvAvailable.RowHeadersWidth = 62;
            dgvAvailable.RowTemplate.Height = 33;
            dgvAvailable.Size = new Size(575, 341);
            dgvAvailable.TabIndex = 0;
            dgvAvailable.SelectionChanged += dgvAvailable_SelectionChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(135, 311);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(69, 15);
            txtId.Margin = new Padding(2, 2, 2, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(156, 27);
            txtId.TabIndex = 2;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(69, 183);
            txtAvailable.Margin = new Padding(2, 2, 2, 2);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(156, 27);
            txtAvailable.TabIndex = 3;
            // 
            // txtSlot
            // 
            txtSlot.Location = new Point(69, 122);
            txtSlot.Margin = new Padding(2, 2, 2, 2);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(156, 27);
            txtSlot.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(69, 66);
            txtDate.Margin = new Padding(2, 2, 2, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(156, 27);
            txtDate.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "LabId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 8;
            label3.Text = "Slot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 9;
            label4.Text = "Available";
            // 
            // btnReservation
            // 
            btnReservation.Location = new Point(10, 311);
            btnReservation.Margin = new Padding(2, 2, 2, 2);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(110, 27);
            btnReservation.TabIndex = 10;
            btnReservation.Text = "To Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // frmAvailable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 360);
            Controls.Add(btnReservation);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDate);
            Controls.Add(txtSlot);
            Controls.Add(txtAvailable);
            Controls.Add(txtId);
            Controls.Add(btnSave);
            Controls.Add(dgvAvailable);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAvailable";
            Text = "AvailableLabs";
            Load += AvailableLabs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAvailable;
        private Button btnSave;
        private TextBox txtId;
        private TextBox txtAvailable;
        private TextBox txtSlot;
        private TextBox txtDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnReservation;
    }
}