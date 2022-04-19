using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospital; integrated security=True ";
            con.Open();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            btnUpdateDoctor.BackColor = System.Drawing.Color.LightGreen;
            btnAddDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnViewDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnViewPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnUpdatePatient.BackColor = System.Drawing.Color.DarkGreen;
            this.Hide();
            updateDoctor ud = new updateDoctor();
            ud.Show();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            btnUpdateDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddPatient.BackColor = System.Drawing.Color.LightGreen;
            btnViewDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnViewPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnUpdatePatient.BackColor = System.Drawing.Color.DarkGreen;
            this.Hide();
            addPatient ap = new addPatient();
            ap.Show();


        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            btnUpdateDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddDoctor.BackColor = System.Drawing.Color.LightGreen;
            btnAddPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnViewDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnViewPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnUpdatePatient.BackColor = System.Drawing.Color.DarkGreen;
            this.Hide();
            addDoctor ad = new addDoctor();
            ad.Show();

        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            btnUpdateDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnViewDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnViewPatient.BackColor = System.Drawing.Color.LightGreen;
            btnUpdatePatient.BackColor = System.Drawing.Color.DarkGreen;

            this.Hide();
            viewPatient vp = new viewPatient();
            vp.Show();
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            btnUpdateDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnViewDoctor.BackColor = System.Drawing.Color.LightGreen;
            btnViewPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnUpdatePatient.BackColor = System.Drawing.Color.DarkGreen;

            this.Hide();
            viewDoctor vd = new viewDoctor();
            vd.Show();

        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            btnUpdateDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnAddPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnViewDoctor.BackColor = System.Drawing.Color.DarkGreen;
            btnViewPatient.BackColor = System.Drawing.Color.DarkGreen;
            btnUpdatePatient.BackColor = System.Drawing.Color.LightGreen;

            this.Hide();
            updatePatient up = new updatePatient();
            up.Show();
        }
    }
}
