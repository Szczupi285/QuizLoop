using QuizLoop.Domain.Consts;
using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class FlashCard
    {
        public EntityId Id { get; }
        public Question Question { get; }
        public Answer Answer { get; }
        public DifficultyEnum Difficulty { get; private set; }
        public Category Category { get; private set; }

        public FlashCard(EntityId id, Question question, Answer answer, DifficultyEnum difficulty, Category category)
        {
            Id = id;
            Question = question;
            Answer = answer;
            Difficulty = difficulty;
            Category = category;
        }

        public void SetDifficulty(DifficultyEnum difficulty) => Difficulty = difficulty;

        public void SetCategory(string category) => Category = category;
    }
}