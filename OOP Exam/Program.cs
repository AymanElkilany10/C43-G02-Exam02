namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of exam    1:Final       any other number:Practical");
            int n = Convert.ToInt32(Console.ReadLine());
            string examType;
            if(n == 1) examType = "Final";
            else examType = "Practical";

            Console.Write("Enter the time of the exam:");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of questions:");
            int numQuestions = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of the subject:");
            string subName = Console.ReadLine();

            Subject subject = new Subject(1, subName);
            Base_Exam exam = Exam_Factory.CreateExam(examType, time, numQuestions, subject);
            Final_Exam finalExam = null;
            Practical_Exam practicalExam = null;

            for(int i = 0; i < numQuestions; i++){
                Console.WriteLine($"Enter the header for question {i + 1}:");
                string header = Console.ReadLine();

                Console.WriteLine($"Enter the body for question {i + 1}:");
                string body = Console.ReadLine();

                Console.WriteLine($"Enter the mark for question {i + 1}:");
                int mark = int.Parse(Console.ReadLine());

                string questionType;
                if(examType.ToLower() == "practical"){
                    questionType = "mcq";
                    Console.WriteLine("Practical Exam only supports MCQ questions");
                }
                else{
                    Console.WriteLine("Enter the type of question 1:TrueFalse      2:MCQ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if(x == 1) questionType = "TrueFalse";
                    else questionType = "MCQ";
                }

                Base_Question question;
                if(questionType.ToLower() == "truefalse"){
                    question = new T_F_Question(header, body, mark);
                    question.AnswerList.Add(new Answer(1, "True"));
                    question.AnswerList.Add(new Answer(2, "False"));
                }
                else if(questionType.ToLower() == "mcq"){
                    question = new MCQ_Question(header, body, mark);
                    Console.WriteLine("Enter the number of choices:");
                    int numChoices = int.Parse(Console.ReadLine());

                    for(int j = 0; j < numChoices; j++){
                        Console.WriteLine($"Enter choice {j + 1}:");
                        string choice = Console.ReadLine();
                        question.AnswerList.Add(new Answer(j + 1, choice));
                    }
                }
                else throw new ArgumentException("Invalid question type.");
                

                if(exam is Final_Exam){
                    finalExam = (Final_Exam)exam;
                    finalExam.Questions.Add(question);
                }
                else if(exam is Practical_Exam){
                    practicalExam = (Practical_Exam)exam;
                    practicalExam.Questions.Add(question);
                }
            }

            exam.ShowExam();
            int totalScore = 0;
            int userScore = 0;

            if(exam is Final_Exam){
                foreach(var question in finalExam.Questions){
                    Console.WriteLine(question.Body);
                    for(int i = 0; i < question.AnswerList.Count; i++){
                        Console.WriteLine($"{i + 1}. {question.AnswerList[i].AnswerText}");
                    }

                    Console.WriteLine("Enter your answer (number):");
                    int userAnswer = int.Parse(Console.ReadLine());

                    if(userAnswer == 1) userScore += question.Mark;
                    totalScore += question.Mark;
                }
            }
            else if(exam is Practical_Exam){
                foreach(var question in practicalExam.Questions){
                    Console.WriteLine(question.Body);
                    for(int i = 0; i < question.AnswerList.Count; i++){
                        Console.WriteLine($"{i + 1}. {question.AnswerList[i].AnswerText}");
                    }

                    Console.WriteLine("Enter your answer (number):");
                    int userAnswer = int.Parse(Console.ReadLine());

                    if (userAnswer == 1) userScore += question.Mark;
                    

                    totalScore += question.Mark;
                }

                practicalExam.ShowAnswer();
            }

            Console.WriteLine($"Your score: {userScore} out of {totalScore}");
        }
    }
}
