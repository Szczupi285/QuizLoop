namespace QuizLoop.Domain.Interfaces
{
    public interface IDateTimeProvider
    {
        public DateTime UtcNow();

        public DateTime Now();
    }
}