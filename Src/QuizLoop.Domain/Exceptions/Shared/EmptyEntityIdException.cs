using QuizLoop.Domain.Abstractions;

namespace QuizLoop.Domain.Exceptions.Shared
{
    public class EmptyEntityIdException : QuizLoopException
    {
        public EmptyEntityIdException() : base($"Entity Id cannot be empty")
        {
        }
    }
}