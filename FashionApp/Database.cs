using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionApp
{
    internal class Database
    {
        private MySqlConnection connection;

        private string informationDatabase = "server=localhost;port=3306;database=fashion_shop;uid=root;pwd=";

        public void connect()
        {
            this.connection = new MySqlConnection(this.informationDatabase);
            this.connection.Open();
        }

        public bool login(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM accounts WHERE username='"+username+"' AND password = '"+password+"'", this.connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                return true;
            }

            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
            return false;
        }

        public bool register(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM accounts WHERE username='" + username + "'", this.connection);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                return false;
            }
            reader.Close();

            command = new MySqlCommand("INSERT INTO accounts (username, password) VALUES (@username, @password)", this.connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.ExecuteNonQuery();


            MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo");
            return true;
        }
    }
}
