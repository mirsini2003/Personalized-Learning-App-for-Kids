using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia_logismikou
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        
        public string login(string temp_user, string temp_password)
        {
            string connectionString = "Data Source=db\\logismiko_db.db;Version=3;";
            string status = "temp";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT Username, Password FROM User WHERE Username = @username;";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", temp_user);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                this.Username = reader["Username"].ToString();
                                this.Password = reader["Password"].ToString();
                               

                                // check
                                MessageBox.Show($"Password in DB: '{this.Password}'\nInput: '{temp_password}'", "Debug");
                            }

                            if (this.Username == null)
                            {
                                status = "The username does not exist!";
                            }
                            else if (this.Username.Equals(temp_user) && !temp_password.Trim().Equals(this.Password.Trim()))
                            {
                                status = "The password is wrong!";
                            }
                            else if (this.Username.Equals(temp_user) && temp_password.Trim().Equals(this.Password.Trim()))
                            {
                                status = "Successful log-in";
                            }
                            else
                            {
                                status = "Error";
                            }
                        }
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    status = "Database Error: " + ex.Message;
                }
            }

            return status;
        }
        
    }
}
