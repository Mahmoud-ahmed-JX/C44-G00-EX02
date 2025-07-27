using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers {get;set;}
        public Answer RightAns { get; set; }

        public abstract  void CreateQuestion();

        public void display()
        {
            Console.WriteLine(Header +$"   mark: {Mark}");
            Console.WriteLine(Body);
            for (int i = 0;i < Answers.Length; i++)
            {
                Console.WriteLine($"{i+1}: {Answers[i].AnswerText}");
            }
        }
    }
}
