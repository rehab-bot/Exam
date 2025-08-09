using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
   internal class TrueFalseQuestion : Question
    {
        public bool correctAnswer;

        public override string Header => "True or False question";

        public TrueFalseQuestion()
        {
            AnswerList = new Answer[2];
            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");

        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);

         

            Console.WriteLine("Please Enter Body Of Question:");
            Body = Console.ReadLine();

          
            int mark;
            do
            {
                Console.WriteLine("Please Enter Marks Of Question:");

            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

             Marks = mark;


            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Id ( 1 For Ture | 2 For False)");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 ||
            RightAnswerId > 2);

            RightAnswer.AnswerId = RightAnswerId;
            RightAnswer.AnswerText = AnswerList[RightAnswerId - 1].AnswerText;

            Console.Clear();
        }
    }


}


