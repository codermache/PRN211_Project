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

    public partial class frmLabs : Form
    {
        PRN_Test_PContext _context = new PRN_Test_PContext();
        public frmLabs()
        {
            InitializeComponent();
        }

        private void frmLabs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                var std = _context.Labs.ToList();
                dgvLabs.DataSource = std.Select(x => new
                {
                    x.LabId,
                    x.LabAddress,
                    x.NoComputers,
                }).ToList();
                txtId.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtComputer.DataBindings.Clear();

                txtId.DataBindings.Add("Text", dgvLabs.DataSource, "LabId");
                txtAddress.DataBindings.Add("Text", dgvLabs.DataSource, "LabAddress");
                txtComputer.DataBindings.Add("Text", dgvLabs.DataSource, "NoComputers");


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Lab Getdata()
        {
            return new Lab
            {
                LabId = Int32.Parse(txtId.Text),
                LabAddress = txtAddress.Text,
                NoComputers = Int32.Parse(txtComputer.Text),

            };
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtAddress.Text == null) { MessageBox.Show("Lab can not be null", "infor"); return; }
            int x = 0;
            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {

                    Lab tmp = Getdata();
                    _context.Labs.Add(tmp);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtAddress.Text == null) { MessageBox.Show("Lab can not be null", "infor"); return; }
            int x = 0;

            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {
                    Lab std = _context.Labs.FirstOrDefault(c => c.LabId == x);
                    if (std != null)
                    {
                        std.LabId = Int32.Parse(txtId.Text);
                        std.LabAddress = txtAddress.Text;
                        std.NoComputers = Int32.Parse(txtComputer.Text);
                        _context.Labs.Update(std);
                        _context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this Lab?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedID = Int32.Parse(txtId.Text);
                    var lab = _context.Labs.FirstOrDefault(x => x.LabId == selectedID);
                    if (lab != null)
                    {
                        _context.Labs.Remove(lab);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                string address = txtSrAddress.Text;

                var matchingStudent = _context.Labs
                    .Where(r =>(string.IsNullOrEmpty(address) || r.LabAddress == address)).ToList();
                dgvLabs.DataSource = matchingStudent;

                // Clear existing data bindings
                txtId.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtComputer.DataBindings.Clear();

                // Set new data bindings
                txtId.DataBindings.Add("Text", dgvLabs.DataSource, "LabId");
                txtAddress.DataBindings.Add("Text", dgvLabs.DataSource, "LabAddress");
                txtComputer.DataBindings.Add("Text", dgvLabs.DataSource, "NoComputers");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
