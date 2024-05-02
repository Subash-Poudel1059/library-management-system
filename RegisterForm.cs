using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Libarary_ManagementSystemApp
{
    public partial class RegisterForm : Form
    {
      SqlConnection Connect = new SqlConnection(@"Data Source=desktop-j1rjiku\sqlexpress;Initial Catalog=LibaryManagementSystem;Integrated Security=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Connect.State!=ConnectionState.Open)
            {
               try
                { 
                   Connect.Open();
                    String Checkusername = "select count(*) From Registration WHERE username=@Username";
                    using (SqlCommand CheckCMD = new SqlCommand(Checkusername, Connect))
                    {
                        CheckCMD.Parameters.AddWithValue("Username",usernametextbox.Text.Trim());
                        int count = (int)CheckCMD.ExecuteScalar();

                        if (count >= 1)
                        {
                            MessageBox.Show(usernametextbox.Text.Trim()+
                             "is already taken" , "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            String insertData = "INSERT INTO Registration(EMAIL,USERNAME,ADDRESS,contact,MEMBERSHIPNO,GENDER,PASSWORD,CONFIRM_PASSWORD )" +
                               " VALUES(@EMAIL,@USERNAME,@ADDRESS,@contact,@MEMBERSHIPNO,@GENDER,@PASSWORD,@CONFIRM_PASSWORD)";
                            using (SqlCommand insertCMD = new SqlCommand(insertData, Connect))
                            {
                                insertCMD.Parameters.AddWithValue("@EMAIL", emailtextbox.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@USERNAME", usernametextbox.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@ADDRESS", addresstext.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@contact", contacttext.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@MEMBERSHIPNO", textBox1.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@GENDER", gender.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@PASSWORD", passwordtextbox.Text.Trim());
                                insertCMD.Parameters.AddWithValue("@CONFIRM_PASSWORD", confirmpasstext.Text.Trim());
                                insertCMD.ExecuteNonQuery();
                                MessageBox.Show("REGISTER SUCCESFULL!", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoginForm loginForm = new LoginForm();
                                this.Hide();
                                    loginForm.Show();
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("error connecting data base"+ex.Message,"error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                  //  Connect.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordtextbox.PasswordChar = checkBox1.Checked ? '\0' : '*';
            confirmpasstext.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void contactlabel_Click(object sender, EventArgs e)
        {

        }

        private void confirmpasstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();

        }

        private void emailtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (emailtextbox.Text == "")
                {
                    MessageBox.Show("Blank not Allowed");
                }

                else
                {
                    string uemail;

                    uemail = emailtextbox.Text;
                }
            }
        }

        private void usernametextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (usernametextbox.Text == "")
                {
                    MessageBox.Show("Blank not Allowed");
                }

                else
                {
                    string uname;

                    uname = usernametextbox.Text;
                }
            }
        }

        private void contacttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (contacttext.Text == "")
                {
                    MessageBox.Show("Blank not Allowed");
                }

                else
                {
                    string ucontact;

                    ucontact = contacttext.Text;
                }
            }
        }

        private void addresstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (addresstext.Text == "")
                {
                    MessageBox.Show("Blank not Allowed");
                }

                else
                {
                    string uadd;

                    uadd = addresstext.Text;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Blank not Allowed");
                }

                else
                {
                    string idnoo;

                    idnoo = textBox1.Text;
                }
            }
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (passwordtextbox.Text == "")
                {
                    MessageBox.Show("Blank not Allowed");
                }

                else if (passwordtextbox.Text.Length > 7)
                {
                    MessageBox.Show("Password Must Be Greater then 8 Letter");
                }
                else
                {
                    passwordtextbox.Enabled = true;
                    passwordtextbox.Focus();
                }
            }
        }

        private void confirmpasstext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (confirmpasstext.Text == "")
            {
                MessageBox.Show("Blank not Allowed");
            }

            else if (confirmpasstext.Text.Length > 7)
            {
                MessageBox.Show("Password Must Be 8 Letter");
            }
            else if (confirmpasstext.Text != passwordtextbox.Text)
            {
                MessageBox.Show("Password Do Not Match");
            }
            else
            {
                MessageBox.Show("Password Matches.");

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
