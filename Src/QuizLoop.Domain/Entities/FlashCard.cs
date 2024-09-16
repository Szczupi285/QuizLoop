﻿using QuizLoop.Domain.Consts;
using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;

namespace QuizLoop.Domain.Entities
{
    public class FlashCard
    {
        public EntityId Id { get; }
        public Question Question { get; }
        public FlashCardAnswer Answer { get; }
        public DifficultyEnum Difficulty { get; private set; }
        public Category Category { get; private set; }
    }
}