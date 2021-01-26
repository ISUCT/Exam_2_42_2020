using System;
using Xunit;

namespace CourseApp.Tests
{
    public class TextReaderTests
    {
        [Fact]
        public void Test1()
        {
            string exp = "1 Создайте метод, открывающий текстовый файл\n2 и выводящий на экран текст из файла,\n3 добавив к нему номер строки.\n4 ";
            string path = @"C:\Users\nik-c\OneDrive\Рабочий стол\123\Exam_2_42_2020\CourseApp.Tests";
            Assert.Equal(exp, TextReader.ReadLog(path));
        }
    }
}