namespace Libarary_ManagementSystemApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            signupbtn = new Button();
            register = new Label();
            Regbtn = new Button();
            passwordtextbox = new TextBox();
            usernametextbox = new TextBox();
            passlable = new Label();
            userlable = new Label();
            Welcome = new Label();
            pictureBox1 = new PictureBox();
            addresstext = new TextBox();
            emailtextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contacttext = new TextBox();
            contactlabel = new Label();
            confirmpasstext = new TextBox();
            confirmpass = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            id = new Label();
            label6 = new Label();
            gender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 23);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(717, 0);
            label1.Name = "label1";
            label1.Size = new Size(16, 18);
            label1.TabIndex = 1;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(566, 397);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 22);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            signupbtn.Location = new Point(289, 548);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(149, 40);
            signupbtn.TabIndex = 21;
            signupbtn.Text = "SIGNIN";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signup_Click;
            // 
            // register
            // 
            register.AutoSize = true;
            register.Font = new Font("Tahoma", 9F);
            register.Location = new Point(304, 518);
            register.Name = "register";
            register.Size = new Size(125, 18);
            register.TabIndex = 20;
            register.Text = "LOGIN ACCOUNT";
            register.Click += register_Click;
            // 
            // Regbtn
            // 
            Regbtn.BackColor = Color.Black;
            Regbtn.Cursor = Cursors.Hand;
            Regbtn.FlatAppearance.BorderSize = 0;
            Regbtn.FlatAppearance.MouseDownBackColor = Color.Teal;
            Regbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            Regbtn.FlatStyle = FlatStyle.Flat;
            Regbtn.Font = new Font("Tahoma", 11F);
            Regbtn.ForeColor = SystemColors.ButtonHighlight;
            Regbtn.Location = new Point(289, 475);
            Regbtn.Name = "Regbtn";
            Regbtn.Size = new Size(140, 40);
            Regbtn.TabIndex = 19;
            Regbtn.Text = "REGISTER ";
            Regbtn.UseVisualStyleBackColor = false;
            Regbtn.Click += button1_Click;
            // 
            // passwordtextbox
            // 
            passwordtextbox.Location = new Point(29, 362);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.PasswordChar = '*';
            passwordtextbox.Size = new Size(281, 30);
            passwordtextbox.TabIndex = 18;
            passwordtextbox.TextChanged += passwordtextbox_TextChanged;
            passwordtextbox.KeyPress += passwordtextbox_KeyPress;
            // 
            // usernametextbox
            // 
            usernametextbox.Location = new Point(29, 192);
            usernametextbox.Name = "usernametextbox";
            usernametextbox.Size = new Size(281, 30);
            usernametextbox.TabIndex = 17;
            usernametextbox.KeyPress += usernametextbox_KeyPress;
            // 
            // passlable
            // 
            passlable.AutoSize = true;
            passlable.Font = new Font("Tahoma", 11F);
            passlable.Location = new Point(26, 336);
            passlable.Name = "passlable";
            passlable.Size = new Size(115, 23);
            passlable.TabIndex = 16;
            passlable.Text = "PASSWORD:";
            // 
            // userlable
            // 
            userlable.AutoSize = true;
            userlable.Font = new Font("Tahoma", 11F);
            userlable.Location = new Point(29, 166);
            userlable.Name = "userlable";
            userlable.Size = new Size(113, 23);
            userlable.TabIndex = 15;
            userlable.Text = "USERNAME:";
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Stencil", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Welcome.Location = new Point(262, 126);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(185, 27);
            Welcome.TabIndex = 14;
            Welcome.Text = "REGISTER HERE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(305, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // addresstext
            // 
            addresstext.HideSelection = false;
            addresstext.Location = new Point(351, 245);
            addresstext.Name = "addresstext";
            addresstext.Size = new Size(281, 30);
            addresstext.TabIndex = 26;
            addresstext.TextChanged += addresstext_TextChanged;
            addresstext.KeyPress += addresstext_KeyPress;
            // 
            // emailtextbox
            // 
            emailtextbox.HideSelection = false;
            emailtextbox.Location = new Point(347, 186);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(281, 30);
            emailtextbox.TabIndex = 25;
            emailtextbox.TextChanged += emailtextbox_TextChanged;
            emailtextbox.KeyPress += emailtextbox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F);
            label2.Location = new Point(347, 219);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 24;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11F);
            label3.Location = new Point(347, 160);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 23;
            label3.Text = "EMAIL ADDRESS:";
            // 
            // contacttext
            // 
            contacttext.HideSelection = false;
            contacttext.Location = new Point(29, 245);
            contacttext.Name = "contacttext";
            contacttext.Size = new Size(281, 30);
            contacttext.TabIndex = 28;
            contacttext.KeyPress += contacttext_KeyPress;
            // 
            // contactlabel
            // 
            contactlabel.AutoSize = true;
            contactlabel.Font = new Font("Tahoma", 11F);
            contactlabel.Location = new Point(25, 222);
            contactlabel.Name = "contactlabel";
            contactlabel.Size = new Size(129, 23);
            contactlabel.TabIndex = 27;
            contactlabel.Text = "CONTACT NO.";
            contactlabel.Click += contactlabel_Click;
            // 
            // confirmpasstext
            // 
            confirmpasstext.Location = new Point(344, 361);
            confirmpasstext.Name = "confirmpasstext";
            confirmpasstext.PasswordChar = '*';
            confirmpasstext.Size = new Size(281, 30);
            confirmpasstext.TabIndex = 30;
            confirmpasstext.TextChanged += confirmpasstext_TextChanged;
            confirmpasstext.KeyPress += confirmpasstext_KeyPress;
            // 
            // confirmpass
            // 
            confirmpass.AutoSize = true;
            confirmpass.Font = new Font("Tahoma", 11F);
            confirmpass.Location = new Point(344, 337);
            confirmpass.Name = "confirmpass";
            confirmpass.Size = new Size(202, 23);
            confirmpass.TabIndex = 29;
            confirmpass.Text = "CONFIRM PASSWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F);
            label4.Location = new Point(285, 454);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 31;
            label4.Text = "REGISTER ACCOUNT";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 302);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 30);
            textBox1.TabIndex = 35;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Tahoma", 11F);
            id.Location = new Point(22, 279);
            id.Name = "id";
            id.Size = new Size(68, 23);
            id.TabIndex = 34;
            id.Text = "ID NO.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11F);
            label6.Location = new Point(344, 302);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 32;
            label6.Text = "GENDER:";
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "MALE", "FEMALE", "OTHERS" });
            gender.Location = new Point(453, 299);
            gender.Name = "gender";
            gender.Size = new Size(151, 30);
            gender.TabIndex = 36;
            gender.SelectedIndexChanged += gender_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 409);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 30);
            dateTimePicker1.TabIndex = 37;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11F);
            label5.Location = new Point(12, 415);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 38;
            label5.Text = "REG DATE:";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(740, 600);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(gender);
            Controls.Add(textBox1);
            Controls.Add(id);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(confirmpasstext);
            Controls.Add(confirmpass);
            Controls.Add(contacttext);
            Controls.Add(contactlabel);
            Controls.Add(addresstext);
            Controls.Add(emailtextbox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(checkBox1);
            Controls.Add(signupbtn);
            Controls.Add(register);
            Controls.Add(Regbtn);
            Controls.Add(passwordtextbox);
            Controls.Add(usernametextbox);
            Controls.Add(passlable);
            Controls.Add(userlable);
            Controls.Add(Welcome);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private CheckBox checkBox1;
        private Button signupbtn;
        private Label register;
        private Button Regbtn;
        private TextBox passwordtextbox;
        private TextBox usernametextbox;
        private Label passlable;
        private Label userlable;
        private Label Welcome;
        private PictureBox pictureBox1;
        private TextBox addresstext;
        private TextBox emailtextbox;
        private Label label2;
        private Label label3;
        private TextBox contacttext;
        private Label contactlabel;
        private TextBox confirmpasstext;
        private Label confirmpass;
        private Label label4;
        private TextBox textBox1;
        private Label id;
        private Label label6;
        private ComboBox gender;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}