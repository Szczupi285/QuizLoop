using QuizLoop.Domain.Exceptions.Shared;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.UnitTests
{
    public class QuestionUnitTests
    {
        [Fact]
        public void Question_Null_ShouldThrowContentNullException()
        {
            Assert.Throws<ContentNullOrEmptyException>(() => new Question(null));
        }

        [Fact]
        public void Question_Empty_ShouldThrowContentNullException()
        {
            Assert.Throws<ContentNullOrEmptyException>(() => new Question(""));
        }

        [Fact]
        public void Question_TooLongContent_ShouldThrowInvalidContentLengthException()
        {
            string a = new string('a', 251);
            Assert.Throws<InvalidContentLengthException>(() => new Question(a));
        }

        [Fact]
        public void Question_ValidContent_ShouldThrowInvalidContentLengthException()
        {
            string a = new string('a', 250);
            new Question(a);
        }
    }
}