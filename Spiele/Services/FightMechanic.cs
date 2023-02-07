using Spiele.Models;
using System;

namespace Spiele.Services
{
    public class FightMechanic
    {
        int damage = 1;
        int pressedInt;
        bool check = false;
        Random random = new Random();


        public void Udar(Voin player, Voin enemy)
        {
            Console.Write("Введите число от 0 до 9: ");
            do
            {
                var pressedKey = Console.ReadKey();
                check = int.TryParse(pressedKey.KeyChar.ToString(), out pressedInt);

                if (check && pressedInt >= 0 && pressedInt <=9)
                {
                    int enemyNum = random.Next(2);
                    bool playerWin = ((pressedInt + enemyNum) % 2 )== 0;
                    if (playerWin)
                    {
                        enemy.PoluchitjYron(damage);
                        Console.WriteLine($"Игрок нанёс {damage} урона!");
                    }
                    else
                    {
                        player.PoluchitjYron(damage);
                        Console.WriteLine($"Игрок получил {damage} урона!");
                    }
                }
            } while (check);
            Console.WriteLine();
            Console.WriteLine("_________________________");
        }

        public void Kriti4eskijUdar()
        {
        }
    }
}
