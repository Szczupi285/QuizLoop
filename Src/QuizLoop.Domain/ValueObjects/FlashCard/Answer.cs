using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.FlashCard
{
    public sealed record Answer
    {
        public string Value { get; }
        private const ushort MaxLen = 150;

        public Answer(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ContentNullOrEmptyException(typeof(Answer));
            else if (value.Length > MaxLen)
                throw new InvalidContentLengthException(typeof(Answer), MaxLen, value.Length);

            Value = value;
        }

        public static implicit operator string(Answer answer) => answer.Value;

        public static implicit operator Answer(string answer) => new(answer);
    }
}