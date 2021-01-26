using System.IO;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData("Text Text Text\nText Text Text\nText Text Text", "1 - Text Text Text\n2 - Text Text Text\n3 - Text Text Text")]
        [InlineData("Text Text Text\nText Text Text\nText Text Text\nText Text Text\nText Text Text",
        "1 - Text Text Text\n2 - Text Text Text\n3 - Text Text Text\n4 - Text Text Text\n5 - Text Text Text")]
        [InlineData("Text Text Text\n\nText Text Text", "1 - Text Text Text\n2 - \n3 - Text Text Text")]
        public void TestCorrectReadFile(string text, string result)
        {
            using (var file = new System.IO.StreamWriter("test.txt"))
            {
                file.WriteLine(text);
            }
            var actualResult = Program.ReadTextFromFile();
            Assert.Equal(result.Split('\n'), actualResult);
        }
    }
}
