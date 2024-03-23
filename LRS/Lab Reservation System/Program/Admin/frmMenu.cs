using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program.Admin
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudent frmStudent = new frmStudent();
            frmStudent.ShowDialog();
        }

        private void showTimeSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSlot frmSlot = new frmSlot();
            frmSlot.ShowDialog();
        }

        private void showWeekDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLabs frmLabs = new frmLabs();
            frmLabs.ShowDialog();
        }

        private void showReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservations frmReservation = new frmReservations();
            frmReservation.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
