namespace Libarary_ManagementSystemApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            logout_btn = new Button();
            returnbooks_btn = new Button();
            issuebooks_btn = new Button();
            addbooks_btn = new Button();
            dashboard_btn = new Button();
            greet_label = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            issueBooks1 = new IssueBooks();
            dashboard1 = new Dashboard();
            addBooks1 = new AddBooks();
            returnBooks1 = new ReturnBooks();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 2);
            label2.Name = "label2";
            label2.Size = new Size(357, 23);
            label2.TabIndex = 1;
            label2.Text = "Library Management System | Main Form";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1075, 7);
            label1.Name = "label1";
            label1.Size = new Size(19, 22);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(returnbooks_btn);
            panel2.Controls.Add(issuebooks_btn);
            panel2.Controls.Add(addbooks_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(greet_label);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 565);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 520);
            label4.Name = "label4";
            label4.Size = new Size(77, 24);
            label4.TabIndex = 7;
            label4.Text = "Log out";
            // 
            // logout_btn
            // 
            logout_btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            logout_btn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.ForeColor = Color.White;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.Location = new Point(9, 515);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(35, 35);
            logout_btn.TabIndex = 6;
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // returnbooks_btn
            // 
            returnbooks_btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            returnbooks_btn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            returnbooks_btn.FlatStyle = FlatStyle.Flat;
            returnbooks_btn.ForeColor = Color.White;
            returnbooks_btn.Image = (Image)resources.GetObject("returnbooks_btn.Image");
            returnbooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            returnbooks_btn.Location = new Point(11, 323);
            returnbooks_btn.Name = "returnbooks_btn";
            returnbooks_btn.Size = new Size(200, 45);
            returnbooks_btn.TabIndex = 5;
            returnbooks_btn.Text = "RETURN BOOKS";
            returnbooks_btn.UseVisualStyleBackColor = true;
            returnbooks_btn.Click += returnbooks_btn_Click;
            // 
            // issuebooks_btn
            // 
            issuebooks_btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            issuebooks_btn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            issuebooks_btn.FlatStyle = FlatStyle.Flat;
            issuebooks_btn.ForeColor = Color.White;
            issuebooks_btn.Image = (Image)resources.GetObject("issuebooks_btn.Image");
            issuebooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            issuebooks_btn.Location = new Point(11, 272);
            issuebooks_btn.Name = "issuebooks_btn";
            issuebooks_btn.Size = new Size(200, 45);
            issuebooks_btn.TabIndex = 4;
            issuebooks_btn.Text = "ISSUE BOOKS";
            issuebooks_btn.UseVisualStyleBackColor = true;
            issuebooks_btn.Click += issuebooks_btn_Click;
            // 
            // addbooks_btn
            // 
            addbooks_btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            addbooks_btn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            addbooks_btn.FlatStyle = FlatStyle.Flat;
            addbooks_btn.ForeColor = Color.White;
            addbooks_btn.Image = (Image)resources.GetObject("addbooks_btn.Image");
            addbooks_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addbooks_btn.Location = new Point(11, 221);
            addbooks_btn.Name = "addbooks_btn";
            addbooks_btn.Size = new Size(200, 45);
            addbooks_btn.TabIndex = 3;
            addbooks_btn.Text = "ADD BOOKS";
            addbooks_btn.UseVisualStyleBackColor = true;
            addbooks_btn.Click += addbooks_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(11, 171);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(200, 45);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // greet_label
            // 
            greet_label.AutoSize = true;
            greet_label.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greet_label.ForeColor = Color.White;
            greet_label.Location = new Point(26, 113);
            greet_label.Name = "greet_label";
            greet_label.Size = new Size(154, 24);
            greet_label.TabIndex = 1;
            greet_label.Text = "Welcome Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(issueBooks1);
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addBooks1);
            panel3.Controls.Add(returnBooks1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 565);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // issueBooks1
            // 
            issueBooks1.Location = new Point(0, 0);
            issueBooks1.Name = "issueBooks1";
            issueBooks1.Size = new Size(1094, 706);
            issueBooks1.TabIndex = 3;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(3, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1094, 706);
            dashboard1.TabIndex = 2;
            // 
            // addBooks1
            // 
            addBooks1.Location = new Point(-1, -2);
            addBooks1.Name = "addBooks1";
            addBooks1.Size = new Size(1100, 706);
            addBooks1.TabIndex = 1;
            // 
            // returnBooks1
            // 
            returnBooks1.Location = new Point(-7, 0);
            returnBooks1.Name = "returnBooks1";
            returnBooks1.Size = new Size(1106, 706);
            returnBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button addbooks_btn;
        private Button dashboard_btn;
        private Label greet_label;
        private Button logout_btn;
        private Button returnbooks_btn;
        private Button issuebooks_btn;
        private Label label4;
        private Panel panel3;
        private Dashboard dashboard1;
        private AddBooks addBooks1;
        private ReturnBooks returnBooks1;
        private IssueBooks issueBooks1;
    }
}