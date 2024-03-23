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
using System.Xml.Linq;
using Program.Admin;
namespace Program
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"server =(local); database = PRN_Test_P; uid=sa;pwd=123456;Trusted_Connection=True;Encrypt=False");
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
                    frmBookable frm1 = new frmBookable();
                    frm1.Closed += (s, args) => this.Close();
                    this.Hide();
                    frm1.Show();
                    Program.Id = Int32.Parse(txtID.Text);
                }
                else if (Int32.Parse(txtID.Text) == 0   && txtName.Text == "admin" )
                {
                    frmMenu frmMenu = new frmMenu();
                    frmMenu.Closed += (s, args) => this.Close();
                    this.Hide();
                    frmMenu.Show();
                }
                else
                {
                    MessageBox.Show("fail login");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection prblem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
