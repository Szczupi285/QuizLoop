using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Interfaces
{
    public interface IUser
    {
        public EntityId Id { get;}
    }
}
