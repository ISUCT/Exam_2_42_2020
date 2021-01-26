using System;

namespace Exam
{
public class Exam
{
  public static void Main()
  {
    Console.WriteLine("Введите приветствие:");
    string welc = Console.ReadLine();
   Console.WriteLine("Введите имя:");
    string name = Console.ReadLine();
    Console.WriteLine("Введите возраст:");
   string age = Console.ReadLine();
    string hello = Welcoming(welc, name, age);
    Console.WriteLine(hello);
 }

internal static string Welcoming (string welc_m, string name_m, string age_m)
  {
      string hello_m;
      hello_m = "{welc_m}, {name_m}: {age_m}";
      return hello_m;
  }
}
}