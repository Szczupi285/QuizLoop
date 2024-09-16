using QuizLoop.Domain.Interfaces;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class QuizUserAnswer
    {
        public EntityId Id { get; }
        public EntityId QuizId { get; }
        public EntityId UserID { get; }
        public bool DidAnswerCorrectly { get; }
        public DateTime DateOfAnswer { get; }

        public QuizUserAnswer(EntityId id, EntityId quizId, EntityId userID, bool didAnswerCorrectly, IDateTimeProvider dateTimeProvider)
        {
            Id = id;
            QuizId = quizId;
            UserID = userID;
            DidAnswerCorrectly = didAnswerCorrectly;
            DateOfAnswer = dateTimeProvider.UtcNow();
        }
    }
}