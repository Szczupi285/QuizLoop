using QuizLoop.Domain.Abstractions;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.ValueObjects.Achivement
{
    public record AchivementName : AbstractContent
    {
        protected override ushort MaxLen => 50;
        public AchivementName(AbstractContent original) : base(original) { }

        public static implicit operator AchivementName(string name) => new(name);
    }
}