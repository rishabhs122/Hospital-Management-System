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
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (username == "Rishabh" && password == "12345")
            {
                this.Hide();
                mainfile mf = new mainfile();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

        }
    }
}