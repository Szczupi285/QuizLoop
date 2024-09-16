using QuizLoop.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
