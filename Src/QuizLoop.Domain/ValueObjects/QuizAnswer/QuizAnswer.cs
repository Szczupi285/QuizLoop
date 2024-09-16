using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.QuizAnswer
{
    public sealed record QuizAnswer
    {
        public string Value { get; }
        private const ushort MaxLen = 150;

        public QuizAnswer(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ContentNullException(typeof(QuizAnswer));
            else if (value.Length > MaxLen)
                throw new InvalidContentLengthException(typeof(QuizAnswer), MaxLen, value.Length);

            Value = value;
        }

        public static implicit operator string(QuizAnswer answer) => answer.Value;

        public static implicit operator QuizAnswer(string answer) => new(answer);
    }
}