using QuizLoop.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Exceptions.Shared
{
    public class ContentNullException : QuizLoopException
    {
        public ContentNullException(Type contentType) : base($"{contentType.Name} cannot be null")
        {
        }
    }
}
