using QuizLoop.Domain.Exceptions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.ValueObjects.FlashCard
{
    public sealed record FlashCardAnswer
    {
        public string Value { get; }
        private const ushort MaxLen = 150;

        public FlashCardAnswer(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ContentNullException(typeof(FlashCardAnswer));
            else if (value.Length > MaxLen)
                throw new InvalidContentLengthException(typeof(FlashCardAnswer), MaxLen, value.Length);

            Value = value;
        }

        public static implicit operator string(FlashCardAnswer Answer) => Answer.Value;

        public static implicit operator FlashCardAnswer(string Answer) => new(Answer);
    }
}
}
