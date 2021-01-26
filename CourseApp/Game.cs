using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Game
    {
        public static string Play(int firstPlayer, int secondPlayer)
        {
            string answer = "Победил второй игрок";
            if ((secondPlayer < 1) || (secondPlayer > 3))
            {
                answer = "Ошибка";
                return answer;
            }

            switch (firstPlayer)
            {
                case 1:
                    if (secondPlayer == 1)
                    {
                        answer = "Ничья";
                    }
                    else if (secondPlayer == 2)
                    {
                        answer = "Победил первый игрок";
                    }

                    break;
                case 2:
                    if (secondPlayer == 2)
                    {
                        answer = "Ничья";
                    }
                    else if (secondPlayer == 3)
                    {
                        answer = "Победил первый игрок";
                    }

                    break;
                case 3:
                    if (secondPlayer == 3)
                    {
                        answer = "Ничья";
                    }
                    else if (secondPlayer == 1)
                    {
                        answer = "Победил первый игрок";
                    }

                    break;
            }

            return answer;
        }
    }
}
