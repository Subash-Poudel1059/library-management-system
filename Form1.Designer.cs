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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            label1 = new Label();
            LOGO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LOGO).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 172);
            label1.Name = "label1";
            label1.Size = new Size(242, 22);
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
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(746, 458);
            Controls.Add(LOGO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            Text = "loadform";
            ((System.ComponentModel.ISupportInitialize)LOGO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox LOGO;
    }
}
