using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = boxUsername.Text;
            string password = boxPassword.Text;
            string confirmPassword = boxConfirmPassword.Text;

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

            if (confirmPassword == null || confirmPassword == "")
            {
                MessageBox.Show("Nhập lại mật khẩu không được để trống", "Thông báo");
                return;
            }

            if (confirmPassword != password)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
                return;
            }

            if (!Regex.IsMatch(username, usernameRegex))
            {
                MessageBox.Show("Tài khoản chỉ được nhập chữ hoặc số", "Thông báo");
                return;
            }

            Database database = new Database();
            database.connect();
            bool result = database.register(username, password);

            if (result)
            {
                boxUsername.Text = "";
                boxPassword.Text = "";
                boxConfirmPassword.Text = "";
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
