using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Libarary_ManagementSystemApp
{
    public partial class AddBooks : UserControl

    {
        SqlConnection connect = new SqlConnection(@"Data Source=desktop-j1rjiku\sqlexpress;Initial Catalog=LibaryManagementSystem;Integrated Security=True");
        public AddBooks()
        {
            InitializeComponent();
            displayBooks();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayBooks();
        }

        private void addbooks_importbtn_Click(object sender, EventArgs e)
        {
            string imagepath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg;  *.png)|* .jpg;*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    addbooks_picture.ImageLocation = imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { connect.Close(); }
        }

        private void addbooks_addBtn_Click(object sender, EventArgs e)
        {

            if (addbooks_picture.Image == null
                || addbooks_booktittle.Text == ""
                || addbooks_author.Text == ""
                || addbooks_published.Value == null
                || addbooks_status.Text == ""
                || addbooks_picture.Image == null
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string insertData = "INSERT INTO books(book_title,author,published_date,status,image,date_insert) VALUES(@bookTitle,@author,@published_date,@status,@image,@date_insert)";

                        string path = Path.Combine(@"D:\project 1\Library Management System\Libarary ManagementSystemApp\Books_Directory"
                       + addbooks_booktittle.Text + addbooks_author.Text.Trim() + ".jpg");

                        string directoryPath = Path.GetDirectoryName(path);
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }

                        File.Copy(addbooks_picture.ImageLocation, path, true);

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookTitle", addbooks_booktittle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", addbooks_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@published_date", addbooks_published.Value);
                            cmd.Parameters.AddWithValue("@status", addbooks_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@date_insert", today);

                            cmd.ExecuteNonQuery();

                            displayBooks();

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { connect.Close(); }
                }
            }
        }

        public void clearFields()
        {
            addbooks_booktittle.Text = "";
            addbooks_author.Text = "";
            addbooks_picture.Image = null;
            addbooks_status.SelectedIndex = -1;
        }
        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List<DataAddBooks> listdata = dab.addBooksData();
            dataGridView1.DataSource = listdata;
        }
        private int bookId = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookId = (int)row.Cells[0].Value;
                addbooks_booktittle.Text = row.Cells[1].Value.ToString();
                addbooks_author.Text = row.Cells[2].Value.ToString();
                addbooks_published.Text = row.Cells[3].Value.ToString();

                string imagePath = row.Cells[4].Value.ToString();
                if (imagePath != null || imagePath.Length >= 1)
                {
                    addbooks_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addbooks_picture.Image = null;
                }
                addbooks_status.Text = row.Cells[5].Value.ToString();
            }
        }

        private void addbooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addbooks_updateBtn_Click(object sender, EventArgs e)
        {
            if (addbooks_picture.Image == null
               || addbooks_booktittle.Text == ""
               || addbooks_author.Text == ""
               || addbooks_published.Value == null
               || addbooks_status.Text == ""
               || addbooks_picture.Image == null
               )
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you Sure you want to UPDATE Book ID:"
                        + bookId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET book_title= @bookTitle" + ",author=@author,published_date=@published" +
                                ",status=@status,date_update=@dateUpdate WHERE id=@id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", addbooks_booktittle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addbooks_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", addbooks_published.Value);
                                cmd.Parameters.AddWithValue("@status", addbooks_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@id", bookId);
                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Update successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void addbooks_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addbooks_picture.Image == null
              || addbooks_booktittle.Text == ""
              || addbooks_author.Text == ""
              || addbooks_published.Value == null
              || addbooks_status.Text == ""
              || addbooks_picture.Image == null
              )
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you Sure you want to DELETE Book ID:"
                        + bookId + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE books SET date_delete=@dateDelete WHERE id=@id" ;
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookId);
                                cmd.ExecuteNonQuery();

                                displayBooks();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
    }
}
