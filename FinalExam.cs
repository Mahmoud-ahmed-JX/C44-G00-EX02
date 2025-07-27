using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class FinalExam : Exam
    {
        public int Grade {  get; set; }
        public override void fillQuestsArr()
        {
            Questions = new Question[NumOfQuests];

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.Clear();
                bool isParsed;
                int num;
                do
                {
                    Console.WriteLine("Please Enter the type of Question(1 for MCQ | 2 For True Or False)");
                    isParsed = int.TryParse(Console.ReadLine(), out num);
                } while (!isParsed || (num != 1 && num != 2));

                if (num == 1)
                    Questions[i] = new MCQ();
                
                else
                    Questions[i] = new True_False();

                Questions[i].CreateQuestion();

                
            
            }
        }

        public override void ShowExam()
        {
            Grade = 0;
            int totalGrade=0;
            Answer[] userAnswers = new Answer[Questions.Length];
            for (int i = 0; i < Questions.Length; i++)
            {

                bool isParsed;
                
                Questions[i].display();
                int ansId;
                do
                {
                    Console.WriteLine("Please Enter the answer Id");
                    isParsed = int.TryParse(Console.ReadLine(), out ansId);
                } while (!isParsed || (ansId < 1 || ansId > Questions[i].Answers.Length));

                userAnswers[i] = Questions[i].Answers[ansId - 1];
                if (userAnswers[i] == Questions[i].RightAns)
                    Grade += Questions[i].Mark;
                totalGrade += Questions[i].Mark;
                Console.Clear();
         }
            for (int i = 0; i < Questions.Length; i++) {
                Console.WriteLine($"Question {i+1}: {Questions[i].Body}");
                Console.WriteLine($"Your Answer: {userAnswers[i].AnswerText}");
                Console.WriteLine($"Right Answer: {Questions[i].RightAns.AnswerText}");
                Console.WriteLine("----------------------------------------------------");
            }
            Console.WriteLine($"Your Grade is {Grade} from {totalGrade}");
        }
    }
}
