using System.Text.RegularExpressions;
using MySqlConnector;

namespace FashionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = boxUsername.Text;
            string password = boxPassword.Text;

            const string usernameRegex = @"^[a-zA-Z0-9]+$";


            if (username == null || username == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "Thông báo");
                return;
            }

            if (password == null || password == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo");
                return;
            }

            if (!Regex.IsMatch(username, usernameRegex))
            {
                MessageBox.Show("Tài khoản chỉ được nhập chữ hoặc số", "Thông báo");
                return;
            }

            Database database = new Database();
            database.connect();
            bool result = database.login(username, password);

            if (result)
            {
                boxUsername.Text = "";
                boxPassword.Text = "";
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }


    }
}