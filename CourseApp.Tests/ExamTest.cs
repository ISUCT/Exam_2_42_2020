using System;
using Xunit;

namespace CourseApp.Tests
{
    public class ExamTest
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData("Hello", "Johnny", "19", "Hello, Johnny: 19")]
        [InlineData("Greetings", "Oscar", "33", "Greetings, Oscar: 33")]
        public void Welcoming(string a, string b, string c, string exp)
        {
            var actualResult = Exam.Welcoming(a, b, c);
            Assert.Equal(exp, actualResult, 3);
        }
    }
}
