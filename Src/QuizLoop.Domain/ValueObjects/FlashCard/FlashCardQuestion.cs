using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.FlashCard
{
    public sealed record FlashCardQuestion
    {
        public string Value { get; }
        private const ushort MaxLen = 250;

        public FlashCardQuestion(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ContentNullException(typeof(FlashCardQuestion));
            else if (value.Length > MaxLen)
                throw new InvalidContentLengthException(typeof(FlashCardQuestion), MaxLen, value.Length);

            Value = value;
        }

        public static implicit operator string(FlashCardQuestion question) => question.Value;

        public static implicit operator FlashCardQuestion(string question) => new(question);
    }
}