using QuizLoop.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Exceptions.Quiz
{
    public class InvalidNumberOfQuizAnswersException : QuizLoopException
    {
        public InvalidNumberOfQuizAnswersException() : base("There must be exactly 4 quiz answers")
        {
        }
    }
}
