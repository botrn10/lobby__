using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Giaodien
{
    public partial class Giaodiendangki : Form
    {
     
        public Giaodiendangki()
        {
            InitializeComponent();
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtPasswordConfirm.Text;
            string query = "INSERT INTO Users (Email, Password, ConfirmPassword) VALUES (@Email, @Password, @ConfirmPassword)";
            Command(query, email, password, confirmPassword);

            // Kiểm tra định dạng email hợp lệ
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email của trường.");
                return;
            }

            // Kiểm tra độ dài mật khẩu
            if (password.Length < 5)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 5 ký tự.");
                return;
            }

            // Kiểm tra mật khẩu và nhập lại mật khẩu có trùng khớp
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                return;
            }

            // Nếu dữ liệu hợp lệ, hiển thị thông báo đăng ký thành công và đóng form đăng ký
            if (SaveAccount(email, password))
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close(); // Đóng form đăng ký
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu tài khoản.");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string emailPattern = @"^[\w-]+(?:\.[\w-]+)*@(st\.)?ueh\.edu\.vn$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool SaveAccount(string email, string password)
        {
            string connectionString = @"Data Source = LAPTOP - 2RHCQVGG\BAOTRAN; Initial Catalog = thongtintaikhoan; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Thêm tài khoản vào bảng Users
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }

                    // Đóng kết nối sau khi thêm dữ liệu
                    connection.Close();

                    return true;
                }
                }
            catch
            {
                MessageBox.Show("Lỗi khi thực hiện thêm tài khoản.");
                return false;

            }
        }
        public void Command(string query, string email, string password, string confirmPassword)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Email", email);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.Parameters.AddWithValue("@ConfirmPassword", confirmPassword);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
    class Connection
    {
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winform-App-master\Winform-App-master\thongtintaikhoan.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
