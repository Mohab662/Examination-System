namespace Examination_System
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string HeaderOfTheQuestion, string BodyOfTheQuestion, decimal Mark) : base(HeaderOfTheQuestion, BodyOfTheQuestion, Mark)
        {
        }
        public void Display()
        {
            Console.WriteLine($"{HeaderOfTheQuestion} , {BodyOfTheQuestion} , {Mark}");
        }
    }
}
