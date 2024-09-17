using QuizLoop.Domain.Abstractions;
using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.Shared
{
    public sealed record Question : AbstractContent
    {
        protected override ushort MaxLen => 250;
        public Question(string value) : base(value) { }

        public static implicit operator Question(string question) => new(question);
    }
}