using QuizLoop.Domain.Abstractions;

namespace QuizLoop.Domain.Exceptions.Quiz
{
    public class InvalidNumberOfQuizAnswersException : QuizLoopException
    {
        public InvalidNumberOfQuizAnswersException() : base("There must be exactly 4 quiz answers")
        {
        }
    }
}