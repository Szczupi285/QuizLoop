using QuizLoop.Domain.Abstractions;

namespace QuizLoop.Domain.Exceptions.Quiz
{
    public class InvalidNumberOfCorrectQuizAnswersException : QuizLoopException
    {
        public InvalidNumberOfCorrectQuizAnswersException() : base("There must be exactly one correct QuizAnswer")
        {
        }
    }
}