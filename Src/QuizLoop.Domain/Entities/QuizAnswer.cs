using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class QuizAnswer
    {
        public QuizAnswer(EntityId id, QuizAnswer content, bool isCorrect)
        {
            Id = id;
            Content = content;
            IsCorrect = isCorrect;
        }

        public EntityId Id { get; set; }
        public QuizAnswer Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}