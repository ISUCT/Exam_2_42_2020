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

        [Fact]
        public void TestMilOtricatelnogoChisla()
        {
         LengthConverter izmerenie = new LengthConverter();
         Assert.Equal(-1.609, izmerenie.TransferMil(-1));
        }

        [Fact]
        public void TestMil0()
        {
         LengthConverter izmerenie = new LengthConverter();
         Assert.Equal(0, izmerenie.TransferMil(0));
        }

         [Fact]
        public void TestKilometrovOtricatelnogoChisla()
        {
         LengthConverter izmerenie = new LengthConverter();
         Assert.Equal(-1, izmerenie.TransferKilometrov(-1.609));
        }

        [Fact]
        public void TestKilometrov0()
        {
         LengthConverter izmerenie = new LengthConverter();
         Assert.Equal(0, izmerenie.TransferKilometrov(0));
        }
    }
}
