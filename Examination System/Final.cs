using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class Final : Exam 
    {
        public Final(int timeOfExam, int numberOfQuestions)
        : base(timeOfExam, numberOfQuestions) { }

        public override void ShowExam()
        {
            Console.Clear();
            if(Questions is not null  && userAnswer is not null )
            {
                for (int i = 0; i < Questions?.Length; i++)
                {
                    Console.WriteLine(Questions[i]);
                    userAnswer[i] = HelperClassForValidations.FinalUserAnswerValidation();
                    if (Questions?[i]?.CorrectAnswer?.AnswerId == Questions?[i]?.AnswerList[userAnswer[i] - 1]?.AnswerId)
                    {
                        Grade += Questions[i].Mark;
                    }
                    TotalGrade += Questions[i].Mark;

                }
                Console.WriteLine("You Finsh The Exam Good Luck !");
                Console.Clear();


                for (int i = 0; i < Questions?.Length; i++)
                {
                    Console.WriteLine(Questions[i]);
                    Console.WriteLine($"Your Answer Id Is {userAnswer[i]}");
                    Console.WriteLine($"The Correct Answer Id Is {Questions?[i]?.CorrectAnswer}");
                }
                Console.WriteLine($"Your Grade Is {Grade}/{TotalGrade}");
                Grade = 0;
                TotalGrade = 0;
            }
            
        }
    }
}
