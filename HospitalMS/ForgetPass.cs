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
    public partial class ForgetPass : Form
    {
        public ForgetPass()
        {
            InitializeComponent();
        }
       

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
            

        }
        

        private void btnSaveFP_Click(object sender, EventArgs e)
            
        {
            if (richTextBox2.Text != string.Empty || richTextBox3.Text != string.Empty || richTextBox1.Text != string.Empty)
            {
                if (richTextBox2.Text == richTextBox3.Text)
                {
                    String un = richTextBox1.Text;
                    String ps1 = richTextBox2.Text;
                    String ps2 = richTextBox3.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "update registration SET password = '" + ps1 + "' where username = '" + un + "' ";
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    
                    MessageBox.Show("Your Password has been reset. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                
                else
                    {
                        MessageBox.Show("Enter both password correctly ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
