using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Exam exam { get; set; }


        public void CreatExam()
        {
            Console.Clear();
            bool isParsed;
            int examtype;
            do
            {
                Console.WriteLine("Please Enter the type of exam (1 for Practical | 2 for Final)");
                isParsed = int.TryParse(Console.ReadLine(), out examtype);
            } while (!isParsed || (examtype != 1 && examtype != 2));
            if (examtype == 1)
                exam = new PracticalExam();
            else
                exam = new FinalExam();
            uint time;
            do
            {
                Console.WriteLine("Please Enter the time for Exax (30 min to 180 min)");
                isParsed = uint.TryParse(Console.ReadLine(), out time);
            } while (!isParsed || (time < 30 || time > 180));
            exam.Time = (int)time;

            uint numOfQuests;
            do
            {
                Console.WriteLine("Please Enter the number of Questions");
                isParsed = uint.TryParse(Console.ReadLine(), out numOfQuests);
            } while (!isParsed || (numOfQuests == 0));
            exam.NumOfQuests = (int)numOfQuests;

            exam.fillQuestsArr();
        }
    }
}
