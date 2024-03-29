﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodien
{
    public partial class Giaodiendangnhap : Form
    {
        public Giaodiendangnhap()
        {
            InitializeComponent();
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text;
            string password = txtPasswordLogin.Text;

            string connectionString = $"Server=localhost;Database=thongtintaikhoan;Integrated Security = True;";

            // Thực hiện xác thực tài khoản và mật khẩu từ cơ sở dữ liệu
            if (AuthenticateAccount(email, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                Lobby lobby = new Lobby();
                //lobby.SetLoggedInAccount(email);
                // Điều hướng đến giao diện chính hoặc trang khác tùy thuộc vào ứng dụng của bạn
                this.Hide();

                // Tạo một đối tượng mới của hộp thoại phòng chờ và truyền thông tin cần thiết
                Giaodienphongcho roomBox = new Giaodienphongcho(email, password, connectionString);

                // Hiển thị hộp thoại phòng chờ
                roomBox.ShowDialog();

                // Hiển thị lại giao diện đăng nhập khi người dùng đóng hộp thoại phòng chờ
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản không tồn tại.");
            }
        }
        protected bool AuthenticateAccount(string email, string password)
        {
            string connectionString = @"Data Source=LAPTOP-2RHCQVGG\BAOTRAN;Initial Catalog=thongtintaikhoan;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        return true; // Tài khoản hợp lệ
                    }
                    else
                    {
                        return false; // Tài khoản không hợp lệ
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Chuyển đến giao diện đăng ký khi người dùng nhấn nút Đăng ký
            Giaodiendangki Giaodiendangki = new Giaodiendangki();
            Giaodiendangki.Show();
        }
    }
}