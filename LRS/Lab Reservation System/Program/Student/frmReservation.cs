
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace Program
{
    public partial class frmReservation : Form
    {

        public frmReservation()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123;Trusted_Connection=True;Encrypt=False");
            try
            {
                conn.Open();
                int stdId = Program.Id;
                string sql = "SELECT Reservations.lab_id,lab_address,Reservations.week_day,date,Reservations.slot_id,from_time,to_time FROM Reservations JOIN Week_days ON Reservations.week_day = Week_days.week_day join Labs ON Reservations.lab_id = Labs.lab_id join Time_slots on Reservations.slot_id = Time_slots.slot_id where Reservations.std_id = '" + stdId + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable availableLabsDataTable = new DataTable();
                adapter.Fill(availableLabsDataTable);
                dgvReservation.DataSource = availableLabsDataTable;
                //

                //
                txtLabId.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                dtpDate.DataBindings.Clear();
                txtSlotId.DataBindings.Clear();
                txtFTime.DataBindings.Clear();
                txtWeekDay.DataBindings.Clear();
                txtLabId.DataBindings.Add("Text", dgvReservation.DataSource, "lab_id");
                txtAddress.DataBindings.Add("Text", dgvReservation.DataSource, "lab_address");
                dtpDate.DataBindings.Add("Value", dgvReservation.DataSource, "date");
                txtSlotId.DataBindings.Add("Text", dgvReservation.DataSource, "slot_id");
                txtFTime.DataBindings.Add("Text", dgvReservation.DataSource, "from_time");
                txtTTime.DataBindings.Add("Text", dgvReservation.DataSource, "to_time");
                txtWeekDay.DataBindings.Add("Text", dgvReservation.DataSource, "week_day");
                //

            }
            catch (Exception ex)
            {
                MessageBox.Show("load failed.Error details :" + ex.Message);
            }
        }


        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123456;Trusted_Connection=True;Encrypt=False");


            try
            {
                conn.Open();
                string selectedDay = txtWeekDay.Text;
                string selectedSlot = txtSlotId.Text;
                string selectedLabs = txtLabId.Text;
                int stdId = Program.Id;
                string sql = "DELETE FROM Reservations WHERE week_day = '" + selectedDay + "'  AND slot_id = '" + selectedSlot + "'  AND std_id = '" + stdId + "' AND lab_id = '" + selectedLabs + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
                //
                string update = "UPDATE BookablePeriod SET no_available_computers = no_available_computers + 1 WHERE lab_id = '" + selectedLabs + "' AND week_day = '" + selectedDay + "' AND slot_id = '" + selectedSlot + "'";
                SqlCommand cmd2 = new SqlCommand(update, conn);
                SqlDataReader rdr2 = cmd2.ExecuteReader();

                //
                MessageBox.Show("Delete successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("delete failed.Error details :" + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           LoadData();
        }
    }
}
