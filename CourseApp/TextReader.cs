using System;
using System.IO;

namespace CourseApp
{
    public class TextReader
    {
        private static string path = Environment.CurrentDirectory;

        public static string ReadLog()
        {
            string text = "1 ";
            int a = 1;

            using (StreamReader fs = new StreamReader($"{path}\\note.txt"))
            {
                while (true)
                {
                    a++;
                    string temp = fs.ReadLine();

                    if (temp == null)
                    {
                        break;
                    }

                    temp += $"\n{a} ";
                    text += temp;
                }
            }

            // Выводим на экран.
            return text;
        }
    }
}