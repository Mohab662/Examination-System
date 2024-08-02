using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public static class HelperClassForValidations
    {
        #region Validation For Subject Class Attributes
        public static int FinalUserAnswerValidation()
        {
            int UAnswer = 0;
            bool x = false;

            do
            {
                Console.WriteLine();
                Console.Write("Enter Your Answer : ");
                x = int.TryParse(Console.ReadLine(), out UAnswer);
            }
            while (x == false);


            return UAnswer;
        }

        public static int ExamTypeValidation()
        {
            int ExamType = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter Type Of Exam (1 for Final, 2 for Practical)");
                x = int.TryParse(Console.ReadLine(), out ExamType);
            }
            while (x == false || (ExamType != 2 && ExamType != 1));


            return ExamType;
        }

        public static int TimeOfExamValidation()
        {
            int timeOfExam = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                Console.Write("Enter Time of Exam (30 minute to 180):");
                x = int.TryParse(Console.ReadLine(), out timeOfExam);
            }
            while (x == false || !(timeOfExam >= 30 && timeOfExam < 180));


            return timeOfExam;
        }

        public static int NumberOfQuestionsValidation()
        {
            int numberOfQuestions = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                Console.Write("Enter Number of Questions:");
                x = int.TryParse(Console.ReadLine(), out numberOfQuestions);
            }
            while (x == false || !(numberOfQuestions > 0 && numberOfQuestions < 200));


            return numberOfQuestions;
        }

        public static int QuestionTypeValidation()
        {
            int questionType = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"Enter Question Type (1 for True/False, 2 for MCQ):");
                x = int.TryParse(Console.ReadLine(), out questionType);
            }
            while (x == false || (questionType != 2 && questionType != 1));


            return questionType;
        }

        public static string? ExamBodyValidation()
        {
            string? body = "";

            do
            {
                Console.WriteLine("Enter Question Body:");
                body = Console.ReadLine();
            }
            while (body == "");

            return body;
        }

        public static int MarkValidation()
        {
            int mark = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                Console.Write("Enter Question Mark : ");
                x = int.TryParse(Console.ReadLine(), out mark);
            }
            while (x == false || !(mark > 0 && mark < 100));

            return mark;
        }

        public static int TFCorrectAnswerIdValidation()
        {
            int correctAnswerId = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter The Right Answer Id (1 for True , 2 for False)");
                x = int.TryParse(Console.ReadLine(), out correctAnswerId);
            }
            while (x == false || (correctAnswerId != 2 && correctAnswerId != 1));

            return correctAnswerId;
        }

        public static string? AnswerTextValidation()
        {
            string? answerText = "";

            do
            {
                answerText = Console.ReadLine();
            }
            while (answerText == "");

            return answerText;
        }

        public static int MCQCorrectAnswerIdValidation()
        {
            int mcqCorrectAnswerId = 0;
            bool x = false;
            do
            {
                Console.WriteLine();
                x = int.TryParse(Console.ReadLine(), out mcqCorrectAnswerId);
            }
            while (x == false || (mcqCorrectAnswerId != 2 && mcqCorrectAnswerId != 1 && mcqCorrectAnswerId != 3));

            return mcqCorrectAnswerId;
        }

        public static int PartUserAnswerValidation()
        {
            int UAnswer = 0;
            bool x = false;

            do
            {
                Console.WriteLine();
                Console.Write("Enter Your Answer : ");
                x = int.TryParse(Console.ReadLine(), out UAnswer);
            }
            while (x == false || (UAnswer != 2 && UAnswer != 1));


            return UAnswer;
        }

        #endregion

        public static int SubjectIdValidation()
        {
            int subjectId = 0;
            bool x = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter Subject ID:");
                x = int.TryParse(Console.ReadLine(), out subjectId);
            }
            while (x == false || !(subjectId >=0 ));


            return subjectId;
        }

        public static string? SubjectNameValidation()
        {
            string? subjectName = "";

            do
            {
                Console.WriteLine("Enter Subject Name:");
                subjectName = Console.ReadLine();
            }
            while (subjectName == "");

            return subjectName;
        }

    }
}
