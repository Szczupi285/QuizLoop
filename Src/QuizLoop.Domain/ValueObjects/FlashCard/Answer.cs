using QuizLoop.Domain.Abstractions;
using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.FlashCard
{
    public sealed record Answer : AbstractContent
    {
        protected override ushort MaxLen => 150;
        public Answer(string value) : base(value) { }
        public static implicit operator Answer(string answer) => new(answer);
    }
}