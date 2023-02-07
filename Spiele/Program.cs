using Spiele.Models;
using Spiele.Services;
using System;

namespace Spiele
{
    public class Program
    {
        static void Main(string[] args)
        {
            string roleIgroka;
            FightMechanic mechanic = new FightMechanic();
            Voin voin = null;
            Mag mag = null;
            Drakon drakon = null;
            Voin enemy = new Voin();

            
            Console.WriteLine("Введите Вашу роль игрока Drakon, Voin или Mag ");

            do
            {
                roleIgroka = Console.ReadLine();

                roleIgroka = roleIgroka.ToLower();

                switch (roleIgroka)
                {
                    case "voin":
                        {
                            Console.WriteLine("Вы написали Voin ");
                            voin = new Voin();
                            break;
                        }
                    case "mag":
                        {
                            Console.WriteLine("Вы написали Mag ");
                            mag = new Mag();
                            break;
                        }
                    case "drakon":
                        {
                            Console.WriteLine("Вы написали Drakon ");
                            drakon = new Drakon();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Вы написали ерунду. Еще раз: ");
                            break;
                        }
                }
            } while (roleIgroka == "voin" || roleIgroka == "mag" || roleIgroka == "drakon");


            if (voin != null)
            {
                do
                {
                    mechanic.Udar(voin, enemy);
                    if (enemy.IsAlive)
                    {
                        mechanic.Udar(enemy, voin);
                    }
                } while (voin.IsAlive && enemy.IsAlive);
            }
            else if (mag != null)
            { }
            else if (drakon != null)
            { }
        }
    }
}
