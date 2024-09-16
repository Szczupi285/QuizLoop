using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class FlashCardUserAnswer
    {
        public EntityId Id { get; }
        public EntityId FlashCardId { get; }
        public EntityId UserID { get; }

        // user will be able to check if he remembered flash card
        // based on that information flash cards will be presented more/less often
        public bool DoesRememberCorrectly { get; }

        public DateTime DateOfAnswer { get; }

        public FlashCardUserAnswer(EntityId id, EntityId flashCardId, EntityId userID, bool doesRememberCorrectly, DateTime dateOfAnswer)
        {
            Id = id;
            FlashCardId = flashCardId;
            UserID = userID;
            DoesRememberCorrectly = doesRememberCorrectly;
            DateOfAnswer = dateOfAnswer;
        }
    }
}