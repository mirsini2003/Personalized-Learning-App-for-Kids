using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia_logismikou
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LogIn().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("There are empty fields!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                string connectionString = "Data Source=db\\logismiko_db.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        //check if username already exists
                        string checkQuery = "SELECT COUNT(*) FROM User WHERE Username = @name";
                        using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@name", txtUsername.Text);
                            long userExists = (long)checkCmd.ExecuteScalar();

                            if (userExists > 0)
                            {
                                MessageBox.Show("This username is already taken. Please choose another one.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                txtConPassword.Text = "";
                                return;
                            }
                        }

                        // if it does not exist, we import it as normal
                        string insertQuery = "INSERT INTO User (Username, Password) VALUES (@name, @password)";

                        using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@name", txtUsername.Text);
                            insertCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                           

                            int rowsAffected = insertCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // clear fields and go to home page
                                string username = txtUsername.Text;
                                string password = txtPassword.Text;
                              
                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                txtConPassword.Text = "";

                                this.Hide();
                                new HomeForm(username, password).Show();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
          
        }
        

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //clear fields
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            this.Cursor= Cursors.Hand;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
