using System;
using Xunit;

namespace CourseApp.Tests
    {
    public class DemoTest
    {
    [Theory]
    [InlineData(1, 1, "Ничья")]
    [InlineData(1, 2, "Победил первый игрок")]
    [InlineData(1, 3, "Победил второй игрок")]
    [InlineData(2, 1, "Победил второй игрок")]
    [InlineData(2, 2, "Ничья")]
    [InlineData(2, 3, "Победил первый игрок")]
    [InlineData(3, 1, "Победил первый игрок")]
    [InlineData(3, 2, "Победил второй игрок")]
    [InlineData(3, 3, "Ничья")]
    [InlineData(5, 5, "Ошибка")]
    public void TestGame(int a, int b, string exp)
    {
        Game game = new Game();
        var result = Game.Play(a, b);
        Assert.Equal(result, exp);
    }
    }
}
