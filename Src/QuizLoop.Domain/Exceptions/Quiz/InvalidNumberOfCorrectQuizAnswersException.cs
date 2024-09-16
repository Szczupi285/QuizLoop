using QuizLoop.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Exceptions.Quiz
{
    public class InvalidNumberOfCorrectQuizAnswersException : QuizLoopException
    {
        public InvalidNumberOfCorrectQuizAnswersException() : base("There must be exactly one correct QuizAnswer")
        {
        }
    }
}
