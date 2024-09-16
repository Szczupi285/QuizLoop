using QuizLoop.Domain.Exceptions.Shared;
using QuizLoop.Domain.ValueObjects.FlashCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.ValueObjects.Shared
{
    public sealed record Category
    {
        public string Value { get; }
        private const ushort MaxLen = 50;

        public Category(string value)
        {
            if(string.IsNullOrEmpty(value))
                throw new ContentNullException(typeof(Category));
            else if(value.Length > MaxLen)
                throw new InvalidContentLengthException(typeof(Category), MaxLen, value.Length);

            Value = value;
        }
        public static implicit operator string(Category category) => category.Value;

        public static implicit operator Category(string category) => new(category);
    }
}
