using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Exam
    {
        public int Time {  get; set; }
        public int NumOfQuests { get; set; }
        public Question[] Questions {  get; set; }
        public Exam()
        {
          
        }
        public abstract void fillQuestsArr();
        public abstract void ShowExam();

    }
}
