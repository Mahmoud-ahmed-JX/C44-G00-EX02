namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject()
            {
                Id = 1,
                Name = "Test"
            };
            subject.CreatExam();
            string ans;
            do {
            Console.WriteLine("Do you want to start the exam (Y/N)");
                ans = Console.ReadLine();
               }while (!ans.Equals("Y")&& !ans.Equals("N")&& !ans.Equals("y")&& !ans.Equals("n"));
            if (ans.Equals("Y")|| ans.Equals("y"))
            {
                Console.Clear();
                DateTime start= DateTime.Now;
                subject.exam.ShowExam();
                DateTime end= DateTime.Now;
                Console.WriteLine($"Time: {(end-start).TotalSeconds}");
                Console.WriteLine("Thank you");
            }
            
        }
    }
}
