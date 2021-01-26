using System;
using Xunit;

namespace CourseApp.Tests
{
    public class HumanTest
    {
        [Theory]
        [InlineData(7, "Дошкольник")]
        [InlineData(11, "Школьник")]
        [InlineData(20, "Студент")]
        [InlineData(35, "Взрослый")]
        public void TestStatus( int a, string b)
        {
            string exp = b;
            Assert.Equal(exp, Human.Status(a));
        }
    }
}
