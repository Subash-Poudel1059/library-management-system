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
    public partial class LoginForm : Form
    {
     SqlConnection Connect = new SqlConnection(@"Data Source=desktop-j1rjiku\sqlexpress;Initial Catalog=LibaryManagementSystem;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void Loginbtn_Click(object sender, EventArgs e)

        {
       
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all  blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                    try
                    {
                        Connect.Open();
                        string selectData = "SELECT *  FROM Registration WHERE Username = @USERNAME AND Password = @PASSWORD";
                    using (SqlCommand cmd = new SqlCommand(selectData, Connect))
                    {
                        cmd.Parameters.AddWithValue("@USERNAME", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@PASSWORD", login_password.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successfully!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("error connecting data base" + ex.Message, "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Connect.Close();
                    }
                

             }   
        }
    }
}
