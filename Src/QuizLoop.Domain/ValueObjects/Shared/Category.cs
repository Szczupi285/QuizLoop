using QuizLoop.Domain.Abstractions;
using QuizLoop.Domain.Exceptions.Shared;

namespace QuizLoop.Domain.ValueObjects.Shared
{
    public sealed record Category : AbstractContent
    {
        protected override ushort MaxLen => 50;
        public Category(string value) : base(value) { }

        public static implicit operator Category(string category) => new(category);
    }
}