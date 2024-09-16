using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Interfaces
{
    public interface IUser
    {
        public EntityId Id { get; }
    }
}