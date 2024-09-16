using QuizLoop.Domain.Interfaces;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Entities
{
    public class QuizUserAnswer
    {
        public uint Id { get; }
        public EntityId QuizId { get; }
        public EntityId UserID { get; }  
        public bool DidAnsweredCorrectly { get; }
        public DateTime DateOfAnswer { get; }

        public QuizUserAnswer(uint id, EntityId quizId, EntityId userID, bool didAnsweredCorrectly, IDateTimeProvider dateTimeProvider)
        {
            Id = id;
            QuizId = quizId;
            UserID = userID;
            DidAnsweredCorrectly = didAnsweredCorrectly;
            DateOfAnswer = dateTimeProvider.UtcNow();
        }
    }
}
