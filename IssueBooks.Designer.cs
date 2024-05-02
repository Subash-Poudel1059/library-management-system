namespace Libarary_ManagementSystemApp
{
    partial class IssueBooks
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
            panel1 = new Panel();
            bookIssue_status = new ComboBox();
            label10 = new Label();
            bookIssue_clearBtn = new Button();
            bookIssue_deleteBtn = new Button();
            bookIssue_updateBtn = new Button();
            bookIssue_addBtn = new Button();
            bookIssue_returnDate = new DateTimePicker();
            label9 = new Label();
            bookIssue_issueDate = new DateTimePicker();
            label8 = new Label();
            bookIssue_picture = new PictureBox();
            bookIssue_author = new ComboBox();
            label7 = new Label();
            bookIssue_bookTitle = new ComboBox();
            label6 = new Label();
            bookIssue_id = new TextBox();
            label2 = new Label();
            bookIssue_email = new TextBox();
            label5 = new Label();
            bookIssue_contact = new TextBox();
            label4 = new Label();
            bookIssue_name = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookIssue_picture).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(bookIssue_status);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(bookIssue_clearBtn);
            panel1.Controls.Add(bookIssue_deleteBtn);
            panel1.Controls.Add(bookIssue_updateBtn);
            panel1.Controls.Add(bookIssue_addBtn);
            panel1.Controls.Add(bookIssue_returnDate);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(bookIssue_issueDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(bookIssue_picture);
            panel1.Controls.Add(bookIssue_author);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(bookIssue_bookTitle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(bookIssue_id);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(bookIssue_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(bookIssue_contact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bookIssue_name);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(14, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 215);
            panel1.TabIndex = 0;
            // 
            // bookIssue_status
            // 
            bookIssue_status.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookIssue_status.FormattingEnabled = true;
            bookIssue_status.Items.AddRange(new object[] { "Return", "Not Return" });
            bookIssue_status.Location = new Point(638, 11);
            bookIssue_status.Name = "bookIssue_status";
            bookIssue_status.Size = new Size(106, 26);
            bookIssue_status.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10F);
            label10.Location = new Point(570, 13);
            label10.Name = "label10";
            label10.Size = new Size(63, 21);
            label10.TabIndex = 29;
            label10.Text = "Status:";
            // 
            // bookIssue_clearBtn
            // 
            bookIssue_clearBtn.BackColor = Color.FromArgb(0, 192, 192);
            bookIssue_clearBtn.FlatAppearance.BorderSize = 0;
            bookIssue_clearBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            bookIssue_clearBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            bookIssue_clearBtn.FlatStyle = FlatStyle.Flat;
            bookIssue_clearBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            bookIssue_clearBtn.ForeColor = Color.White;
            bookIssue_clearBtn.Location = new Point(516, 159);
            bookIssue_clearBtn.Name = "bookIssue_clearBtn";
            bookIssue_clearBtn.Size = new Size(111, 40);
            bookIssue_clearBtn.TabIndex = 28;
            bookIssue_clearBtn.Text = "Clear";
            bookIssue_clearBtn.UseVisualStyleBackColor = false;
            bookIssue_clearBtn.Click += bookIssue_clearBtn_Click;
            // 
            // bookIssue_deleteBtn
            // 
            bookIssue_deleteBtn.BackColor = Color.FromArgb(0, 192, 192);
            bookIssue_deleteBtn.FlatAppearance.BorderSize = 0;
            bookIssue_deleteBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            bookIssue_deleteBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            bookIssue_deleteBtn.FlatStyle = FlatStyle.Flat;
            bookIssue_deleteBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            bookIssue_deleteBtn.ForeColor = Color.White;
            bookIssue_deleteBtn.Location = new Point(393, 159);
            bookIssue_deleteBtn.Name = "bookIssue_deleteBtn";
            bookIssue_deleteBtn.Size = new Size(111, 40);
            bookIssue_deleteBtn.TabIndex = 27;
            bookIssue_deleteBtn.Text = "DELETE";
            bookIssue_deleteBtn.UseVisualStyleBackColor = false;
            bookIssue_deleteBtn.Click += bookIssue_deleteBtn_Click;
            // 
            // bookIssue_updateBtn
            // 
            bookIssue_updateBtn.BackColor = Color.FromArgb(0, 192, 192);
            bookIssue_updateBtn.FlatAppearance.BorderSize = 0;
            bookIssue_updateBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            bookIssue_updateBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            bookIssue_updateBtn.FlatStyle = FlatStyle.Flat;
            bookIssue_updateBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            bookIssue_updateBtn.ForeColor = Color.White;
            bookIssue_updateBtn.Location = new Point(276, 159);
            bookIssue_updateBtn.Name = "bookIssue_updateBtn";
            bookIssue_updateBtn.Size = new Size(111, 40);
            bookIssue_updateBtn.TabIndex = 26;
            bookIssue_updateBtn.Text = "UPDATE";
            bookIssue_updateBtn.UseVisualStyleBackColor = false;
            bookIssue_updateBtn.Click += bookIssue_updateBtn_Click;
            // 
            // bookIssue_addBtn
            // 
            bookIssue_addBtn.BackColor = Color.FromArgb(0, 192, 192);
            bookIssue_addBtn.FlatAppearance.BorderSize = 0;
            bookIssue_addBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            bookIssue_addBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            bookIssue_addBtn.FlatStyle = FlatStyle.Flat;
            bookIssue_addBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            bookIssue_addBtn.ForeColor = Color.White;
            bookIssue_addBtn.Location = new Point(153, 159);
            bookIssue_addBtn.Name = "bookIssue_addBtn";
            bookIssue_addBtn.Size = new Size(111, 40);
            bookIssue_addBtn.TabIndex = 25;
            bookIssue_addBtn.Text = "ADD";
            bookIssue_addBtn.UseVisualStyleBackColor = false;
            bookIssue_addBtn.Click += bookIssue_addBtn_Click;
            // 
            // bookIssue_returnDate
            // 
            bookIssue_returnDate.Location = new Point(405, 112);
            bookIssue_returnDate.Name = "bookIssue_returnDate";
            bookIssue_returnDate.Size = new Size(222, 27);
            bookIssue_returnDate.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10F);
            label9.Location = new Point(336, 113);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 23;
            label9.Text = "Return:";
            // 
            // bookIssue_issueDate
            // 
            bookIssue_issueDate.Location = new Point(405, 78);
            bookIssue_issueDate.Name = "bookIssue_issueDate";
            bookIssue_issueDate.Size = new Size(222, 27);
            bookIssue_issueDate.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F);
            label8.Location = new Point(346, 79);
            label8.Name = "label8";
            label8.Size = new Size(56, 21);
            label8.TabIndex = 21;
            label8.Text = "Issue:";
            label8.Click += label8_Click;
            // 
            // bookIssue_picture
            // 
            bookIssue_picture.BackColor = SystemColors.ButtonShadow;
            bookIssue_picture.Location = new Point(750, 11);
            bookIssue_picture.Name = "bookIssue_picture";
            bookIssue_picture.Size = new Size(100, 100);
            bookIssue_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            bookIssue_picture.TabIndex = 20;
            bookIssue_picture.TabStop = false;
            // 
            // bookIssue_author
            // 
            bookIssue_author.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookIssue_author.FormattingEnabled = true;
            bookIssue_author.Location = new Point(407, 45);
            bookIssue_author.Name = "bookIssue_author";
            bookIssue_author.Size = new Size(162, 26);
            bookIssue_author.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10F);
            label7.Location = new Point(335, 45);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 18;
            label7.Text = "Author:";
            // 
            // bookIssue_bookTitle
            // 
            bookIssue_bookTitle.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookIssue_bookTitle.FormattingEnabled = true;
            bookIssue_bookTitle.Location = new Point(407, 8);
            bookIssue_bookTitle.Name = "bookIssue_bookTitle";
            bookIssue_bookTitle.Size = new Size(162, 26);
            bookIssue_bookTitle.TabIndex = 17;
            bookIssue_bookTitle.SelectedIndexChanged += bookIssue_bookTitle_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F);
            label6.Location = new Point(300, 8);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 16;
            label6.Text = "Book Title :";
            // 
            // bookIssue_id
            // 
            bookIssue_id.Font = new Font("Segoe UI", 10F);
            bookIssue_id.Location = new Point(106, 7);
            bookIssue_id.Name = "bookIssue_id";
            bookIssue_id.Size = new Size(197, 30);
            bookIssue_id.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 14;
            label2.Text = "Issued ID:";
            // 
            // bookIssue_email
            // 
            bookIssue_email.Font = new Font("Segoe UI", 10F);
            bookIssue_email.Location = new Point(106, 114);
            bookIssue_email.Name = "bookIssue_email";
            bookIssue_email.Size = new Size(197, 30);
            bookIssue_email.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10F);
            label5.Location = new Point(46, 119);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 12;
            label5.Text = "Email:";
            // 
            // bookIssue_contact
            // 
            bookIssue_contact.Font = new Font("Segoe UI", 10F);
            bookIssue_contact.Location = new Point(106, 78);
            bookIssue_contact.Name = "bookIssue_contact";
            bookIssue_contact.Size = new Size(197, 30);
            bookIssue_contact.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(1, 83);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 10;
            label4.Text = "Contact No.:";
            // 
            // bookIssue_name
            // 
            bookIssue_name.Font = new Font("Segoe UI", 10F);
            bookIssue_name.Location = new Point(106, 43);
            bookIssue_name.Name = "bookIssue_name";
            bookIssue_name.Size = new Size(197, 30);
            bookIssue_name.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(45, 48);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 8;
            label3.Text = "Name:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(14, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 330);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F);
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(186, 29);
            label1.TabIndex = 1;
            label1.Text = "All Issued Books";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(22, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 273);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            Size = new Size(875, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookIssue_picture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox bookIssue_email;
        private Label label5;
        private TextBox bookIssue_contact;
        private Label label4;
        private TextBox bookIssue_name;
        private Label label3;
        private TextBox bookIssue_id;
        private Label label2;
        private ComboBox bookIssue_bookTitle;
        private Label label6;
        private Label label8;
        private PictureBox bookIssue_picture;
        private ComboBox bookIssue_author;
        private Label label7;
        private DateTimePicker bookIssue_returnDate;
        private Label label9;
        private DateTimePicker bookIssue_issueDate;
        private Button bookIssue_clearBtn;
        private Button bookIssue_deleteBtn;
        private Button bookIssue_updateBtn;
        private Button bookIssue_addBtn;
        private ComboBox bookIssue_status;
        private Label label10;
    }
}
