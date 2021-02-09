using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TestTransfer
    {
        [Fact]
        public void TestMil()
        {
         LengthConverter izmerenie = new LengthConverter();
         Assert.Equal(1.609, izmerenie.TransferMil(1));
        }

        [Fact]
        public void TestKilometrov()
        {
         LengthConverter izmerenie = new LengthConverter();
         Assert.Equal(1, izmerenie.TransferKilometrov(1.609));
        }
    }
}
