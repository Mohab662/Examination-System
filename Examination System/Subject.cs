using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam? exam { get; set; }

        public Subject(int SubjectId, string? SubjectName)
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;
        }
        public void CreateTheExam()
        {

            int examType = HelperClassForValidations.ExamTypeValidation();

            int timeOfExam = HelperClassForValidations.TimeOfExamValidation();
            
            int numberOfQuestions = HelperClassForValidations.NumberOfQuestionsValidation();

            if (examType == 1)
            {
                exam = new Final(timeOfExam, numberOfQuestions);
            }
            else
            {
                exam = new Part(timeOfExam, numberOfQuestions);
            }
            Console.Clear();
            Question? question;
            int i = 0;
            int QNum = 1;
            do
            {

                int questionType = 0;
                if (examType == 1)
                {
                    
                    questionType = HelperClassForValidations.QuestionTypeValidation();
                    Console.Clear();
                }
                else
                {
                    questionType = 1;
                }
                question = default;
                if (questionType == 1)
                {
                    Console.WriteLine($"True/False Question\n\nQ{QNum}");


                    string? body = HelperClassForValidations.ExamBodyValidation();

                    int mark = HelperClassForValidations.MarkValidation();
                    if (body is not null)
                    {
                        question = new TrueOrFalseQuestion("True/False Question", body, mark);
                    }
                    if (question is not null)
                    {
                        question.AnswerList = new Answers[]
                    {
                        new Answers(1, "True"),
                        new Answers(2, "False")
                    };

                        int CorrectAnswerId = HelperClassForValidations.TFCorrectAnswerIdValidation();
                        question.CorrectAnswer = question.AnswerList[CorrectAnswerId - 1];
                    }
                    
                }

                else if (questionType == 2)
                {
                    Console.WriteLine($"MCQ Question\n\nQ{QNum}");

                    string? body = HelperClassForValidations.ExamBodyValidation();

                    int mark = HelperClassForValidations.MarkValidation();
                    if (body is not null)
                    {
                        question = new McqQuestion("MCQ Question", body, mark);
                    }
                    if (question is not null)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Enter Choice {j + 1} Text:");
                            string? answerText = HelperClassForValidations.AnswerTextValidation();
                            question.AnswerList[j] = new Answers(j + 1, answerText);
                        }
                        Console.WriteLine("Enter The Right Answer Id");
                        int CorrectAnswerId = HelperClassForValidations.MCQCorrectAnswerIdValidation();
                        question.CorrectAnswer = question.AnswerList[CorrectAnswerId - 1];
                    }

                    


                }
                else
                    Console.WriteLine();
                if (exam is not null && exam.Questions is not null)
                {
                    exam.Questions[i] = question;
                }
                

                i++;
                QNum++;
            }
            while (i < numberOfQuestions);
        }

        public override string ToString()
        {
            return $"Subject ID: {SubjectId}\nSubject Name: {SubjectName}\nExam:\n{exam}";
        }
    }
}
