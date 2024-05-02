namespace Libarary_ManagementSystemApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label1 = new Label();
            login_showpass = new CheckBox();
            signupbtn = new Button();
            register = new Label();
            Loginbtn = new Button();
            login_password = new TextBox();
            login_username = new TextBox();
            passlable = new Label();
            userlable = new Label();
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 23);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 3);
            label1.Name = "label1";
            label1.Size = new Size(16, 18);
            label1.TabIndex = 1;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.Location = new Point(213, 358);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(130, 22);
            login_showpass.TabIndex = 22;
            login_showpass.Text = "Show Password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.Black;
            signupbtn.Cursor = Cursors.Hand;
            signupbtn.FlatAppearance.BorderSize = 0;
            signupbtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            signupbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            signupbtn.FlatStyle = FlatStyle.Flat;
            signupbtn.Font = new Font("Tahoma", 11F);
            signupbtn.ForeColor = SystemColors.ButtonHighlight;
            signupbtn.Location = new Point(100, 496);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(149, 40);
            signupbtn.TabIndex = 21;
            signupbtn.Text = "SIGNUP";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signup_Click;
            // 
            // register
            // 
            register.AutoSize = true;
            register.Font = new Font("Tahoma", 9F);
            register.Location = new Point(100, 475);
            register.Name = "register";
            register.Size = new Size(149, 18);
            register.TabIndex = 20;
            register.Text = "REGISTER ACCOUNT";
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.Black;
            Loginbtn.Cursor = Cursors.Hand;
            Loginbtn.FlatAppearance.BorderSize = 0;
            Loginbtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            Loginbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Tahoma", 11F);
            Loginbtn.ForeColor = SystemColors.ButtonHighlight;
            Loginbtn.Location = new Point(100, 386);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(140, 40);
            Loginbtn.TabIndex = 19;
            Loginbtn.Text = "LOGIN";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(39, 322);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(281, 34);
            login_password.TabIndex = 18;
            // 
            // login_username
            // 
            login_username.Location = new Point(39, 237);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(281, 30);
            login_username.TabIndex = 17;
            // 
            // passlable
            // 
            passlable.AutoSize = true;
            passlable.Font = new Font("Tahoma", 11F);
            passlable.Location = new Point(35, 284);
            passlable.Name = "passlable";
            passlable.Size = new Size(115, 23);
            passlable.TabIndex = 16;
            passlable.Text = "PASSWORD:";
            // 
            // userlable
            // 
            userlable.AutoSize = true;
            userlable.Font = new Font("Tahoma", 11F);
            userlable.Location = new Point(35, 203);
            userlable.Name = "userlable";
            userlable.Size = new Size(113, 23);
            userlable.TabIndex = 15;
            userlable.Text = "USERNAME:";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Stencil", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome.Location = new Point(67, 163);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(189, 27);
            Welcome.TabIndex = 14;
            Welcome.Text = "Welcome,User!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(350, 550);
            Controls.Add(panel1);
            Controls.Add(login_showpass);
            Controls.Add(signupbtn);
            Controls.Add(register);
            Controls.Add(Loginbtn);
            Controls.Add(login_password);
            Controls.Add(login_username);
            Controls.Add(passlable);
            Controls.Add(userlable);
            Controls.Add(Welcome);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CheckBox login_showpass;
        private Button signupbtn;
        private Label register;
        private Button Loginbtn;
        private TextBox login_password;
        private TextBox login_username;
        private Label passlable;
        private Label userlable;
        private Label Welcome;
        private PictureBox pictureBox1;
    }
}