using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Program
{
    public partial class frmAvailable : Form
    {

        public readonly string selectedDay;
        public readonly string selectedSlot;
        public frmAvailable(string Day, string slot)
        {
            InitializeComponent();
            selectedDay = Day;
            selectedSlot = slot;

        }

        private void AvailableLabs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123456;Trusted_Connection=True;Encrypt=False");
            try
            {
                conn.Open();
                string sql = "select * from Bookable_periods where week_day = '" + selectedDay + "' and slot_id = '" + selectedSlot + "' and no_available_computers > 0  ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable availableLabsDataTable = new DataTable();
                adapter.Fill(availableLabsDataTable);
                dgvAvailable.DataSource = availableLabsDataTable;
                //
                txtId.DataBindings.Clear();
                txtDate.DataBindings.Clear();
                txtSlot.DataBindings.Clear();
                txtAvailable.DataBindings.Clear();
                txtId.DataBindings.Add("Text", dgvAvailable.DataSource, "lab_id");
                txtDate.DataBindings.Add("Text", dgvAvailable.DataSource, "week_day");
                txtSlot.DataBindings.Add("Text", dgvAvailable.DataSource, "slot_id");
                txtAvailable.DataBindings.Add("Text", dgvAvailable.DataSource, "no_available_computers");



            }
            catch (Exception ex)
            {
                MessageBox.Show("load failed.Error details :" + ex.Message);
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int labId = Int32.Parse(txtId.Text);
            string weekDay = txtDate.Text;
            int slotId = Int32.Parse(txtSlot.Text);
            int stdId = Program.Id;
            SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123;Trusted_Connection=True;Encrypt=False");
            try
            {
                conn.Open();
                string sql = "INSERT INTO Reservations (lab_id, week_day, slot_id, std_id) VALUES ( '" + labId + "',  '" + weekDay + "',  '" + slotId + "',  '" + stdId + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                //
                string update = "UPDATE Bookable_periods SET no_available_computers = no_available_computers - 1 WHERE lab_id = '" + labId + "' AND week_day = '" + weekDay + "' AND slot_id = '" + slotId + "'";
                SqlCommand cmd2 = new SqlCommand(update, conn);
                SqlDataReader rdr2 = cmd.ExecuteReader();
                //



                //
                MessageBox.Show("Saved to Reservation.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("save failed.Error details :" + ex.Message);
            }


        }

        private void dgvAvailable_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            var Reservation = new frmReservation();
            Reservation.Show();
        }
    }
}
