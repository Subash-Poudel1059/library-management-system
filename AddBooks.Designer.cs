namespace Libarary_ManagementSystemApp
{
    partial class AddBooks
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            addbooks_importbtn = new Button();
            addbooks_clearBtn = new Button();
            addbooks_deleteBtn = new Button();
            addbooks_status = new ComboBox();
            label3 = new Label();
            addbooks_published = new DateTimePicker();
            label2 = new Label();
            addbooks_updateBtn = new Button();
            addbooks_addBtn = new Button();
            addbooks_author = new TextBox();
            label8 = new Label();
            addbooks_booktittle = new TextBox();
            label6 = new Label();
            addbooks_picture = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addbooks_picture).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(328, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 525);
            panel2.TabIndex = 3;
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
            dataGridView1.Location = new Point(11, 42);
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
            dataGridView1.Size = new Size(521, 470);
            dataGridView1.TabIndex = 1;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(addbooks_importbtn);
            panel1.Controls.Add(addbooks_clearBtn);
            panel1.Controls.Add(addbooks_deleteBtn);
            panel1.Controls.Add(addbooks_status);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addbooks_published);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addbooks_updateBtn);
            panel1.Controls.Add(addbooks_addBtn);
            panel1.Controls.Add(addbooks_author);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(addbooks_booktittle);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(addbooks_picture);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(4, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 525);
            panel1.TabIndex = 2;
            // 
            // addbooks_importbtn
            // 
            addbooks_importbtn.BackColor = Color.FromArgb(0, 192, 192);
            addbooks_importbtn.FlatAppearance.BorderSize = 0;
            addbooks_importbtn.FlatStyle = FlatStyle.Flat;
            addbooks_importbtn.Font = new Font("Arial", 9F);
            addbooks_importbtn.Location = new Point(107, 103);
            addbooks_importbtn.Name = "addbooks_importbtn";
            addbooks_importbtn.Size = new Size(94, 29);
            addbooks_importbtn.TabIndex = 25;
            addbooks_importbtn.Text = "Import";
            addbooks_importbtn.UseVisualStyleBackColor = false;
            addbooks_importbtn.Click += addbooks_importbtn_Click;
            // 
            // addbooks_clearBtn
            // 
            addbooks_clearBtn.BackColor = Color.FromArgb(0, 192, 192);
            addbooks_clearBtn.FlatAppearance.BorderSize = 0;
            addbooks_clearBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            addbooks_clearBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            addbooks_clearBtn.FlatStyle = FlatStyle.Flat;
            addbooks_clearBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addbooks_clearBtn.ForeColor = Color.White;
            addbooks_clearBtn.Location = new Point(153, 365);
            addbooks_clearBtn.Name = "addbooks_clearBtn";
            addbooks_clearBtn.Size = new Size(111, 40);
            addbooks_clearBtn.TabIndex = 24;
            addbooks_clearBtn.Text = "CLEAR";
            addbooks_clearBtn.UseVisualStyleBackColor = false;
            addbooks_clearBtn.Click += addbooks_clearBtn_Click;
            // 
            // addbooks_deleteBtn
            // 
            addbooks_deleteBtn.BackColor = Color.FromArgb(0, 192, 192);
            addbooks_deleteBtn.FlatAppearance.BorderSize = 0;
            addbooks_deleteBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            addbooks_deleteBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            addbooks_deleteBtn.FlatStyle = FlatStyle.Flat;
            addbooks_deleteBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addbooks_deleteBtn.ForeColor = Color.White;
            addbooks_deleteBtn.Location = new Point(30, 365);
            addbooks_deleteBtn.Name = "addbooks_deleteBtn";
            addbooks_deleteBtn.Size = new Size(111, 40);
            addbooks_deleteBtn.TabIndex = 23;
            addbooks_deleteBtn.Text = "DELETE";
            addbooks_deleteBtn.UseVisualStyleBackColor = false;
            addbooks_deleteBtn.Click += addbooks_deleteBtn_Click;
            // 
            // addbooks_status
            // 
            addbooks_status.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbooks_status.FormattingEnabled = true;
            addbooks_status.Items.AddRange(new object[] { "Avaliable", "Not Avaliable" });
            addbooks_status.Location = new Point(84, 239);
            addbooks_status.Name = "addbooks_status";
            addbooks_status.Size = new Size(230, 26);
            addbooks_status.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10F);
            label3.Location = new Point(24, 241);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 21;
            label3.Text = "Status:";
            // 
            // addbooks_published
            // 
            addbooks_published.Location = new Point(84, 208);
            addbooks_published.Name = "addbooks_published";
            addbooks_published.Size = new Size(230, 27);
            addbooks_published.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F);
            label2.Location = new Point(4, 210);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 19;
            label2.Text = "Published:";
            // 
            // addbooks_updateBtn
            // 
            addbooks_updateBtn.BackColor = Color.FromArgb(0, 192, 192);
            addbooks_updateBtn.FlatAppearance.BorderSize = 0;
            addbooks_updateBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            addbooks_updateBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            addbooks_updateBtn.FlatStyle = FlatStyle.Flat;
            addbooks_updateBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addbooks_updateBtn.ForeColor = Color.White;
            addbooks_updateBtn.Location = new Point(153, 305);
            addbooks_updateBtn.Name = "addbooks_updateBtn";
            addbooks_updateBtn.Size = new Size(111, 40);
            addbooks_updateBtn.TabIndex = 18;
            addbooks_updateBtn.Text = "UPDATE";
            addbooks_updateBtn.UseVisualStyleBackColor = false;
            addbooks_updateBtn.Click += addbooks_updateBtn_Click;
            // 
            // addbooks_addBtn
            // 
            addbooks_addBtn.BackColor = Color.FromArgb(0, 192, 192);
            addbooks_addBtn.FlatAppearance.BorderSize = 0;
            addbooks_addBtn.FlatAppearance.CheckedBackColor = Color.Aqua;
            addbooks_addBtn.FlatAppearance.MouseDownBackColor = Color.Aqua;
            addbooks_addBtn.FlatStyle = FlatStyle.Flat;
            addbooks_addBtn.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            addbooks_addBtn.ForeColor = Color.White;
            addbooks_addBtn.Location = new Point(30, 305);
            addbooks_addBtn.Name = "addbooks_addBtn";
            addbooks_addBtn.Size = new Size(111, 40);
            addbooks_addBtn.TabIndex = 17;
            addbooks_addBtn.Text = "ADD";
            addbooks_addBtn.UseVisualStyleBackColor = false;
            addbooks_addBtn.Click += addbooks_addBtn_Click;
            // 
            // addbooks_author
            // 
            addbooks_author.Font = new Font("Segoe UI", 10F);
            addbooks_author.Location = new Point(103, 170);
            addbooks_author.Name = "addbooks_author";
            addbooks_author.Size = new Size(211, 30);
            addbooks_author.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 10F);
            label8.Location = new Point(24, 176);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 13;
            label8.Text = "Author:";
            // 
            // addbooks_booktittle
            // 
            addbooks_booktittle.Font = new Font("Segoe UI", 10F);
            addbooks_booktittle.Location = new Point(103, 136);
            addbooks_booktittle.Name = "addbooks_booktittle";
            addbooks_booktittle.Size = new Size(211, 30);
            addbooks_booktittle.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1, 140);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 9;
            label6.Text = "Book Tittle :";
            // 
            // addbooks_picture
            // 
            addbooks_picture.BackColor = SystemColors.ButtonShadow;
            addbooks_picture.Location = new Point(103, 3);
            addbooks_picture.Name = "addbooks_picture";
            addbooks_picture.Size = new Size(100, 100);
            addbooks_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            addbooks_picture.TabIndex = 8;
            addbooks_picture.TabStop = false;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddBooks";
            Size = new Size(875, 565);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addbooks_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private DateTimePicker addbooks_published;
        private Label label2;
        private Button addbooks_updateBtn;
        private Button addbooks_addBtn;
        private TextBox addbooks_author;
        private Label label8;
        private TextBox addbooks_booktittle;
        private Label label6;
        private PictureBox addbooks_picture;
        private Label label3;
        private ComboBox addbooks_status;
        private Button addbooks_clearBtn;
        private Button addbooks_deleteBtn;
        private Button addbooks_importbtn;
    }
}
