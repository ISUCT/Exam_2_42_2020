using System;

namespace CourseApp
{
    public class Exam
    {
        public static (int x, string y)[] NumberingOfIngredients(string[] ingredients)
        {
            var listOfIngredients = new(int x, string y)[(int)ingredients.Length];
            for (int i = 0; i < ingredients.Length; i++)
            {
                listOfIngredients[i] = (i + 1, ingredients[i]);
            }

            return listOfIngredients;
        }

        public static void Main(string[] args)
        {
            string[] ingredients = { "Хлеб", "Масло", "Колбаса", "Сыр" };
            var listOfIngredients = new(int x, string y)[ingredients.Length];
            listOfIngredients = NumberingOfIngredients(ingredients);
            foreach ((int x, string y) i in listOfIngredients)
            {
                var (x, y) = i;
                Console.WriteLine($"{i.x}. {i.y};");
            }
        }
    }
}