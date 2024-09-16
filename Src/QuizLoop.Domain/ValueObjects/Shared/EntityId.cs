using QuizLoop.Domain.Exceptions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.ValueObjects.Shared
{
    public sealed record EntityId
    {
        public Guid Value { get; }

        public EntityId(Guid value)
        {
            if (value == Guid.Empty)
                throw new EmptyEntityIdException();

            Value = value;
        }
        public static implicit operator Guid(EntityId Id) => Id.Value;

        public static implicit operator EntityId(Guid Id) => new(Id);
    }
}
}
