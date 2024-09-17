using QuizLoop.Domain.Abstractions;

namespace QuizLoop.Domain.Exceptions.Shared
{
    public class ContentNullOrEmptyException : QuizLoopException
    {
        public ContentNullOrEmptyException(Type contentType) : base($"{contentType.Name} cannot be null or empty")
        {
        }
    }
}