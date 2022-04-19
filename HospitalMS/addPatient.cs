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
    public partial class addPatient : Form
    {
        public addPatient()
        {
            InitializeComponent();
        }

        String gender = "Male";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Others";
        }

        private void pSave_Click(object sender, EventArgs e)
        {
            try
            {
                String id = pId.Text;
                String name = pName.Text;
                int age = Convert.ToInt32(pAge.Text);
                Int64 contact = Convert.ToInt64(pContact.Text);
                String address = pAddress.Text;
                String blood = pBlood.Text;
                String mode = pMode.Text;
                String symptoms = pSymptoms.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatient values ('" + id + "' ,'" + name + "' ," + age + ",'" + gender + "'," + contact + ",'" + address + "','" + blood + "','" + mode + "','" + symptoms + "')";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all the details");

            }
            pId.Clear();
            pName.Clear();
            pAge.Clear();
            pContact.Clear();
            pAddress.Clear();
            pBlood.ResetText();
            pMode.ResetText();
            pSymptoms.Clear();

        }

        private void pExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard db = new dashboard();
            db.Show();
        }

        private void addPatient_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
        }
    }
}
