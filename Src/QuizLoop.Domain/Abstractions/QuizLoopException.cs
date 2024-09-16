using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Abstractions
{
    public abstract class QuizLoopException : Exception
    {
        protected QuizLoopException(string message) : base(message) { }
    }
}
