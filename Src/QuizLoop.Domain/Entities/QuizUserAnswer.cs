using QuizLoop.Domain.Interfaces;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class QuizUserAnswer
    {
        public EntityId Id { get; }
        public EntityId QuizId { get; }
        public EntityId UserID { get; }
        public bool DidAnsweredCorrectly { get; }
        public DateTime DateOfAnswer { get; }

        public QuizUserAnswer(EntityId id, EntityId quizId, EntityId userID, bool didAnsweredCorrectly, IDateTimeProvider dateTimeProvider)
        {
            Id = id;
            QuizId = quizId;
            UserID = userID;
            DidAnsweredCorrectly = didAnsweredCorrectly;
            DateOfAnswer = dateTimeProvider.UtcNow();
        }
    }
}