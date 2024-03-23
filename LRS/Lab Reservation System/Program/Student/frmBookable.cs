using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Program.Models;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Program
{
    public partial class frmBookable : Form
    {
        private readonly PRN_Test_PContext _context = new PRN_Test_PContext();
        public frmBookable()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            var weekDay = _context.WeekDays.ToList();
            var timeSlot = _context.TimeSlots.ToList();
            dataGridView1.DataSource = weekDay.Select(x => new
            {
                x.WeekDay1,
                x.Date,


            }).ToList();
            dataGridView2.DataSource = timeSlot.Select(x => new
            {
                x.SlotId,
                x.FromTime,
                x.ToTime,
            }).ToList();
            cboDay.DataSource = _context.WeekDays.ToList();
            cboSlot.DataSource = _context.TimeSlots.ToList();



        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.AutoResizeColumns();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            string selectedDay = cboDay.SelectedItem.ToString();
            string selectedSlot = cboSlot.SelectedItem.ToString();

            var available = new frmAvailable(selectedDay, selectedSlot);
            available.Show();
        }
    }
}
