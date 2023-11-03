using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FashionShop
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register(object sender, RoutedEventArgs e)
        {
            string username = inpUsername.Text;
            string password = inpPassword.Password;
            string passwordConfirm = inpPasswordConfirm.Password;
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

            if (passwordConfirm == null || passwordConfirm == "")
            {
                MessageBox.Show("Nhập lại mật khẩu không được để trống", "Thông báo");
                return;
            }

            if (!Regex.IsMatch(username, usernameRegex))
            {
                MessageBox.Show("Tài khoản chỉ được nhập chữ hoặc số", "Thông báo");
                return;
            }

            if (passwordConfirm != password)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác", "Thông báo");
                return;
            }

            MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo");
        }

        private void redirectToLogin(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
