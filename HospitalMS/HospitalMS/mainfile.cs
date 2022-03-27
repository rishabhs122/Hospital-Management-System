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
    public partial class mainfile : Form
    {
        public mainfile()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            txtAddDoctor.BackColor = System.Drawing.Color.LightGreen;
            txtViewDoctor.BackColor = System.Drawing.Color.LightBlue;
            txtAddPatient.BackColor = System.Drawing.Color.LightBlue;
            txtViewPatient.BackColor = System.Drawing.Color.LightBlue;
            mainPanel1.Visible = true;
            mainPanel2.Visible = false;
            mainPanel3.Visible = false;

        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            txtViewDoctor.BackColor = System.Drawing.Color.LightGreen;
            txtAddDoctor.BackColor = System.Drawing.Color.LightBlue;
            txtAddPatient.BackColor = System.Drawing.Color.LightBlue;
            txtViewPatient.BackColor = System.Drawing.Color.LightBlue;
            mainPanel3.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS02; database = hospital; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " select * from AddDoctor";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            txtAddPatient.BackColor = System.Drawing.Color.LightGreen;
            txtAddDoctor.BackColor = System.Drawing.Color.LightBlue;
            txtViewDoctor.BackColor = System.Drawing.Color.LightBlue;
            txtViewPatient.BackColor = System.Drawing.Color.LightBlue;
            mainPanel.Visible = true;
            mainPanel1.Visible = false;
            mainPanel2.Visible = false;
            mainPanel3.Visible = false;

        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            txtViewPatient.BackColor = System.Drawing.Color.LightGreen;
            txtAddDoctor.BackColor = System.Drawing.Color.LightBlue;
            txtViewDoctor.BackColor = System.Drawing.Color.LightBlue;
            txtAddPatient.BackColor = System.Drawing.Color.LightBlue;
            mainPanel2.Visible = true;
            mainPanel3.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS02; database = hospital; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " select * from AddPatient";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainfile_Load(object sender, EventArgs e)
        {
           mainPanel.Visible = false;
           mainPanel1.Visible = false;
           mainPanel2.Visible = false;
           mainPanel3.Visible = false;
        }

        private void pSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = pName.Text;
                int age = Convert.ToInt32(pAge.Text);
                String gender = pGender.Text;
                Int64 contact = Convert.ToInt64(pContact.Text);
                String address = pAddress.Text;
                String blood = pBlood.Text;
                String symptoms = pSymptoms.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS02; database = hospital; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values ('" + name + "' ," + age + ",'" + gender + "'," + contact + ",'" + address + "','" + blood + "','" + symptoms + "')";
                //cmd.CommandText = "insert into AddPatient values (@name,@age ,@gender, @contact, @address, @blood, @symptoms)";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");

            }

            pName.Clear();
            pAge.Clear();
            pGender.ResetText();
            pContact.Clear();
            pAddress.Clear();
            pBlood.ResetText();
            pSymptoms.Clear();
            

        }

        private void dSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = drName.Text;
                int age = Convert.ToInt32(drAge.Text);
                String address = drAddress.Text;
                String gender = drGender.Text;
                String blood = drBlood.Text;
                String type = drType.Text;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS02; database = hospital; integrated security=True ";
                SqlCommand cmnd = new SqlCommand();
                cmnd.Connection = conn;
                cmnd.CommandText = "insert into AddDoctor values ('" + name + "' ," + age + ",'" + address + "','" + gender + "','" + blood + "','" + type + "')";
                SqlDataAdapter adt = new SqlDataAdapter(cmnd);
                DataSet dst = new DataSet();
                adt.Fill(dst);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");

            }

            drName.Clear();
            drAge.Clear();
            drGender.ResetText();
            drAddress.Clear();
            drBlood.ResetText();
            drType.ResetText();

        }
    }
}
