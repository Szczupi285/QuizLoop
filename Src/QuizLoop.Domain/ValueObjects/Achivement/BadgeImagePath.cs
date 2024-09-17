using QuizLoop.Domain.Abstractions;
using QuizLoop.Domain.Exceptions.Achivements;
using QuizLoop.Domain.Exceptions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuizLoop.Domain.ValueObjects.Achivement
{
    public sealed record BadgeImagePath : AbstractContent
    {
        protected override ushort MaxLen => 50;
        public BadgeImagePath(AbstractContent original) : base(original)
        {
            Regex regex = new Regex(@"^(?<ParentPath>(?:[a-zA-Z]\:|\\\\[\w\s\.]+\\[\w\s\.$]+)\\(?:[\w\s\.]+\\)*)(?<BaseName>[\w\s\.]*?)$");
            if (!regex.IsMatch(Value))
                throw new InvalidBadgeImagePathException(Value);
        }
    }
}