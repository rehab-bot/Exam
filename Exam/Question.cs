using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public double Marks { get; set; }

        public Answer[] AnswerList { get; set; }

        public Answer RightAnswer { get; set; }

        public Answer UserAnswer { get; set; }

        public Question()
        {

            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        public abstract void AddQuestion();

        public override string ToString()
        {
            return $" Header: {Header}\n Body: {Body}\n Mark: {Marks}";
        }
    }
}

