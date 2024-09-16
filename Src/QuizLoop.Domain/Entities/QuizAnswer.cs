using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class QuizAnswer
    {
        public EntityId Id { get; set; }
        public QuizAnswer Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}