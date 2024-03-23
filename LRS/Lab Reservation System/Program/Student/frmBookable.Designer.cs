namespace Program
{
    partial class frmBookable
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnOut = new Button();
            dataGridView2 = new DataGridView();
            cboDay = new ComboBox();
            cboSlot = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnAvailable = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(307, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(796, 399);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(112, 34);
            btnOut.TabIndex = 1;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(325, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(583, 300);
            dataGridView2.TabIndex = 2;
            // 
            // cboDay
            // 
            cboDay.FormattingEnabled = true;
            cboDay.Location = new Point(159, 344);
            cboDay.Name = "cboDay";
            cboDay.Size = new Size(160, 33);
            cboDay.TabIndex = 3;
            // 
            // cboSlot
            // 
            cboSlot.FormattingEnabled = true;
            cboSlot.Location = new Point(393, 347);
            cboSlot.Name = "cboSlot";
            cboSlot.Size = new Size(75, 33);
            cboSlot.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 347);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 5;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 350);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 6;
            label2.Text = "Slot";
            // 
            // btnAvailable
            // 
            btnAvailable.Location = new Point(573, 344);
            btnAvailable.Name = "btnAvailable";
            btnAvailable.Size = new Size(216, 34);
            btnAvailable.TabIndex = 7;
            btnAvailable.Text = "Show Available Labs";
            btnAvailable.UseVisualStyleBackColor = true;
            btnAvailable.Click += btnAvailable_Click;
            // 
            // frmBookable
            // 
            ClientSize = new Size(922, 445);
            Controls.Add(btnAvailable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboSlot);
            Controls.Add(cboDay);
            Controls.Add(dataGridView2);
            Controls.Add(btnOut);
            Controls.Add(dataGridView1);
            Name = "frmBookable";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOut;
        private DataGridView dataGridView2;
        private ComboBox cboDay;
        private ComboBox cboSlot;
        private Label label1;
        private Label label2;
        private Button btnAvailable;
    }
}
