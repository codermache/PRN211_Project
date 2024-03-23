using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace Lab_Reservation_System
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123;Trusted_Connection=True;Encrypt=False");
            try
            {
                conn.Open();
                string name = txtName.Text;
                int id = Int32.Parse(txtID.Text);
                string sql = "select * from Students where name = '" + name + "' and std_id = '" + id + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    Process.Start("\"C:\\Users\\ASUS\\source\\repos\\Lab Reservation System\\Program\\bin\\Debug\\net6.0-windows\\Program.exe\"");

                    // Close the login form
                    Close();

                }
                else
                {
                    MessageBox.Show("fail login");
                }
            }catch (Exception )
            {
                MessageBox.Show("Connection prblem");
            }


           
        }
    }
}
