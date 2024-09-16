namespace QuizLoop.Domain.Entities
{
    public class QuizAnswer
    {
        public uint Id { get; set; }
        public QuizAnswer Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}