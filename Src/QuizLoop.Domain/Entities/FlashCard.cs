using QuizLoop.Domain.Consts;
using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;
using System.ComponentModel;

namespace QuizLoop.Domain.Entities
{
    public class FlashCard
    {
        public EntityId Id { get; }
        public FlashCardQuestion Question { get; }
        public FlashCardAnswer Answer { get; }
        public DifficultyEnum Difficulty { get; private set; }
        public Category Category { get; private set; }


    }
}