using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<ISound>();
            list.Add(new Parrot());
            list.Add(new Radio());
            list.Add(new Firework());
            list.ForEach(x => x.PlaySound());

            Console.ReadKey();
        }
    }
}