using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(5, "Я одолею этих ниндзя!")]
        [InlineData(0, "Куда делись ниндзя")]
        [InlineData(-2, "Куда делись ниндзя")]
        [InlineData(25, "Будет непросто, но я с ними разделаюсь")]
        [InlineData(45, "Их слишком много")]
        [InlineData(55, "Я погиб")]

        public void TestFight(int ninjas, string exp)
        {
            var res = Program.Fight(ninjas);
            Assert.Equal(exp, res);
        }
    }
}
