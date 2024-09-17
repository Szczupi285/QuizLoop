using QuizLoop.Domain.Consts;
using QuizLoop.Domain.Exceptions.Quiz;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class Quiz
    {
        public EntityId Id { get; }
        public Question Question { get; }

        private List<QuizAnswer> _answers;

        public List<QuizAnswer> Answers
        {
            get => _answers;
            set
            {
                if (value is null || value.Count != 4)
                    throw new InvalidNumberOfQuizAnswersException();

                // check if there is exactly one correct QuizAnswer
                if (value.Count(qa => qa.IsCorrect) != 1)
                    throw new InvalidNumberOfCorrectQuizAnswersException();

                _answers = value;
            }
        }

        public DifficultyEnum Difficulty { get; private set; }
        public Category Category { get; private set; }

        public Quiz(EntityId id, Question question, List<QuizAnswer> answers, DifficultyEnum difficulty, Category category)
        {
            if (answers is null || answers.Count != 4)
                throw new InvalidNumberOfQuizAnswersException();
            else if (answers.Count(qa => qa.IsCorrect) != 1)
                throw new InvalidNumberOfCorrectQuizAnswersException();

            Id = id;
            Question = question;
            _answers = answers;
            Difficulty = difficulty;
            Category = category;
        }

        public void SetDifficulty(DifficultyEnum difficulty) => Difficulty = difficulty;

        public void SetCategory(string category) => Category = category;
    }
}