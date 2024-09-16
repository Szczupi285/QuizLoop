using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Interfaces
{
    public interface IDateTimeProvider
    {
        public DateTime UtcNow();
        public DateTime Now();
    }
}
