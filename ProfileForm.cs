using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ergasia_logismikou
{
    public partial class ProfileForm : Form
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
        ToolTip toolTip1 = new ToolTip();
        public ProfileForm(string username,string password)
        {
            InitializeComponent();
            this.username= username;
            this.password= password;
        }

        private void αΡΧΙΚΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm(username, password).Show();
        }
       

        

        private void πΗΓΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SourceForm(username, password).Show();
        }

       
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
            string connectionString = "Data Source=db\\logismiko_db.db;Version=3;";

            conn = new SQLiteConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM test_results WHERE student= '"+username+"'";
            cmd = new SQLiteCommand(query, conn);
            reader = cmd.ExecuteReader();

            // 1st question
            while (reader.Read())
            {
                flowLayoutPanel1.Controls.Add(new Test_Result(reader["chapter"].ToString(),Convert.ToInt32( reader["difficulty"]),Convert.ToInt32( reader["score"]), reader["date"].ToString()));
                if (reader["chapter"].ToString().Equals("1"))
                {
                    ch1_tests++;
                    ch1_correct += Convert.ToInt32(reader["score"]);
                }
                if (reader["chapter"].ToString().Equals("2"))
                {
                    ch2_tests++;
                    ch2_correct += Convert.ToInt32(reader["score"]);
                }
                if (reader["chapter"].ToString().Equals("3"))
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
                    label3.Show();
                }
            }
            if (ch2_tests > 0)
            {
                double percentage = 100.0 * ch2_correct / (ch2_tests * 5);
                if (percentage <= 50)
                {
                    label4.Show();
                }
            }
            if (ch3_tests != 0)
            {
                double percentage = 100.0 * ch3_correct / (ch3_tests * 5);
                if (percentage <= 50)
                {
                    label5.Show();
                }
            }
            reader.Close();
            conn.Close();
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chapter3(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Activity1(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Activity2(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Activity3(username, password).Show();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label3, "Click here to view the suggested section");
            this.Cursor= Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label4, "Click here to view the suggested section");
            this.Cursor = Cursors.Hand;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label5, "Click here to view the suggested section");
            this.Cursor = Cursors.Hand;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            int unit = 1;
            new ContentForm(username, password, unit).Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            int unit = 2;
            new ContentForm(username, password, unit).Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chapter3(username, password).Show();
        }

        private void γιαννιώτικεςΣυνταγέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Recipes(username, password).Show();

        }

        private void οΛΕΣΟΙΕΝΟΤΗΤΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActivityAll(username, password).Show();
        }
    }
}
