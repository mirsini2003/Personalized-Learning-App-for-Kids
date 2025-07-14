using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia_logismikou
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Δημιουργία νέου αντικειμένου χρήστη
            User user = new User();

            // Κλήση της μεθόδου login() και αποθήκευση του μηνύματος κατάστασης
            string status = user.login(textUsername.Text, textPassword.Text);
            // Έλεγχος αν η είσοδος ήταν επιτυχής
            if (status == "Successful log-in")
            {
                // Αν το login είναι επιτυχές, κρύβουμε το τρέχον παράθυρο και ανοίγουμε το νέο               
                this.Hide();
                new HomeForm(textUsername.Text, textPassword.Text).Show();
            }
            else
            {
                // Αν το login αποτύχει, εμφανίζουμε το μήνυμα κατάστασης που επιστρέφει η μέθοδος login
                MessageBox.Show(status);
            }
            //κάνω clear τα πεδία
            textUsername.Text = "";
            textPassword.Text = "";
            textUsername.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //κάνω clear τα πεδία
            textUsername.Text = "";
            textPassword.Text = "";
            textUsername.Focus();
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
