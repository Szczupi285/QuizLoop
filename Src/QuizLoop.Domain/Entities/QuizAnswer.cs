using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class QuizAnswer
    {
        public QuizAnswer(EntityId id, Answer content, bool isCorrect)
        {
            Id = id;
            Content = content;
            IsCorrect = isCorrect;
        }

        public EntityId Id { get; set; }
        public Answer Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}