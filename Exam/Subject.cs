using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal  class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public Examination SubjectExam { get; set; }

        public Subject(int subjectId, string subjectName)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
            }

           





            public void CreateExam()
            {
                int ExamType, Time, NumberOfQuestions;

                do
                {
                    Console.WriteLine("Please Enter the type of Exam (1 for Practical  / 2 for final: )");
                }
                while (!int.TryParse(Console.ReadLine(), out ExamType) && ExamType < 1 || ExamType > 2);


                do
                {
                    Console.WriteLine("Please Enter The Time of Exam from (30 to 180 min): ");
                }
                while (!int.TryParse(Console.ReadLine(), out Time) || (Time < 30 || Time > 180));

                do
                {
                    Console.WriteLine("Please Enter The Number Of Questions:");

                }
                while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions));

                if (ExamType == 1)
                {
                    SubjectExam = new PracticalExam(Time, NumberOfQuestions);
                }
                else
                    SubjectExam = new FinalExam(Time, NumberOfQuestions);


                Console.Clear();

                SubjectExam.CreateListOfQuestions();

            }
        }
}
      
    


