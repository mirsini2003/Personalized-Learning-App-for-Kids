using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Speech.Synthesis;

namespace ergasia_logismikou
{
    public partial class HomeForm : Form
    {
        string username;
        private string file = "arxiki.wav";
        SpeechSynthesizer synth = new SpeechSynthesizer();
        string password;
        public HomeForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        
        private void πΗΓΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new SourceForm(username, password).Show();
        }

        private void οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new ProfileForm(username, password).Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void οΘρύλοςΤηςΚυράΦροσύνηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            int unit = 1;
            this.Hide();
            new ContentForm(username, password, unit).Show();
        }

        private void ηΑρχιτεκτονικήΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            int unit = 2;
            this.Hide();
            new ContentForm(username, password, unit).Show();
        }

        private void μέσαΑπόΤαΜονοπάτιαΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Chapter3(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Activity1(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Activity2(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Activity3(username, password).Show();

        }

        private void pictureBox_speak_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync(label2.Text);
        }

        private void pictureBox_stop_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
        }

        private void γιαννιώτικεςΣυνταγέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Recipes(username, password).Show();
        }

        private void οΛΕΣΟΙΕΝΟΤΗΤΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new ActivityAll(username,password).Show();
        }
    }
}
