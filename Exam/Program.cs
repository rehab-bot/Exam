using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new(1, "C sharp");

            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the Exam (Y | N): ");
            char c = char.Parse(Console.ReadLine());

            if (c == 'Y' || c == 'y')
            {
                Console.Clear();
                Stopwatch sw = new();
                sw.Start();
                subject.SubjectExam.ShowExam();
                Console.WriteLine($"taken time : {sw.Elapsed}");
                Console.WriteLine("Thank you!");

            }
            else
                Console.WriteLine("Thank you!");

        }
    }

}
