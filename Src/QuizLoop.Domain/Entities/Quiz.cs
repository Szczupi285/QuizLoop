using QuizLoop.Domain.Consts;
using QuizLoop.Domain.Exceptions.Quiz;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class Quiz
    {
        public EntityId Id { get; }
        public Question Question { get; }

        public List<QuizAnswer> Answers
        {
            get => Answers;
            set
            {
                if (value is null || value.Count != 4)
                    throw new InvalidNumberOfQuizAnswersException();
                // check if there is exactly one correct QuizAnswer
                else if (value.Count(qa => qa.IsCorrect) != 1)
                    throw new InvalidNumberOfCorrectQuizAnswersException();
            }
        }
        public DifficultyEnum Difficulty { get; private set; }
        public Category Category { get; private set; }



        public void SetDifficulty(DifficultyEnum difficulty) => Difficulty = difficulty;
        public void SetCategory(string category) => Category = category;
    }
}