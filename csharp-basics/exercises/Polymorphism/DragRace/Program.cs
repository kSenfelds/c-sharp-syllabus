using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ICar> list = new List<ICar>();
            list.Add(new Bmw());
            list.Add(new Audi());
            list.Add(new Lexus());
            list.Add(new Tesla());
            list.Add(new Toyota());
            list.Add(new Volkswagen());

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    list.ForEach(x => x.StartEngine());
                }
                else
                {
                    for (int j = 0; j < list.Count(); j++)
                    {
                        if (i == 2)
                        {
                            if (list[j] is IBoostable boostable)
                            {
                                boostable.UseNitrousOxideEngine();
                            }
                        }
                        else
                        {
                            list[j].SpeedUp();
                        }
                    }
                }
            }

            var maxSpeed = list.Max(x => int.Parse(x.ShowCurrentSpeed()));
            var winner = list.First(x => x.ShowCurrentSpeed() == maxSpeed.ToString());
            Console.WriteLine($"{winner.GetType()} : {maxSpeed}");

            Console.ReadKey();
        }
    }
}