using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Part :Exam
    {
        public Part(int timeOfExam, int numberOfQuestions)
        : base(timeOfExam, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.Clear();
            for (int i = 0; i < Questions?.Length; i++)
            {
                Console.WriteLine(Questions[i]);
                if (userAnswer is not null)
                {
                    userAnswer[i] = HelperClassForValidations.PartUserAnswerValidation();
                }
                if (Questions[i]?.CorrectAnswer?.AnswerId == Questions?[i]?.AnswerList?[userAnswer[i] - 1]?.AnswerId && Questions is not null)
                {
                    Grade += Questions[i].Mark;
                }
                TotalGrade += Questions[i].Mark;
            }
            Console.WriteLine("You Finsh The Exam Good Luck !");
            Console.Clear();

            Console.WriteLine("Right Answers:\n");
            for(int i = 0; i < Questions?.Length; i++)
            {
                Console.WriteLine($"Question{i+1}\nCorrect Answer: {Questions?[i]?.CorrectAnswer}\n");
            }
        }

    }
}
