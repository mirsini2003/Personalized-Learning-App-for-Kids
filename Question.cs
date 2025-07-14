using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ergasia_logismikou
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string Ans1 { get; set; }
        public string Ans2 { get; set; }
        public string Ans3 { get; set; }
        public string Ans4 { get; set; }
        public string CorrectAns { get; set; }
        public float Chapter { get; set; }
        public int Difficulty { get; set; }


    }
}
