using QuizLoop.Domain.Exceptions.Shared;
using QuizLoop.Domain.ValueObjects.FlashCard;
using QuizLoop.Domain.ValueObjects.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLoop.Domain.UnitTests
{
    public class CategoryUnitTests
    {
        [Fact]
        public void Category_Null_ShouldThrowContentNullException()
        {
            Assert.Throws<ContentNullOrEmptyException>(() => new Category(null));
        }

        [Fact]
        public void Category_Empty_ShouldThrowContentNullException()
        {
            Assert.Throws<ContentNullOrEmptyException>(() => new Category(""));
        }

        [Fact]
        public void Category_TooLongContent_ShouldThrowInvalidContentLengthException()
        {
            string a = new string('a', 51);
            Assert.Throws<InvalidContentLengthException>(() => new Category(a));
        }

        [Fact]
        public void Category_ValidContent_ShouldThrowInvalidContentLengthException()
        {
            string a = new string('a', 50);
            new Category(a);
        }
    }
}