using QuizLoop.Domain.Entities;
using QuizLoop.Domain.Exceptions.Quiz;
using QuizLoop.Domain.Exceptions.Shared;
using QuizLoop.Domain.ValueObjects.FlashCard;

namespace QuizLoop.Domain.UnitTests
{
    public class QuizUnitTests
    {
        private QuizAnswer QuizAnswer1 { get; set; } = new(Guid.NewGuid(), "content", true);
        private QuizAnswer QuizAnswer2 { get; set; } = new(Guid.NewGuid(), "content", false);
        private QuizAnswer QuizAnswer3 { get; set; } = new(Guid.NewGuid(), "content", false);
        private QuizAnswer QuizAnswer4 { get; set; } = new(Guid.NewGuid(), "content", false);

        private Quiz Quiz { get; set; }

        public QuizUnitTests()
        {
            Quiz = new(
                Guid.NewGuid(),
                "Question",
                new List<QuizAnswer>() { QuizAnswer1, QuizAnswer2, QuizAnswer3, QuizAnswer4 },
                Consts.DifficultyEnum.Easy,
                "Math");
        }

        [Fact]
        public void Quiz_FiveAnswers_ShouldThrowInvalidNumberOfQuizAnswersException()
        {
            QuizAnswer quizAnswer5 = new(Guid.NewGuid(), "content", true);

            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>() { QuizAnswer1, QuizAnswer2, QuizAnswer3, QuizAnswer4, quizAnswer5 },
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_ThreeAnswers_ShouldThrowInvalidNumberOfQuizAnswersException()
        {
            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>() { QuizAnswer1, QuizAnswer2, QuizAnswer3 },
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_TwoAnswers_ShouldThrowInvalidNumberOfQuizAnswersException()
        {
            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>() { QuizAnswer1, QuizAnswer2, },
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_OneAnswer_ShouldThrowInvalidNumberOfQuizAnswersException()
        {
            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>() { QuizAnswer1, },
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_NoAnswers_ShouldThrowInvalidNumberOfQuizAnswersException()
        {
            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>(),
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_NullAnswerList_ShouldThrowInvalidNumberOfQuizAnswersException()
        {
            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    null,
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_TwoCorrectAnswers_ShouldThrowInvalidNumberOfInvalidNumberOfCorrectQuizAnswersException()
        {
            QuizAnswer quizAnswer5 = new(Guid.NewGuid(), "content", true);

            Assert.Throws<InvalidNumberOfQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>() { QuizAnswer1, QuizAnswer2, QuizAnswer3, QuizAnswer4, quizAnswer5 },
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_NoCorrectAnswer_ShouldThrowInvalidNumberOfInvalidNumberOfCorrectQuizAnswersException()
        {
            QuizAnswer quizAnswer5 = new(Guid.NewGuid(), "content", false);

            Assert.Throws<InvalidNumberOfCorrectQuizAnswersException>(() =>
                new Quiz(
                    Guid.NewGuid(),
                    "Question",
                    new List<QuizAnswer>() { QuizAnswer2, QuizAnswer3, QuizAnswer4, quizAnswer5 },
                    Consts.DifficultyEnum.Easy,
                    "Math"));
        }

        [Fact]
        public void Quiz_ValidInput_ShouldNotThrowException()
        {
            new Quiz(
                Guid.NewGuid(),
                "Question",
                new List<QuizAnswer>() { QuizAnswer1, QuizAnswer2, QuizAnswer3, QuizAnswer4 },
                Consts.DifficultyEnum.Easy,
                "Math");
        }
    }
}