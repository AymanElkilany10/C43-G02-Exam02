using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Exam_Factory
    {
        public static Base_Exam CreateExam(string examType, int time, int numQuestions, Subject subject)
        {
            if (examType == "Final")
                return new Final_Exam(time, numQuestions, subject);
            else if (examType == "Practical")
                return new Practical_Exam(time, numQuestions, subject);
            else
                throw new ArgumentException("Invalid exam type.");
        }
    }
}
