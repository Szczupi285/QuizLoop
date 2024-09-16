using QuizLoop.Domain.Consts;
using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;
using System.ComponentModel;

namespace QuizLoop.Domain.Entities
{
    public class FlashCard
    {
        EntityId Id { get; }
        FlashCardQuestion Question { get; }
        FlashCardAnswer Answer { get; }
        DifficultyEnum Difficulty { get; private set; }
        // to do
        //public Category Category { get; private set; }


    }
}