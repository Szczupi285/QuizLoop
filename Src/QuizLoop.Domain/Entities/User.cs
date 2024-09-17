using QuizLoop.Domain.Consts;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Entities
{
    public class User
    {
        public EntityId UserId { get; }
        public string Username { get; }
        public int Points { get; private set; }
        public List<Achivement> Achivements { get; private set; }

        public User(EntityId userId, string username, int points)
        {
            UserId = userId;
            Username = username;
            Points = points;
        }

        public void AnswerQuestionCorrectly(DifficultyEnum difficulty)
        {
            switch (difficulty)
            {
                case DifficultyEnum.Easy:
                    Points += 100;
                    break;

                case DifficultyEnum.Medium:
                    Points += 300;
                    break;

                case DifficultyEnum.Hard:
                    Points += 700;
                    break;
            }
        }
    }
}