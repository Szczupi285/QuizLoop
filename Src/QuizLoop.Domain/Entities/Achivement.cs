using QuizLoop.Domain.ValueObjects.Achivement;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Entities
{
    public class Achivement
    {
        public EntityId Id { get; }

        public AchivementName Name { get; private set; }

        public BadgeImagePath BadgeImagePath { get; private set; }
    }
}