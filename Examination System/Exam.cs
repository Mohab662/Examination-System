namespace Examination_System
{
    internal abstract class Exam
    {
        public decimal TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question?[]? Questions { get; set; }

        public int[]? userAnswer { get; set; }

        public decimal Grade=0;
        public decimal TotalGrade = 0;
        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
            userAnswer = new int[numberOfQuestions];


        }

        public override string ToString()
        {
            return $"Time of Exam: {TimeOfExam} minutes\nNumber of Questions: {NumberOfQuestions}";
        }

        public abstract void ShowExam();
    }
}
