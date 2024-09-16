using QuizLoop.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Exceptions.Shared
{
    public class EmptyEntityIdException : QuizLoopException
    {
        public EmptyEntityIdException() : base($"Entity Id cannot be empty")
        {
        }
    }
}
