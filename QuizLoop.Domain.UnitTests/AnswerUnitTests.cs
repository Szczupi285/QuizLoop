using QuizLoop.Domain.Exceptions.Shared;
using QuizLoop.Domain.ValueObjects.FlashCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.UnitTests
{
    public class AnswerUnitTests
    {
        [Fact]
        public void QuizAnswer_Null_ShouldThrowContentNullException()
        {
            Assert.Throws<ContentNullOrEmptyException>(() => new Answer(null));
        }

        [Fact]
        public void QuizAnswer_Empty_ShouldThrowContentNullException()
        {
            Assert.Throws<ContentNullOrEmptyException>(() => new Answer(""));
        }

        [Fact]
        public void QuizAnswer_TooLongContent_ShouldThrowInvalidContentLengthException()
        {
            string a = new string('a', 151);
            Assert.Throws<InvalidContentLengthException>(() => new Answer(a));
        }

        [Fact]
        public void QuizAnswer_ValidContent_ShouldThrowInvalidContentLengthException()
        {
            string a = new string('a', 150);
            new Answer(a);
        }
    }
}