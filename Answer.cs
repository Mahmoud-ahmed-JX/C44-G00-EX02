using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int _AnswerID, string _AnswerText) {  AnswerId = _AnswerID; AnswerText = _AnswerText; }
    }
}
