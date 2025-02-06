using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Exam_Result
    {
        public int Grade { get; set; }
        public string Feedback { get; set; }

        public Exam_Result(int grade, string feedback)
        {
            Grade = grade;
            Feedback = feedback;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"Grade: {Grade}, Feedback: {Feedback}");
        }
    }
}
