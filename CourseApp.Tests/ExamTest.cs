using System;
using Xunit;

namespace CourseApp.Tests
{
    public class ExamTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestCount1()
        {
            string[] ingredients = { "Хлеб", "Масло", "Колбаса", "Сыр" };
            (int x, string y)[] expectedResult = {(1, "Хлеб"), (2, "Масло"), (3, "Колбаса"), (4, "Сыр")};
            (int x, string y)[] actualResult = Exam.NumberingOfIngredients(ingredients);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TestCount2()
        {
            string[] ingredients = { "Рог единорога", "Волшебная пыльца", "Мантия неведимка" };
            (int x, string y)[] expectedResult = {(1, "Рог единорога"), (2, "Волшебная пыльца"), (3, "Мантия неведимка")};
            (int x, string y)[] actualResult = Exam.NumberingOfIngredients(ingredients);
            Assert.Equal(expectedResult, actualResult);
        }
        
        [Fact]
        public void TestCount3()
        {
            string[] ingredients = { "Шоколад" };
            (int x, string y)[] expectedResult = {(1, "Шоколад")};
            (int x, string y)[] actualResult = Exam.NumberingOfIngredients(ingredients);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}