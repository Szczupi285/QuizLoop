using QuizLoop.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Exceptions.Achivements
{
    public class InvalidBadgeImagePathException : QuizLoopException
    {
        public InvalidBadgeImagePathException(string value) : base($"File path: {value} is not a valid windows server file path")
        {
        }
    }
}