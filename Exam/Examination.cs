using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Examination
  
    {
       public int time;
        public int numberOfQuestions;
        public Question[] questions;

        public Examination(int time, int numberOfQuestions)
        {


            this.time = time;
            this.numberOfQuestions = numberOfQuestions;
        }
           


        

        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();
    }

}
