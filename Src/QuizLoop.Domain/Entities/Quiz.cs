using QuizLoop.Domain.Consts;
using QuizLoop.Domain.Exceptions.Quiz;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class Quiz
    {
        public EntityId Id { get; }
        public Question Question { get; }

        // user can rate quiz positivly or negativly
        public Dictionary<EntityId, bool> UserRating { get; set; }

        public double RatingPercentage
        {
            get
            {
                int positiveRating = 0;
                int negativeRating = 0;
                foreach (var item in UserRating)
                {
                    if (item.Value)
                        positiveRating++;
                    else
                        negativeRating++;
                }
                return positiveRating / (double)negativeRating;
            }
        }

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

        public Quiz(EntityId id, Question question, List<QuizAnswer> answers, DifficultyEnum difficulty, Category category, Dictionary<EntityId, bool> userRating)
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
            UserRating = userRating;
        }

        public void SetDifficulty(DifficultyEnum difficulty) => Difficulty = difficulty;

        public void SetCategory(string category) => Category = category;

        public void RatePositivly(EntityId userId)
        {
            if (!UserRating.TryAdd(userId, true))
                UserRating[userId] = true;
        }

        public void RateNegativly(EntityId userId)
        {
            if (!UserRating.TryAdd(userId, false))
                UserRating[userId] = false;
        }

        public bool AnswerQuestion(User user, EntityId QuizAnswerId)
        {
            if (Answers.First(a => a.Id == QuizAnswerId).IsCorrect)
            {
                user.AnswerQuestionCorrectly(Difficulty);
                return true;
            }
            return false;
        }
    }
}