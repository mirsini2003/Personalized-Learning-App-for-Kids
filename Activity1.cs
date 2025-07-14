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
    public partial class Activity1 : Form
    {
        private int ch1_tests = 0;
        private int ch2_tests = 0;
        private int ch3_tests = 0;
        private int ch1_correct = 0;
        private int ch2_correct = 0;
        private int ch3_correct = 0;
        string username;
        string password;
        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        private SQLiteDataReader reader;
        private int difficulty;
        int correct = 0;
        private List<string> right = new List<string>();
        private List<string> wrong = new List<string>();
        private List<string> answer = new List<string>();

        public Activity1(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void αΡΧΙΚΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm(username,password).Show();
        }

        private void οΘρύλοςΤηςΚυράΦροσύνηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int unit = 1;
            this.Hide();
            new ContentForm(username, password, unit).Show();
        }

        private void ηΑρχιτεκτονικήΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int unit = 2;
            this.Hide();
            new ContentForm(username, password, unit).Show();
        }

        private void μέσαΑπόΤαΜονοπάτιαΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chapter3(username, password).Show();
        }

        private void πΗΓΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SourceForm(username, password).Show();
        }

        private void οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProfileForm(username, password).Show(); 
        }

        private void createtest(int difficulty)
        {
            string connectionString = "Data Source=db\\logismiko_db.db;Version=3;";
            conn = new SQLiteConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM Questions WHERE Chapter=1 AND Difficulty = "+difficulty.ToString();
            cmd = new SQLiteCommand(query, conn);
            reader = cmd.ExecuteReader();

            // first question
            if (reader.Read())
            {
                label3.Text = $"{reader["QuestionText"]}";
                radioButton1.Text = reader["Ans1"].ToString();
                radioButton2.Text = reader["Ans2"].ToString();
                right.Add(reader["CorrectAns"].ToString());
            }

            // second question
            if (reader.Read())
            {
                label4.Text = $"{reader["QuestionText"]}";
                radioButton3.Text = reader["Ans1"].ToString();
                radioButton4.Text = reader["Ans2"].ToString();
                right.Add(reader["CorrectAns"].ToString());
            }
            //third question
            if (reader.Read())
            {
                label5.Text = $"{reader["QuestionText"]}";
                radioButton5.Text = reader["Ans1"].ToString();
                radioButton6.Text = reader["Ans2"].ToString();
                right.Add(reader["CorrectAns"].ToString());
            }
            //fourth question     
            if (reader.Read())
            {
                label6.Text = $"{reader["QuestionText"]}";
                radioButton7.Text = reader["Ans1"].ToString();
                radioButton8.Text = reader["Ans2"].ToString();
                radioButton9.Text = reader["Ans3"].ToString();
                radioButton10.Text = reader["Ans4"].ToString();
                right.Add(reader["CorrectAns"].ToString());
            }
            //fifth question     
            if (reader.Read())
            {
                label7.Text = $"{reader["QuestionText"]}";
                radioButton11.Text = reader["Ans1"].ToString();
                radioButton12.Text = reader["Ans2"].ToString();
                radioButton13.Text = reader["Ans3"].ToString();
                radioButton14.Text = reader["Ans4"].ToString();
                right.Add(reader["CorrectAns"].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                label2.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                radioButton4.Show();
                radioButton5.Show();
                radioButton6.Show();
                radioButton7.Show();
                radioButton8.Show();
                radioButton9.Show();
                radioButton10.Show();
                radioButton11.Show();
                radioButton12.Show();
                radioButton13.Show();
                radioButton14.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();
                groupBox5.Show();
                submit_btn.Show();
                difficulty = 1;
                createtest(difficulty);

            // Clear selection
            radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.DimGray)
            {
                MessageBox.Show("Answer the previous question correctly first.");
            }
            else
            {
                label2.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();

                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                radioButton4.Show();
                radioButton5.Show();
                radioButton6.Show();
                radioButton7.Show();
                radioButton8.Show();
                radioButton9.Show();
                radioButton10.Show();
                radioButton11.Show();
                radioButton12.Show();
                radioButton13.Show();
                radioButton14.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();
                groupBox5.Show();
                submit_btn.Show();
                difficulty = 2;
                createtest(difficulty);

                // Clear selection
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.DimGray)
            {
                MessageBox.Show("Answer the previous question correctly first.");
            }
            else
            {
                label2.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();

                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                radioButton4.Show();
                radioButton5.Show();
                radioButton6.Show();
                radioButton7.Show();
                radioButton8.Show();
                radioButton9.Show();
                radioButton10.Show();
                radioButton11.Show();
                radioButton12.Show();
                radioButton13.Show();
                radioButton14.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();
                groupBox5.Show();
                submit_btn.Show();
                difficulty = 3;
                createtest(difficulty);
                // clear selections
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
            }
        }

        private void Activity1_Load(object sender, EventArgs e)
        {
          //  
            Fortosi();
            string connectionString = "Data Source=db\\logismiko_db.db;Version=3;";

            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM test_results WHERE chapter = 1 AND student= '" + username + "'";
            cmd = new SQLiteCommand(query, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["difficulty"].ToString().Equals("1"))
                {
                    ch1_tests++;
                    ch1_correct += Convert.ToInt32(reader["score"]);
                }
                if (reader["difficulty"].ToString().Equals("2"))
                {
                    ch2_tests++;
                    ch2_correct += Convert.ToInt32(reader["score"]);
                }
                if (reader["difficulty"].ToString().Equals("3"))
                {
                    ch3_tests++;
                    ch3_correct += Convert.ToInt32(reader["score"]);
                }
            }
            if (ch1_tests > 0)
            {
                double percentage = 100.0 * ch1_correct / (ch1_tests * 5);
                if (percentage <= 50)
                {
                    button2.BackColor = Color.DimGray;
                }
            }
            else
            {
                button2.BackColor = Color.DimGray;
            }
            if (ch2_tests > 0)
            {
                double percentage = 100.0 * ch2_correct / (ch2_tests * 5);
                if (percentage <= 50 || button2.BackColor.Equals(Color.DimGray))
                {
                    button3.BackColor = Color.DimGray;
                }
            }
            else { button3.BackColor = Color.DimGray; }
             
                reader.Close();
            conn.Close();
        }
        private void Fortosi()
        {
            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
            label2.Show();
            label8.Text = "You answered correctly to ";
            pictureBox1.Hide();
            button4.Hide();
            button1.Show();
            button2.Show();
            button3.Show();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            radioButton5.Hide();
            radioButton6.Hide();
            radioButton7.Hide();
            radioButton8.Hide();
            radioButton9.Hide();
            radioButton10.Hide();
            radioButton11.Hide();
            radioButton12.Hide();
            radioButton13.Hide();
            radioButton14.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            submit_btn.Hide();
        }
        private void submit_btn_Click(object sender, EventArgs e)
        {
            // check for every question
            bool q1Answered = radioButton1.Checked || radioButton2.Checked;
            bool q2Answered = radioButton3.Checked || radioButton4.Checked;
            bool q3Answered = radioButton5.Checked || radioButton6.Checked;
            bool q4Answered = radioButton7.Checked || radioButton8.Checked || radioButton9.Checked || radioButton10.Checked;
            bool q5Answered = radioButton11.Checked || radioButton12.Checked || radioButton13.Checked || radioButton14.Checked;
           

            if (!q1Answered || !q2Answered || !q3Answered || !q4Answered || !q5Answered )
            {
                MessageBox.Show("Please answer all questions before continuing.", "Unanswered questions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButton1.Checked && !radioButton2.Checked)
            {
                answer.Add(radioButton1.Text);
            }
            else if (!radioButton1.Checked && radioButton2.Checked)
            {
                answer.Add(radioButton2.Text);
            }

            if (radioButton3.Checked && !radioButton4.Checked)
            {
                answer.Add(radioButton3.Text);
            }
            else if (!radioButton3.Checked && radioButton4.Checked)
            {
                answer.Add(radioButton4.Text);
            }

            if (radioButton5.Checked && !radioButton6.Checked)
            {
                answer.Add(radioButton5.Text);
            }
            else if (!radioButton5.Checked && radioButton6.Checked)
            {
                answer.Add(radioButton6.Text);
            }

            if (radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked && !radioButton10.Checked)
            {
                answer.Add(radioButton7.Text);
            }
            else if (!radioButton7.Checked && radioButton8.Checked && !radioButton9.Checked && !radioButton10.Checked)
            {
                answer.Add(radioButton8.Text);
            }
            else if (!radioButton7.Checked && !radioButton8.Checked && radioButton9.Checked && !radioButton10.Checked)
            {
                answer.Add(radioButton9.Text);
            }
            else if (!radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked && radioButton10.Checked)
            {
                answer.Add(radioButton10.Text);
            }

            if (radioButton11.Checked && !radioButton12.Checked && !radioButton13.Checked && !radioButton14.Checked)
            {
                answer.Add(radioButton11.Text);
            }
            else if (!radioButton11.Checked && radioButton12.Checked && !radioButton13.Checked && !radioButton14.Checked)
            {
                answer.Add(radioButton12.Text);
            }
            else if (!radioButton11.Checked && !radioButton12.Checked && radioButton13.Checked && !radioButton14.Checked)
            {
                answer.Add(radioButton13.Text);
            }
            else if (!radioButton11.Checked && !radioButton12.Checked && !radioButton13.Checked && radioButton14.Checked)
            {
                answer.Add(radioButton14.Text);
            }
            for (int i = 0; i < answer.Count; i++)
            {
                if (answer[i].Equals(right[i]))
                {
                    correct++;
                }
            }
            
            label8.Text +=correct.ToString()+"/5 questions";
            // If all are answered, continue with saving or next step


            string connectionString = "Data Source=db\\logismiko_db.db;Version=3;";
            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string insertQuery = "INSERT INTO test_results (student, chapter, date, difficulty, score) VALUES (@name, 1, @date, @diff, @score)";

            using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn))
            {
                insertCmd.Parameters.AddWithValue("@name", username);
                insertCmd.Parameters.AddWithValue("@date", DateTime.Today.ToString());
                insertCmd.Parameters.AddWithValue("@diff", difficulty);
                insertCmd.Parameters.AddWithValue("@score", correct);

                int rowsAffected = insertCmd.ExecuteNonQuery();
                if (rowsAffected > 0) 
                {
                    MessageBox.Show("All responses have been saved.", "Success");
                }
            }
            conn.Close();




            label8.Show();
            button4.Show();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            radioButton5.Hide();
            radioButton6.Hide();
            radioButton7.Hide();
            radioButton8.Hide();
            radioButton9.Hide();
            radioButton10.Hide();
            radioButton11.Hide();
            radioButton12.Hide();
            radioButton13.Hide();
            radioButton14.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            submit_btn.Hide();
            pictureBox1.Show();
            if (correct <= 2)
            {
                pictureBox1.Image =Properties.Resources.fail;
            }
            else if (correct <= 4) 
            {
                pictureBox1.Image = global::ergasia_logismikou.Properties.Resources.source;
            }
            else
            {
                pictureBox1.Image = global::ergasia_logismikou.Properties.Resources.congrats1;
            }
            correct = 0;
            right.Clear();
            wrong.Clear();
            answer.Clear();
            
        }

        private void Activity1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Activity2(username,password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Activity3(username, password).Show();
        }

        private void οΛΕΣΟΙΕΝΟΤΗΤΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActivityAll(username, password).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fortosi();
        }

        private void γιαννιώτικεςΣυνταγέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Recipes(username, password).Show();
        }

     
    }
}
