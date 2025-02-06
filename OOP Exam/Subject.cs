using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Base_Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam(Base_Exam exam)
        {
            Exam = exam;
            Console.WriteLine($"Exam created for {SubjectName}.");
        }
    }
}
