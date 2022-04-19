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
    public partial class addDoctor : Form
    {
        public addDoctor()
        {
            InitializeComponent();
        }
        String gender = "Male";
        private void dSave_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dId.Text;
                String name = dName.Text;
                int age = Convert.ToInt32(dAge.Text);
                Int64 contact = Convert.ToInt64(dContact.Text);
                String blood = dBlood.Text;
                String mode = dMode.Text;
                String address = dAddress.Text;
                String type = dType.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into addDoctors values ('" + id + "' ,'" + name + "' ," + age + ",'" + gender + "','" + address + "'," + contact + ",'" + blood + "','" + mode + "','" + type + "')";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
            }

            catch (Exception)
            {
                MessageBox.Show("Fill all the details");

            }
            dId.Clear();
            dName.Clear();
            dAge.Clear();
            dAddress.Clear();
            dContact.Clear();
            dMode.ResetText();
            dType.ResetText();
            dBlood.ResetText();
            

        }

        private void dExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard db = new dashboard();
            db.Show();
        }

        private void dGender_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Others";
        }

        private void addDoctor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
        }
    }
}
