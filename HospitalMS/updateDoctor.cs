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
    public partial class updateDoctor : Form
    {
        public updateDoctor()
        {
            InitializeComponent();
        }

        private void updateDoctor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
            idList();
        }

        public void idList()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " select id from addDoctors";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        String selectId;

        private void button2_Click(object sender, EventArgs e)
        {
            selectId = comboBox1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " select * from addDoctors where id='" + selectId + "'";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int64 contact = Convert.ToInt64(textBox1.Text);
            String mode = comboBox2.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update addDoctors SET contact = " + contact + ", mode = '" + mode + "' where id = '" + selectId + "' ";
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            textBox1.Clear();
            comboBox2.ResetText();

            MessageBox.Show("Updated.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard db = new dashboard();
            db.Show();
        }
    }
}
