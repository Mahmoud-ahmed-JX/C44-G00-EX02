using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class True_False : Question
    {
        public True_False()
        {
            Header = "True Or False";
            Answers = new Answer[]{
                new Answer(1, "True"),
                new Answer(2, "False")

            };
        }
        public override void CreateQuestion()
        {
            Console.Clear();
            Console.WriteLine("True Or False");
            bool isParsed;

            do
            {
                Console.WriteLine("Enter the Body of the Question");
                Body = Console.ReadLine();
            } while (Body is null || Body.Length == 0);

            uint mark;
            do
            {
                Console.WriteLine("Enter the question mark");
                isParsed = uint.TryParse(Console.ReadLine(), out mark);
            } while (!isParsed||mark==0);

            Mark =(int) mark;

            int id;
            do
            {
                Console.WriteLine("Enter the id of the right answer (1 for (True) | 2 for (False))");
                isParsed = int.TryParse(Console.ReadLine(), out id);
            } while (!isParsed || (id != 1 && id != 2));

            RightAns = Answers[id - 1];


        }
    }
}
