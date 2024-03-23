using Microsoft.EntityFrameworkCore.Diagnostics;
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
namespace Program.Admin
{
    public partial class frmStudent : Form
    {
        PRN_Test_PContext _context = new PRN_Test_PContext();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                var std = _context.Students.ToList();
                dgvStudent.DataSource = std.Select(x => new
                {
                    x.StdId,
                    x.Name,
                    x.Address,
                    x.PhoneNumber
                }).ToList();
                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                //
                txtId.DataBindings.Add("Text", dgvStudent.DataSource, "StdId");
                txtName.DataBindings.Add("Text", dgvStudent.DataSource, "name");
                txtAddress.DataBindings.Add("Text", dgvStudent.DataSource, "address");
                txtPhone.DataBindings.Add("Text", dgvStudent.DataSource, "PhoneNumber");

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
                var result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedID = Int32.Parse(txtId.Text);
                    var student = _context.Students.FirstOrDefault(x => x.StdId == selectedID);
                    if (student != null)
                    {
                        _context.Students.Remove(student);
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

        public Student Getdata()
        {
            return new Student
            {
                StdId = Int32.Parse(txtId.Text),
                Name = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhone.Text,
            };
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtName.Text == null) { MessageBox.Show("Name can not be null", "infor"); return; }
            int x = 0;
            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {
                    Student tmp = Getdata();
                    _context.Students.Add(tmp);
                    _context.SaveChanges();
                    LoadData();
                }
            }


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == null) { MessageBox.Show("Id can not be null", "infor"); return; }
            if (txtName.Text == null) { MessageBox.Show("Name can not be null", "infor"); return; }
            int x = 0;
            if (Int32.TryParse(txtId.Text, out x))
            {
                if (x != 0)
                {
                    Student std = _context.Students.FirstOrDefault(c => c.StdId == x);
                    if (std != null)
                    {
                        std.Name = txtName.Text;
                        std.Address = txtAddress.Text;
                        std.PhoneNumber = txtPhone.Text;
                        _context.Students.Update(std);
                        _context.SaveChanges();
                        LoadData();
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from text boxes
                int stdId = string.IsNullOrWhiteSpace(txtSrId.Text) ? 0 : Int32.Parse(txtSrId.Text);
                string Name = txtSrName.Text;
                

                // 
                var matchingStudent = _context.Students
                    .Where(r =>
                        (stdId == 0 || r.StdId == stdId) &&
                        (string.IsNullOrEmpty(Name) || r.Name == Name) 

                    ).ToList();

                // 
                dgvStudent.DataSource = matchingStudent;

                // Clear existing data bindings
                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtPhone.DataBindings.Clear();

                // Set new data bindings
                txtId.DataBindings.Add("Text", dgvStudent.DataSource, "StdId");
                txtName.DataBindings.Add("Text", dgvStudent.DataSource, "Name");
                txtAddress.DataBindings.Add("Text", dgvStudent.DataSource, "Address");
                txtPhone.DataBindings.Add("Text", dgvStudent.DataSource, "PhoneNumber");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
