using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia_logismikou
{
    public partial class SourceForm : Form
    {
        string username;
        string password;
        public SourceForm(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void αΡΧΙΚΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm(username, password).Show();
        }

       

        private void οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProfileForm(username, password).Show();
        }

        private void SourceForm_Load(object sender, EventArgs e)
        {
            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.travelgo.gr/ioannina/421914/ioannina-i-paramythenia-poli-tis-ipeiroy-me-tin-ploysia-istoria";
            Uri uriResult;

            bool validUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl)
            {
                Process.Start(new ProcessStartInfo(uriResult.ToString()) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The URL is not valid.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://ioannina.gr/%CE%B9%CF%83%CF%84%CE%BF%CF%81%CE%B9%CE%BA%CE%AE-%CE%B1%CE%BD%CE%B1%CE%B4%CF%81%CE%BF%CE%BC%CE%AE-%CF%83%CF%84%CE%B7%CE%BD-%CF%80%CF%8C%CE%BB%CE%B7-%CF%84%CF%89%CE%BD-%CE%B3%CF%81%CE%B1%CE%BC/";
            Uri uriResult;

            bool validUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl)
            {
                Process.Start(new ProcessStartInfo(uriResult.ToString()) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The URL is not valid.");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string url = "https://www.mixanitouxronou.gr/periigisi-stin-poli-ton-ioanninon-apo-psila-ta-koryfaia-axiotheata-kai-mnimeia/";
            Uri uriResult;

            bool validUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl)
            {
                Process.Start(new ProcessStartInfo(uriResult.ToString()) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The URL is not valid.");
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=jAxXbdtZ-mQ";
            Uri uriResult;

            bool validUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl)
            {
                Process.Start(new ProcessStartInfo(uriResult.ToString()) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The URL is not valid.");
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string url = "https://www.youtube.com/watch?v=4mZMY_wWN90";
            Uri uriResult;

            bool validUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl)
            {
                Process.Start(new ProcessStartInfo(uriResult.ToString()) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The URL is not valid..");
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=e8vD7cM3G34";
            Uri uriResult;

            bool validUrl = Uri.TryCreate(url, UriKind.Absolute, out uriResult) &&
                            (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl)
            {
                Process.Start(new ProcessStartInfo(uriResult.ToString()) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The URL is not valid.");
            }
        }

        private void SourceForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void μέσαΑπόΤαΜονοπάτιαΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
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
