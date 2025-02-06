using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Base_Exam
    {
        public int Time { get; set; }
        public int NumQuestions { get; set; }
        public Subject Subject { get; set; }

        public Base_Exam(int time, int numQuestions, Subject subject)
        {
            Time = time;
            NumQuestions = numQuestions;
            Subject = subject;
        }

        public abstract void ShowExam();
    }
}
