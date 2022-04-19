using System.Data.SqlClient;

namespace HospitalMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from registration where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    dashboard db = new dashboard();
                    db.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPass fp = new ForgetPass();
            fp.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= LAPTOP-23Q7L7EC\\SQLEXPRESS5; database = hospitalms; integrated security=True ";
            con.Open();
        }
    }
}