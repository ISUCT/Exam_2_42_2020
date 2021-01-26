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
            int s = 1;

            using (StreamReader fs = new StreamReader($"{path}\\note.txt"))
            {
                while (true)
                {
                    s++;
                    string temp = fs.ReadLine();

                    if (temp == null)
                    {
                        break;
                    }

                    temp += $"\n{s} ";
                    text += temp;
                }
            }

            // Выводим на экран.
            return text;
        }
    }
}