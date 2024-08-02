namespace Examination_System
{
    internal  class Question
    {
        #region Properties
        public string? HeaderOfTheQuestion { get; set; }
        public string? BodyOfTheQuestion { get; set; }
        public decimal Mark { get; set; }
        public Answers?[] AnswerList { get; set; }
        public Answers? CorrectAnswer { get; set; }
        #endregion
        public Question(string HeaderOfTheQuestion, string BodyOfTheQuestion, decimal Mark)
        {
            this.HeaderOfTheQuestion = HeaderOfTheQuestion;
            this.BodyOfTheQuestion = BodyOfTheQuestion;
            this.Mark = Mark;
            AnswerList = new Answers[3];

        }
        public override string ToString()
        {
            string x = "";
            foreach (var item in AnswerList)
            {
                x += "\n" + item;
            }
            return $"{HeaderOfTheQuestion}  {Mark} Marks\n{BodyOfTheQuestion},{x}";
        }

    }
}
