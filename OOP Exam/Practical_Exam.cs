using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Practical_Exam : Base_Exam
    {
        public List<Base_Question> Questions { get; set; } = new List<Base_Question>();

        public Practical_Exam(int time, int numQuestions, Subject subject): base(time, numQuestions, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Practical Exam for {Subject.SubjectName}:");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
            }
            ShowAnswer();
        }

        public void ShowAnswer()
        {
            Console.WriteLine("Showing correct answers after exam:");
            foreach (var question in Questions)
            {
                Console.WriteLine($"Question: {question.Body}");
                Console.WriteLine($"Correct Answer: {question.AnswerList[0]}");
            }
        }
    }
}
