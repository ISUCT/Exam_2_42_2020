using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class Search
    {
        public double NewMax;

        public double OldMax;

        public double Сomposition;

        public double Searching(double[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
           {
                if (NewMax < array[i])
                {
                    OldMax = NewMax;
                    NewMax = array[i];
                }
                else
                {
                    if (OldMax < array[i])
                    {
                        OldMax = array[i];
                    }
                 }
            }

            Console.Write($"Максимально произведение между числами {OldMax} и {NewMax} в заданной последовательности = ");
            Сomposition = OldMax * NewMax;
            return Сomposition;
        }
    }
}
