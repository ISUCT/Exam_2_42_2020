using System;

namespace CourseApp
{
    public class Human
    {
            public static string Status(int age)
            {
                if (age < 8)
                {
                    return "Дошкольник";
                }
                else if (age < 18)
                {
                    return "Школьник";
                }
                else if (age < 23)
                {
                    return "Студент";
                }
                else
                {
                    return "Взрослый";
                }
            }
    }
}