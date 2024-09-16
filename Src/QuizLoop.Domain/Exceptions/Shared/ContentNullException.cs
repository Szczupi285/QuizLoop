using QuizLoop.Domain.Abstractions;

namespace QuizLoop.Domain.Exceptions.Shared
{
    public class ContentNullException : QuizLoopException
    {
        public ContentNullException(Type contentType) : base($"{contentType.Name} cannot be null")
        {
        }
    }
}