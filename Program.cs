// See https://aka.ms/new-console-template for more information
using WarrriorWars;
using WarrriorWars.Enum;


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static Random rng = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Warrior Wars");

            Warrior goodGuy = new Warrior("Bob", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Joe", Faction.BadGuy);

            goodGuy.Attack(badGuy);
            badGuy.Attack(goodGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(500);

            }
        }
    }
}



