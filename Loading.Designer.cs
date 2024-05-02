namespace Libarary_ManagementSystemApp
{
    partial class LoadingForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            label1 = new Label();
            LOGO = new PictureBox();
            backpanel1 = new Panel();
            Timer = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)LOGO).BeginInit();
            backpanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(130, 219);
            label1.Name = "label1";
            label1.Size = new Size(500, 45);
            label1.TabIndex = 1;
            label1.Text = "Libarary Management System";
            label1.Click += label1_Click;
            // 
            // LOGO
            // 
            LOGO.ErrorImage = null;
            LOGO.Image = (Image)resources.GetObject("LOGO.Image");
            LOGO.ImageLocation = "";
            LOGO.InitialImage = null;
            LOGO.Location = new Point(279, 12);
            LOGO.Name = "LOGO";
            LOGO.Size = new Size(200, 200);
            LOGO.SizeMode = PictureBoxSizeMode.Zoom;
            LOGO.TabIndex = 2;
            LOGO.TabStop = false;
            LOGO.Click += pictureBox1_Click;
            // 
            // backpanel1
            // 
            backpanel1.Controls.Add(Timer);
            backpanel1.Location = new Point(3, 412);
            backpanel1.Name = "backpanel1";
            backpanel1.Size = new Size(740, 25);
            backpanel1.TabIndex = 3;
            backpanel1.Paint += backpanel1_Paint;
            // 
            // Timer
            // 
            Timer.BackColor = Color.White;
            Timer.Location = new Point(0, 0);
            Timer.Name = "Timer";
            Timer.Size = new Size(60, 25);
            Timer.TabIndex = 4;
            Timer.Paint += panel1_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(740, 450);
            Controls.Add(backpanel1);
            Controls.Add(LOGO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loadform";
            ((System.ComponentModel.ISupportInitialize)LOGO).EndInit();
            backpanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox LOGO;
        private Panel backpanel1;
        private Panel Timer;
        private System.Windows.Forms.Timer timer1;
    }
}
