using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class T_F_Question : Base_Question
    {
        public T_F_Question(string header, string body, int mark)
            : base(header, body, mark) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header} (True/False): {Body}");
        }
    }
}
