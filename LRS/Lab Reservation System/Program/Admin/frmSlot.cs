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
    public partial class frmSlot : Form
    {
        PRN_Test_PContext _context = new PRN_Test_PContext();
        public frmSlot()
        {
            InitializeComponent();
        }

        private void frmSlot_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                var std = _context.TimeSlots.ToList();
                dgvSlot.DataSource = std.Select(x => new
                {
                    x.SlotId,
                    x.FromTime,
                    x.ToTime,
                }).ToList();
                txtId.DataBindings.Clear();
                txtFrom.DataBindings.Clear();
                txtTo.DataBindings.Clear();

                //
                txtId.DataBindings.Add("Text", dgvSlot.DataSource, "slotId");
                txtFrom.DataBindings.Add("Text", dgvSlot.DataSource, "FromTime");
                txtTo.DataBindings.Add("Text", dgvSlot.DataSource, "ToTime");


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public TimeSlot Getdata()
        {
            return new TimeSlot
            {
                SlotId = Int32.Parse(txtId.Text),
                FromTime = TimeSpan.Parse(txtFrom.Text),
                ToTime = TimeSpan.Parse(txtTo.Text)
            };
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtFrom.Text == null) { MessageBox.Show("Slot need to start from a certain time", "infor"); return; }
            if (txtTo.Text == null) { MessageBox.Show("Slot need to end at a certain time", "infor"); return; }
            int x = 0;
            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {
                    TimeSlot tmp = Getdata();
                    _context.TimeSlots.Add(tmp);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from text boxes
                int stdId = string.IsNullOrWhiteSpace(txtSSlotId.Text) ? 0 : Int32.Parse(txtSSlotId.Text);
                


                // 
                var matchingStudent = _context.TimeSlots
                    .Where(r =>(stdId == 0 || r.SlotId == stdId)).ToList();

                // 
                dgvSlot.DataSource = matchingStudent;

                // Clear existing data bindings
                txtId.DataBindings.Clear();
                txtFrom.DataBindings.Clear();
                txtTo.DataBindings.Clear();
   

                // Set new data bindings  
                txtId.DataBindings.Add("Text", dgvSlot.DataSource, "SlotId");
                txtFrom.DataBindings.Add("Text", dgvSlot.DataSource, "FromTime");
                txtTo.DataBindings.Add("Text", dgvSlot.DataSource, "ToTime");

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
