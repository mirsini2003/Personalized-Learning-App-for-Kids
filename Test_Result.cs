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
    public partial class Test_Result : UserControl
    {
        private string chapter;
        private int difficulty;
        private int score;
        private string date;
        public Test_Result()
        {
            InitializeComponent();
        }

        public Test_Result(string chapter, int difficulty, int score, string date)
        {
            InitializeComponent();
            this.chapter = chapter;
            this.difficulty = difficulty;
            this.score = score;
            this.date = date;
        }

        private void Test_Result_Load(object sender, EventArgs e)
        {
            label1.Text += chapter;
            if (difficulty == 1)
            {
                label2.Text += "ΕΥΚΟΛΟ";
            }
            else if (difficulty == 2)
            {
                label2.Text += "ΜΕΤΡΙΟ";
            }
            else 
            {
                label2.Text += "ΔΥΣΚΟΛΟ";
            }

            if (score >= 4)
            {
                label3.ForeColor = Color.Green;
            }
            else if (score == 2 || score == 3)
            {
                label3.ForeColor = Color.Orange;
            }
            else if (score == 0 || score == 1)
            {
                label3.ForeColor = Color.Red;
            }
            label3.Text += score.ToString() + "/5";
            label4.Text += date;
        }
    }
}
