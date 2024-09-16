using QuizLoop.Domain.Abstractions;

namespace QuizLoop.Domain.Exceptions.Shared
{
    public class InvalidContentLengthException : QuizLoopException
    {
        public InvalidContentLengthException(Type contentType, int maxLength, int actualLength)
        : base($"{contentType.Name} is too long. Maximum length is {maxLength}, but was {actualLength}.")
        {
        }
    }
}