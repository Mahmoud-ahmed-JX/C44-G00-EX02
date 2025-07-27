using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class PracticalExam:Exam
    {
       

        public override void fillQuestsArr()
        {
            Questions = new Question[NumOfQuests];
            Console.Clear();
            for (int i = 0; i < Questions.Length; i++) {
                Questions[i] = new MCQ();
            Console.WriteLine("MCQ Question");
                Questions[i].CreateQuestion();
            }
        }

        public override void ShowExam()
        {
            Answer[] userAnswers = new Answer[Questions.Length];
            for (int i = 0; i < Questions.Length; i++) {
                
                bool isParsed;
                
                Questions[i].display();
                int ansId;
                do {
                    Console.WriteLine("Please Enter the answer Id");
                    isParsed = int.TryParse(Console.ReadLine(), out ansId);
                } while (!isParsed || (ansId < 1 || ansId > Questions[i].Answers.Length));

                userAnswers[i]= Questions[i].Answers[ansId-1];
                Console.Clear();
            }

            Console.WriteLine("-----------------Answers--------------");
            for (int i = 0; i < Questions.Length; i++) {
                Console.WriteLine($"Question number {i+1}");
                Console.WriteLine($"Your Answer => {userAnswers[i].AnswerText}");
                Console.WriteLine($"Right Answer => {Questions[i].RightAns.AnswerText}");
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
