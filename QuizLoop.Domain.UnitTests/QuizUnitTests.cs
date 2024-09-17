using QuizLoop.Domain.Entities;
using QuizLoop.Domain.Exceptions.Quiz;

namespace QuizLoop.Domain.UnitTests
{
    public class QuizUnitTests
    {
        private QuizAnswer QuizAnswer1 { get; set; }
        private QuizAnswer QuizAnswer2 { get; set; }
        private QuizAnswer QuizAnswer3 { get; set; }
        private QuizAnswer QuizAnswer4 { get; set; }

        private Quiz Quiz { get; set; }

        public QuizUnitTests()
        {
            QuizAnswer QuizAnswer1 = new(Guid.NewGuid(), "content", true);
            QuizAnswer QuizAnswer2 = new(Guid.NewGuid(), "content", false);
            QuizAnswer QuizAnswer3 = new(Guid.NewGuid(), "content", false);
            QuizAnswer QuizAnswer4 = new(Guid.NewGuid(), "content", false);
            Quiz Quiz = new(
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
    }
}