using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class McqQuestion : Question
    {
        public McqQuestion(string HeaderOfTheQuestion, string BodyOfTheQuestion, decimal Mark) : base(HeaderOfTheQuestion, BodyOfTheQuestion, Mark)
        {
        }
    }
}
