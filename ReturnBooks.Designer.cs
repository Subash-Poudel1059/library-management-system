namespace Libarary_ManagementSystemApp
{
    partial class ReturnBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            returnBooks_bookIssued = new DateTimePicker();
            returnBooks_clearBtn = new Button();
            returnBooks_returnBtn = new Button();
            label9 = new Label();
            returnBooks_author = new TextBox();
            label8 = new Label();
            returnBooks_bookTitle = new TextBox();
            label6 = new Label();
            returnBooks_email = new TextBox();
            label5 = new Label();
            returnBooks_contact = new TextBox();
            label4 = new Label();
            returnBooks_name = new TextBox();
            label3 = new Label();
            returnBooks_issueID = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(returnBooks_bookIssued);
            panel1.Controls.Add(returnBooks_clearBtn);
            panel1.Controls.Add(returnBooks_returnBtn);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(returnBooks_author);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(returnBooks_bookTitle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(returnBooks_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(returnBooks_contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(returnBooks_name);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(returnBooks_issueID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 525);
            panel1.TabIndex = 0;
            // 
            // returnBooks_bookIssued
            // 
            returnBooks_bookIssued.Location = new Point(103, 295);
            returnBooks_bookIssued.Name = "returnBooks_bookIssued";
            returnBooks_bookIssued.Size = new Size(201, 27);
            returnBooks_bookIssued.TabIndex = 25;
            // 
            // returnBooks_clearBtn
            // 
            returnBooks_clearBtn.BackColor = Color.FromArgb(0, 192, 192);
            returnBooks_clearBtn.FlatAppearance.BorderSize = 0;
            returnBooks_clearBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            returnBooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            returnBooks_clearBtn.FlatStyle = FlatStyle.Flat;
            returnBooks_clearBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            returnBooks_clearBtn.ForeColor = Color.White;
            returnBooks_clearBtn.Location = new Point(153, 356);
            returnBooks_clearBtn.Name = "returnBooks_clearBtn";
            returnBooks_clearBtn.Size = new Size(111, 40);
            returnBooks_clearBtn.TabIndex = 18;
            returnBooks_clearBtn.Text = "CLEAR";
            returnBooks_clearBtn.UseVisualStyleBackColor = false;
            returnBooks_clearBtn.Click += returnBooks_clearBtn_Click;
            // 
            // returnBooks_returnBtn
            // 
            returnBooks_returnBtn.BackColor = Color.FromArgb(0, 192, 192);
            returnBooks_returnBtn.FlatAppearance.BorderSize = 0;
            returnBooks_returnBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            returnBooks_returnBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            returnBooks_returnBtn.FlatStyle = FlatStyle.Flat;
            returnBooks_returnBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            returnBooks_returnBtn.ForeColor = Color.White;
            returnBooks_returnBtn.Location = new Point(30, 356);
            returnBooks_returnBtn.Name = "returnBooks_returnBtn";
            returnBooks_returnBtn.Size = new Size(111, 40);
            returnBooks_returnBtn.TabIndex = 17;
            returnBooks_returnBtn.Text = "RETURN";
            returnBooks_returnBtn.UseVisualStyleBackColor = false;
            returnBooks_returnBtn.Click += returnBooks_returnBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10F);
            label9.Location = new Point(-1, 296);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 15;
            label9.Text = "Book Issued:";
            // 
            // returnBooks_author
            // 
            returnBooks_author.Font = new Font("Segoe UI", 10F);
            returnBooks_author.Location = new Point(107, 256);
            returnBooks_author.Name = "returnBooks_author";
            returnBooks_author.Size = new Size(197, 30);
            returnBooks_author.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F);
            label8.Location = new Point(39, 260);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 13;
            label8.Text = "Author:";
            // 
            // returnBooks_bookTitle
            // 
            returnBooks_bookTitle.Font = new Font("Segoe UI", 10F);
            returnBooks_bookTitle.Location = new Point(107, 219);
            returnBooks_bookTitle.Name = "returnBooks_bookTitle";
            returnBooks_bookTitle.Size = new Size(197, 30);
            returnBooks_bookTitle.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F);
            label6.Location = new Point(3, 223);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 9;
            label6.Text = "Book Title :";
            // 
            // returnBooks_email
            // 
            returnBooks_email.Font = new Font("Segoe UI", 10F);
            returnBooks_email.Location = new Point(107, 183);
            returnBooks_email.Name = "returnBooks_email";
            returnBooks_email.Size = new Size(197, 30);
            returnBooks_email.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.Location = new Point(47, 188);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // returnBooks_contact
            // 
            returnBooks_contact.Font = new Font("Segoe UI", 10F);
            returnBooks_contact.Location = new Point(107, 147);
            returnBooks_contact.Name = "returnBooks_contact";
            returnBooks_contact.Size = new Size(197, 30);
            returnBooks_contact.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(2, 152);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 4;
            label4.Text = "Contact No.:";
            // 
            // returnBooks_name
            // 
            returnBooks_name.Font = new Font("Segoe UI", 10F);
            returnBooks_name.Location = new Point(107, 112);
            returnBooks_name.Name = "returnBooks_name";
            returnBooks_name.Size = new Size(197, 30);
            returnBooks_name.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(46, 117);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Name:";
            // 
            // returnBooks_issueID
            // 
            returnBooks_issueID.Font = new Font("Segoe UI", 10F);
            returnBooks_issueID.Location = new Point(107, 71);
            returnBooks_issueID.Name = "returnBooks_issueID";
            returnBooks_issueID.Size = new Size(197, 30);
            returnBooks_issueID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 0;
            label2.Text = "Issued ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(328, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 525);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(11, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(518, 481);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 0;
            label1.Text = "All Issued Books";
            // 
            // ReturnBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReturnBooks";
            Size = new Size(875, 565);
            Load += ReturnBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox returnBooks_name;
        private Label label3;
        private TextBox returnBooks_issueID;
        private Label label2;
        private TextBox returnBooks_email;
        private Label label5;
        private TextBox returnBooks_contact;
        private Label label4;
        private TextBox returnBooks_bookTitle;
        private Label label6;
        private Label label9;
        private TextBox returnBooks_author;
        private Label label8;
        private Button returnBooks_clearBtn;
        private Button returnBooks_returnBtn;
        private DataGridView dataGridView1;
        private DateTimePicker returnBooks_bookIssued;
    }
}
