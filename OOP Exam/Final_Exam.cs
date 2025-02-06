using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Final_Exam : Base_Exam
    {
        public List<Base_Question> Questions { get; set; } = new List<Base_Question>();

        public Final_Exam(int time, int numQuestions, Subject subject)
            : base(time, numQuestions, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam for {Subject.SubjectName}:");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
            }
            Console.WriteLine("Grade: Calculated based on answers.");
        }
    }
}
