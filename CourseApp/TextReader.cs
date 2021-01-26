using System;
using System.IO;

namespace CourseApp
{
    public class TextReader
    {
        public static string ReadLog(string path)
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