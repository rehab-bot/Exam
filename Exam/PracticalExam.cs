using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal  class PracticalExam : Examination
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions) { }

            public override void CreateListOfQuestions()
            {
            questions = new MCQQuestion[numberOfQuestions];
                for (int i = 0; i < questions.Length; i++)
                {
                questions[i] = new MCQQuestion();
                questions[i].AddQuestion();
                    Console.Clear();
                }
            }

            public override void ShowExam()
            {

                foreach (var Question in questions)
                {
                    Console.WriteLine(Question);
                    for (int i = 0; i < Question.AnswerList.Length; i++)
                    {
                        Console.WriteLine(Question.AnswerList[i]);
                    }
                    Console.WriteLine("---------------------------");

                    int UserAnswerId;
                    do
                    {
                        Console.WriteLine("Enter The Number Of You Answer:");

                    }
                    while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 ||
                        UserAnswerId > 3);

                   
                    Console.WriteLine("-----------------");
                }
                Console.Clear();

                Console.WriteLine("right answers:");
                for (int i = 0; i < questions.Length; i++)
                {
                    Console.WriteLine($"right answer of question {i + 1} : " +
                        $"{questions[i].RightAnswer.AnswerText}");
                }
            }
        }
    }
