namespace Giaodien
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLobby = new Label();
            lblUser = new Label();
            SuspendLayout();
            // 
            // lblLobby
            // 
            lblLobby.BackColor = Color.Transparent;
            lblLobby.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lblLobby.ForeColor = Color.Black;
            lblLobby.Location = new Point(324, 9);
            lblLobby.Name = "lblLobby";
            lblLobby.Size = new Size(134, 49);
            lblLobby.TabIndex = 0;
            lblLobby.Text = "Lobby";
            // 
            // lblUser
            // 
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(197, 125);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(379, 219);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUser);
            Controls.Add(lblLobby);
            Name = "Lobby";
            Text = "Lobby";
            ResumeLayout(false);
        }

        #endregion

        private Label lblLobby;
        private Label lblUser;
    }
}