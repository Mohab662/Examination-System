using System.Reflection.PortableExecutable;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int subjectId = HelperClassForValidations.SubjectIdValidation(); 

            string? subjectName = HelperClassForValidations.SubjectNameValidation();

            Subject subject = new Subject(subjectId, subjectName);

            subject.CreateTheExam();

            subject.exam?.ShowExam();

           

            


        }
    }
}
