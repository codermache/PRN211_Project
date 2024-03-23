using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Program.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Program.Admin
{
    public partial class frmReservations : Form
    {
        PRN_Test_PContext _context = new PRN_Test_PContext();
        public frmReservations()
        {
            InitializeComponent();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                var std = _context.Reservations.ToList();
                dgvReservation.DataSource = std.Select(x => new
                {
                    x.LabId,
                    x.WeekDay,
                    x.SlotId,
                    x.StdId
                }).ToList();
                txtId.DataBindings.Clear();
                txtDate.DataBindings.Clear();
                txtSlot.DataBindings.Clear();
                txtStd.DataBindings.Clear();

                txtId.DataBindings.Add("Text", dgvReservation.DataSource, "LabId");
                txtDate.DataBindings.Add("Text", dgvReservation.DataSource, "WeekDay");
                txtSlot.DataBindings.Add("Text", dgvReservation.DataSource, "SlotId");
                txtStd.DataBindings.Add("Text", dgvReservation.DataSource, "StdId");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this Reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedID = Int32.Parse(txtId.Text);
                    var reservation = _context.Reservations.FirstOrDefault(x => x.LabId == selectedID);
                    if (reservation != null)
                    {
                        _context.Reservations.Remove(reservation);
                        _context.SaveChanges();
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public Reservation Getdata()
        {
            return new Reservation
            {
                LabId = Int32.Parse(txtId.Text),
                WeekDay = txtDate.Text,
                SlotId = Int32.Parse(txtSlot.Text),
                StdId = Int32.Parse(txtStd.Text),
            };
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtStd.Text == null) { MessageBox.Show("student Id can not be null", "infor"); return; }
            int x = 0;
            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {
                    Reservation res = _context.Reservations.FirstOrDefault(c => c.LabId == x);
                    //
                    Reservation oldReservation = new Reservation();
                    oldReservation.LabId = Int32.Parse(txtId.Text);
                    oldReservation.WeekDay = txtDate.Text;
                    oldReservation.SlotId = Int32.Parse(txtSlot.Text);
                    oldReservation.StdId = Int32.Parse(txtStd.Text);

                    //
                    if (res != null)
                    {
                        bool labIdChanged = res.LabId != Int32.Parse(txtId.Text);
                        bool weekDayChanged = res.WeekDay != txtDate.Text;
                        bool slotIdChanged = res.SlotId != Int32.Parse(txtSlot.Text);

                        //Update
                        res.LabId = Int32.Parse(txtId.Text);
                        res.WeekDay = txtDate.Text;
                        res.SlotId = Int32.Parse(txtSlot.Text);
                        res.StdId = Int32.Parse(txtStd.Text);
                        //check
                        if (labIdChanged || weekDayChanged || slotIdChanged)
                        {
                            UpdateNoAvailableComputers(res, oldReservation);
                        }


                        //Update database
                        _context.Reservations.Update(res);
                        _context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        public void UpdateNoAvailableComputers(Reservation res, Reservation oldReservation)
        {
            int oldSlotId = res.SlotId;
            int newSlotId = oldReservation.SlotId;

            // Update no_available_computer for the old slot
            var oldBookablePeriod = _context.BookablePeriods.FirstOrDefault(bp => bp.LabId == oldReservation.LabId && bp.WeekDay == oldReservation.WeekDay && bp.SlotId == oldSlotId);
            if (oldBookablePeriod != null)
            {
                oldBookablePeriod.NoAvailableComputers++;
            }

            // Update no_available_computer for the new slot
            var newBookablePeriod = _context.BookablePeriods.FirstOrDefault(bp => bp.LabId == oldReservation.LabId && bp.WeekDay == oldReservation.WeekDay && bp.SlotId == newSlotId);
            if (newBookablePeriod != null)
            {
                newBookablePeriod.NoAvailableComputers--;
            }


        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtStd.Text == null) { MessageBox.Show("Available can not be null", "infor"); return; }
            int x = 0;
            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {
                    // Lấy thông tin về bookable_period
                    int bookablePeriodId = Int32.Parse(txtId.Text);
                    BookablePeriod bookablePeriod = _context.BookablePeriods.FirstOrDefault(bp => bp.NoAvailableComputers == bookablePeriodId);

                    // Kiểm tra nếu bookablePeriod không tồn tại
                    if (bookablePeriod == null)
                    {
                        MessageBox.Show("No Bookable Period ", "Information");
                        return;
                    }

                    // Kiểm tra số lượng slot còn trống
                    if (bookablePeriod.NoAvailableComputers == 0)
                    {
                        MessageBox.Show("No available slots in this bookable period", "Information");
                        return;
                    }
                    Reservation tmp = Getdata();
                    _context.Reservations.Add(tmp);
                    _context.SaveChanges();
                    LoadData();
                    //
                    string selectedLabs = txtId.Text;
                    string selectedDay = txtDate.Text;
                    string selectedSlot = txtSlot.Text;
                    SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123;Trusted_Connection=True;Encrypt=False");
                    conn.Open();
                    string update = "UPDATE BookablePeriod SET no_available_computers = no_available_computers - 1 WHERE lab_id = '" + selectedLabs + "' AND week_day = '" + selectedDay + "' AND slot_id = '" + selectedSlot + "'";
                    SqlCommand cmd = new SqlCommand(update, conn);
                    SqlDataReader rdr2 = cmd.ExecuteReader();


                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {               
                    // Retrieve values from text boxes
                    int labId = string.IsNullOrWhiteSpace(txtSrLabId.Text) ? 0 : Int32.Parse(txtSrLabId.Text);
                    string weekDay = txtSrDate.Text;
                    int slotId = string.IsNullOrWhiteSpace(txtSrSlot.Text) ? 0 : Int32.Parse(txtSrSlot.Text);
                    int studentId = string.IsNullOrWhiteSpace(txtSrStdId.Text) ? 0 : Int32.Parse(txtSrStdId.Text);

                    // 
                    var matchingReservations = _context.Reservations
                        .Where(r =>
                            (labId == 0 || r.LabId == labId) &&
                            (string.IsNullOrEmpty(weekDay) || r.WeekDay == weekDay) &&
                            (slotId == 0 || r.SlotId == slotId) &&
                            (studentId == 0 || r.StdId == studentId))
                        .ToList();

                    // Display the matching reservations in data grid view
                    dgvReservation.DataSource = matchingReservations;
                    //
                    txtId.DataBindings.Clear();
                    txtDate.DataBindings.Clear();
                    txtSlot.DataBindings.Clear();
                    txtStd.DataBindings.Clear();
                    //
                    txtId.DataBindings.Add("Text", dgvReservation.DataSource, "LabId");
                    txtDate.DataBindings.Add("Text", dgvReservation.DataSource, "WeekDay");
                    txtSlot.DataBindings.Add("Text", dgvReservation.DataSource, "SlotId");
                    txtStd.DataBindings.Add("Text", dgvReservation.DataSource, "StdId");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        
    }
}
