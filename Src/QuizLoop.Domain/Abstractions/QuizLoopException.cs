namespace QuizLoop.Domain.Abstractions
{
    public abstract class QuizLoopException : Exception
    {
        protected QuizLoopException(string message) : base(message)
        {
        }
    }
}