using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam
{
    internal class FinalExam : Examination
    {



    
            public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
            {
            }

            public override void CreateListOfQuestions()
            {
            questions = new Question[numberOfQuestions];

                for (int i = 0; i < questions.Length; i++)
                {
                    int choice;

                    do
                    {


                        Console.WriteLine("Please Enter the type of Question (1 for MSQ / 2 for True or False");
                    } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2);

                    Console.Clear();
                    if (choice == 1)
                    {
                    questions[i] = new MCQQuestion();
                    questions[i].AddQuestion();
                    }
                    else if (choice == 2)
                    {
                    questions[i] = new TrueFalseQuestion();
                    questions[i].AddQuestion();
                    }

                }
            }

            public override void ShowExam()
            {
               double totalMarks = 0, Grade = 0;

                foreach (var Question in questions)
                {

                    Console.WriteLine(Question);

                  

                    for (int i = 0; i < Question.AnswerList.Length; i++)
                    {
                        Console.WriteLine(Question.AnswerList[i]);
                    }
                    Console.WriteLine("---------------------------");


                   
                    int UserAnswerId;

                    if (Question.Header == "MCQ Question")
                    {


                        do
                        {
                            Console.WriteLine(" Please Enter Number Of Your Answer:");

                        }
                        while ((!int.TryParse(Console.ReadLine(), out UserAnswerId)) || (UserAnswerId < 1 || UserAnswerId > 3));

                        Question.UserAnswer.AnswerId = UserAnswerId;
                        Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;

                        Console.WriteLine("-----------------");



                    }

                    else if (Question.Header == "True or False question")
                    {


                        do
                        {
                            Console.WriteLine("Please Enter Number Of Your Answer:");

                        }
                        while ((!int.TryParse(Console.ReadLine(), out UserAnswerId)) || (UserAnswerId < 1 || UserAnswerId > 2));

                        Question.UserAnswer.AnswerId = UserAnswerId;
                        Question.UserAnswer.AnswerText = Question.AnswerList[UserAnswerId - 1].AnswerText;
                        Console.WriteLine("-----------------");


                    }


                    Console.WriteLine("-----------------");

                    Console.Clear();


                    totalMarks += Question.Marks;



                }



                for (int i = 0; i < questions.Length; i++)
                {

                    if (questions[i].RightAnswer.AnswerId == questions[i].UserAnswer.AnswerId)
                    {
                        Grade += questions[i].Marks;
                    }

                    Console.WriteLine($"Question({i + 1}): {questions[i].Body} ");
                    Console.WriteLine($"your answer: {questions[i].UserAnswer.AnswerText}");
                    Console.WriteLine($"right answer: {questions[i].RightAnswer.AnswerText}");


                }
                Console.WriteLine($"Your grade is {Grade}/{totalMarks}");
            }
        }
    }