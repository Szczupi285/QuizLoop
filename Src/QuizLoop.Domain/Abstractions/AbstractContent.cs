using QuizLoop.Domain.Exceptions.Shared;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Abstractions
{
    public abstract record AbstractContent
    {
        public string Value { get; }
        protected abstract ushort MaxLen { get; }

        protected AbstractContent(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ContentNullOrEmptyException(GetType());
            else if (value.Length > MaxLen)
                throw new InvalidContentLengthException(GetType(), MaxLen, value.Length);

            Value = value;
        }

        public static implicit operator string(AbstractContent content) => content.Value;
    }
}