using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodien
{
    public partial class Lobby : Form
    {
        private string loggedInEmail;
        private string loggedInNickname; // Thêm biến loggedInNickname
        private Image backgroundImage;
        private List<User> loggedInUsers;

        public Lobby()
        {
            InitializeComponent();
            loggedInUsers = new List<User>();
            SetBackgroundImage(Properties.Resources.class1); // Đặt hình ảnh "class1" làm hình nền
            lblUser.Text = "";
        }
        public void UpdateLoggedInUser(string nickname) // Thay đổi tham số thành nickname
        {
            lblUser.Text = "USER: " + nickname; // Cập nhật nickname
            loggedInNickname = nickname; // Cập nhật loggedInNickname
        }
        public void SetLoggedInAccount(string email)
        {
            loggedInEmail = email;
        }

        private void Lobby_Load(object sender, EventArgs e)
        {

            // Đặt hình ảnh làm nền
            SetBackgroundImage(Properties.Resources.class1);
        }

        public void SetBackgroundImage(Image image)
        {
            // Đặt hình ảnh làm nền cho form
            backgroundImage = image;
            Refresh();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // Vẽ hình ảnh nền
            if (backgroundImage != null)
            {
                e.Graphics.DrawImage(backgroundImage, 0, 0, Width, Height);
            }
        }
    }

    public class User
    {
        public string Username { get; }

        public User(string username)
        {
            Username = username;
        }
    }
}