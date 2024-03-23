namespace Program.Admin
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            systemToolStripMenuItem = new ToolStripMenuItem();
            showStudentsToolStripMenuItem = new ToolStripMenuItem();
            showTimeSlotToolStripMenuItem = new ToolStripMenuItem();
            showWeekDayToolStripMenuItem = new ToolStripMenuItem();
            showReservationToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(749, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { systemToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(5, 2, 0, 2);
            menuStrip2.Size = new Size(749, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            menuStrip2.ItemClicked += menuStrip2_ItemClicked;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showStudentsToolStripMenuItem, showTimeSlotToolStripMenuItem, showWeekDayToolStripMenuItem, showReservationToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(70, 24);
            systemToolStripMenuItem.Text = "System";
            // 
            // showStudentsToolStripMenuItem
            // 
            showStudentsToolStripMenuItem.Name = "showStudentsToolStripMenuItem";
            showStudentsToolStripMenuItem.Size = new Size(213, 26);
            showStudentsToolStripMenuItem.Text = "Show Students";
            showStudentsToolStripMenuItem.Click += showStudentsToolStripMenuItem_Click;
            // 
            // showTimeSlotToolStripMenuItem
            // 
            showTimeSlotToolStripMenuItem.Name = "showTimeSlotToolStripMenuItem";
            showTimeSlotToolStripMenuItem.Size = new Size(213, 26);
            showTimeSlotToolStripMenuItem.Text = "Show Time Slot";
            showTimeSlotToolStripMenuItem.Click += showTimeSlotToolStripMenuItem_Click;
            // 
            // showWeekDayToolStripMenuItem
            // 
            showWeekDayToolStripMenuItem.Name = "showWeekDayToolStripMenuItem";
            showWeekDayToolStripMenuItem.Size = new Size(213, 26);
            showWeekDayToolStripMenuItem.Text = "Show Labs";
            showWeekDayToolStripMenuItem.Click += showWeekDayToolStripMenuItem_Click;
            // 
            // showReservationToolStripMenuItem
            // 
            showReservationToolStripMenuItem.Name = "showReservationToolStripMenuItem";
            showReservationToolStripMenuItem.Size = new Size(213, 26);
            showReservationToolStripMenuItem.Text = "Show Reservation ";
            showReservationToolStripMenuItem.Click += showReservationToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 360);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmMenu";
            Text = "frmMenu";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem showStudentsToolStripMenuItem;
        private ToolStripMenuItem showTimeSlotToolStripMenuItem;
        private ToolStripMenuItem showWeekDayToolStripMenuItem;
        private ToolStripMenuItem showReservationToolStripMenuItem;
    }
}