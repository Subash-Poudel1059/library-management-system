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

namespace Libarary_ManagementSystemApp
{
    public partial class ReturnBooks : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=desktop-j1rjiku\sqlexpress;Initial Catalog=LibaryManagementSystem;Integrated Security=True");
        public ReturnBooks()
        {
            InitializeComponent();
            displayIssuedBooksData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {

        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayIssuedBooksData();
        }
        private void returnBooks_returnBtn_Click(object sender, EventArgs e)
        {
            if(returnBooks_issueID.Text==""
                || returnBooks_name.Text==""
                || returnBooks_contact.Text==""
                || returnBooks_email.Text==""
                || returnBooks_bookTitle.Text==""
                || returnBooks_author.Text==""
                || returnBooks_bookIssued==null
                )
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed) 

                {
                    DialogResult check = MessageBox.Show("Are you sure that Issue ID:" + returnBooks_issueID.Text.Trim() + "is return already?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (check == DialogResult.Yes) 
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            connect.Open();

                            string updateData = "UPDATE issues SET status=@status, date_update=@dateUpdate WHERE issue_id =@issueID";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@status", "Return");
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                cmd.Parameters.AddWithValue("@issueID", returnBooks_issueID.Text.Trim());
                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();
                                MessageBox.Show("Return Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    
                }
            }

        }
        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();
            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBooks_issueID.Text = row.Cells[1].Value.ToString();
                returnBooks_name.Text = row.Cells[2].Value.ToString();
                returnBooks_contact.Text = row.Cells[3].Value.ToString();
                returnBooks_email.Text = row.Cells[4].Value.ToString();
                returnBooks_bookTitle.Text = row.Cells[5].Value.ToString();
                returnBooks_author.Text = row.Cells[6].Value.ToString();
                returnBooks_bookIssued.Text = row.Cells[7].Value.ToString();



            }
        }
        public void clearFields()
        {
            returnBooks_issueID.Text = "";
            returnBooks_name.Text = "";
            returnBooks_contact.Text = "";
            returnBooks_email.Text = "";
            returnBooks_bookTitle.Text = "";
            returnBooks_author.Text = "";
            returnBooks_bookIssued.Text = "";
        }

        private void returnBooks_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
