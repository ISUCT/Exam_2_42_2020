using System;
using Xunit;
using ConsoleApp;

namespace ConsoleApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double[] array = new double[5] { 1, 5, 7, 2, 8 };
            Search search = new Search();
            Assert.Equal(56, search.Searching(array));
            Assert.Equal(7, search.OldMax);
            Assert.Equal(8, search.NewMax);
        }
        
        [Fact]
        public void Test2()
        {
            double[] array = new double[4] { 10, 2, 3, 8 };
            Search search = new Search();
            Assert.Equal(80, search.Searching(array));
            Assert.Equal(8, search.OldMax);
            Assert.Equal(10, search.NewMax);
        }

        [Fact]
        public void Test3()
        {
            double[] array = new double[6] { 1, 2, 14, 16, 2, 1 };
            Search search = new Search();
            Assert.Equal(224, search.Searching(array));
            Assert.Equal(14, search.OldMax);
            Assert.Equal(16, search.NewMax);    
        }
    }
}