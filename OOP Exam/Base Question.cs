using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Base_Question : ICloneable, IComparable<Base_Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> AnswerList { get; set; } = new List<Answer>();

        public Base_Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void DisplayQuestion();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(Base_Question other)
        {
            return Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        }
    }
}
