using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class MCQ:Question
    {

        public MCQ()
        {
            Header = "Choose the correct answer";
            Answers = new Answer[3];
        }

        public override void CreateQuestion()
        {
            Console.Clear();
            Console.WriteLine("MCQ Question");
            bool isParsed;
            do
            {
                Console.WriteLine("Enter the Body of the Question");
                Body = Console.ReadLine();
            } while (Body is null||Body.Length==0);

            uint mark;
            do
            {
                Console.WriteLine("Enter the question mark");
                isParsed = uint.TryParse(Console.ReadLine(), out mark);
            } while (!isParsed||(mark==0));
            
            Mark =(int) mark;

            for (int i = 0; i < Answers.Length; i++)
            {
                string? anstext;
                do
                {
                    Console.WriteLine($"Enter the answer number {i+1} ");
                      anstext=Console.ReadLine();
                } while (anstext is null || anstext.Length == 0);
                Answers[i] = new Answer(i+1,anstext);
            }
           
            int id;
            do
            {
                Console.WriteLine("Enter the id of the right answer ");
                isParsed=int.TryParse(Console.ReadLine(), out id);
            } while (!isParsed ||(id<1||id>Answers.Length));
            RightAns = Answers[id - 1];


            
        }
    }
}
