namespace FashionApp
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            labelConfirmPassword = new Panel();
            boxConfirmPassword = new TextBox();
            linkRegister = new LinkLabel();
            btnRegister = new Button();
            panel3 = new Panel();
            boxPassword = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            boxUsername = new TextBox();
            panel1.SuspendLayout();
            labelConfirmPassword.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel1.Controls.Add(labelConfirmPassword);
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(155, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 321);
            panel1.TabIndex = 1;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.BackColor = Color.WhiteSmoke;
            labelConfirmPassword.Controls.Add(boxConfirmPassword);
            labelConfirmPassword.Location = new Point(52, 186);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(371, 42);
            labelConfirmPassword.TabIndex = 3;
            // 
            // boxConfirmPassword
            // 
            boxConfirmPassword.BackColor = Color.WhiteSmoke;
            boxConfirmPassword.BorderStyle = BorderStyle.None;
            boxConfirmPassword.CausesValidation = false;
            boxConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxConfirmPassword.Location = new Point(15, 10);
            boxConfirmPassword.Margin = new Padding(0);
            boxConfirmPassword.Name = "boxConfirmPassword";
            boxConfirmPassword.PasswordChar = '*';
            boxConfirmPassword.PlaceholderText = "Confirm Password";
            boxConfirmPassword.Size = new Size(340, 22);
            boxConfirmPassword.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.Blue;
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.Transparent;
            linkRegister.DisabledLinkColor = SystemColors.ActiveCaptionText;
            linkRegister.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkRegister.LinkColor = Color.Red;
            linkRegister.Location = new Point(183, 286);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(118, 20);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "Đăng nhập ngay";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(193, 234);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(99, 37);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(boxPassword);
            panel3.Location = new Point(52, 131);
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
            label1.Location = new Point(183, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 2;
            label1.Text = "REGISTER";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(boxUsername);
            panel2.Location = new Point(52, 69);
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Register";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fashion Shop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            labelConfirmPassword.ResumeLayout(false);
            labelConfirmPassword.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkRegister;
        private Button btnRegister;
        private Panel panel3;
        private TextBox boxPassword;
        private Label label1;
        private Panel panel2;
        private TextBox boxUsername;
        private Panel labelConfirmPassword;
        private TextBox boxConfirmPassword;
    }
}