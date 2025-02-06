using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class MCQ_Question : Base_Question
    {
        public MCQ_Question(string header, string body, int mark)
            : base(header, body, mark) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header} (MCQ): {Body}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
        }
    }
}
