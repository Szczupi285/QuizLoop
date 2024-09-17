using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Entities
{
    public class User
    {
        public EntityId UserId { get; }
        public string Username { get; }
        public int Points { get; private set; }
        // public List<Achivements> {get; private set; }
    }
}