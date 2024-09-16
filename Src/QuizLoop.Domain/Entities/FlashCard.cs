using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;
using System.ComponentModel;

namespace QuizLoop.Domain.Entities
{
    public class FlashCard
    {
        EntityId Id { get; }
        FlashCardQuestion Question { get; }
        // to do
        //Answer answer { get; }
        //public Difficulty Difficulty { get; private set; }
        //public Category Category { get; private set; }


    }
}