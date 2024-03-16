namespace Giaodien
{
    partial class Giaodienphongcho
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
            txtRoomCodeLogin = new TextBox();
            lbl_RoomCode = new Label();
            btn_CodeEnter = new Button();
            lblNickname = new Label();
            txtNickname = new TextBox();
            SuspendLayout();
            // 
            // txtRoomCodeLogin
            // 
            txtRoomCodeLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRoomCodeLogin.Font = new Font("Microsoft Sans Serif", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomCodeLogin.Location = new Point(217, 232);
            txtRoomCodeLogin.MaxLength = 6;
            txtRoomCodeLogin.MinimumSize = new Size(330, 101);
            txtRoomCodeLogin.Name = "txtRoomCodeLogin";
            txtRoomCodeLogin.Size = new Size(330, 101);
            txtRoomCodeLogin.TabIndex = 0;
            txtRoomCodeLogin.WordWrap = false;
            // 
            // lbl_RoomCode
            // 
            lbl_RoomCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_RoomCode.AutoSize = true;
            lbl_RoomCode.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_RoomCode.Location = new Point(269, 188);
            lbl_RoomCode.Name = "lbl_RoomCode";
            lbl_RoomCode.Size = new Size(227, 31);
            lbl_RoomCode.TabIndex = 1;
            lbl_RoomCode.Text = "Nhập mã số phòng";
            lbl_RoomCode.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_CodeEnter
            // 
            btn_CodeEnter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_CodeEnter.BackColor = SystemColors.Info;
            btn_CodeEnter.Font = new Font("Tahoma", 11.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CodeEnter.ForeColor = SystemColors.ActiveCaptionText;
            btn_CodeEnter.Location = new Point(621, 360);
            btn_CodeEnter.Name = "btn_CodeEnter";
            btn_CodeEnter.Size = new Size(157, 78);
            btn_CodeEnter.TabIndex = 2;
            btn_CodeEnter.Text = "Nhập mã";
            btn_CodeEnter.UseVisualStyleBackColor = false;
            btn_CodeEnter.Click += btn_CodeEnter_Click;
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblNickname.Location = new Point(286, 9);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(210, 31);
            lblNickname.TabIndex = 3;
            lblNickname.Text = "Nhập tên của bạn";
            // 
            // txtNickname
            // 
            txtNickname.Location = new Point(235, 53);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(287, 27);
            txtNickname.TabIndex = 4;
            // 
            // Giaodienphongcho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNickname);
            Controls.Add(lblNickname);
            Controls.Add(btn_CodeEnter);
            Controls.Add(lbl_RoomCode);
            Controls.Add(txtRoomCodeLogin);
            MinimumSize = new Size(816, 497);
            Name = "Giaodienphongcho";
            Text = "Giaodienphongcho";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRoomCodeLogin;
        private Label lbl_RoomCode;
        private Button btn_CodeEnter;
        private Label lblNickname;
        private TextBox txtNickname;
    }
}