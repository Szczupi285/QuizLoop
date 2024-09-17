using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.Shared
{
    public sealed record Question
    {
        public string Value { get; }
        private const ushort MaxLen = 250;

        public Question(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ContentNullOrEmptyException(typeof(Question));
            else if (value.Length > MaxLen)
                throw new InvalidContentLengthException(typeof(Question), MaxLen, value.Length);

            Value = value;
        }

        public static implicit operator string(Question question) => question.Value;

        public static implicit operator Question(string question) => new(question);
    }
}