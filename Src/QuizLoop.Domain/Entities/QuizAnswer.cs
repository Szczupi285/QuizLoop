using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.Entities
{
    public class QuizAnswer
    {
        public uint Id { get; set; }
        public QuizAnswer Content { get; set; }
        public bool IsCorrect { get; set; }


    }
}
