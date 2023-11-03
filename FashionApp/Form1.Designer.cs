namespace FashionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            linkRegister = new LinkLabel();
            btnLogin = new Button();
            panel3 = new Panel();
            boxPassword = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            boxUsername = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(162, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 321);
            panel1.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.Blue;
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.Transparent;
            linkRegister.DisabledLinkColor = SystemColors.ActiveCaptionText;
            linkRegister.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegister.LinkColor = Color.Red;
            linkRegister.Location = new Point(178, 285);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(128, 20);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "Đăng ký tài khoản";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(193, 234);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(boxPassword);
            panel3.Location = new Point(52, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 42);
            panel3.TabIndex = 2;
            // 
            // boxPassword
            // 
            boxPassword.BackColor = Color.WhiteSmoke;
            boxPassword.BorderStyle = BorderStyle.None;
            boxPassword.CausesValidation = false;
            boxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxPassword.Location = new Point(15, 10);
            boxPassword.Margin = new Padding(0);
            boxPassword.Name = "boxPassword";
            boxPassword.PasswordChar = '*';
            boxPassword.PlaceholderText = "Password";
            boxPassword.Size = new Size(340, 22);
            boxPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(193, 17);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(boxUsername);
            panel2.Location = new Point(52, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 42);
            panel2.TabIndex = 1;
            // 
            // boxUsername
            // 
            boxUsername.BackColor = Color.WhiteSmoke;
            boxUsername.BorderStyle = BorderStyle.None;
            boxUsername.CausesValidation = false;
            boxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxUsername.Location = new Point(15, 10);
            boxUsername.Margin = new Padding(0);
            boxUsername.Name = "boxUsername";
            boxUsername.PlaceholderText = "Username";
            boxUsername.Size = new Size(340, 22);
            boxUsername.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Fashion Shop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox boxUsername;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private TextBox boxPassword;
        private Button btnLogin;
        private LinkLabel linkRegister;
    }
}