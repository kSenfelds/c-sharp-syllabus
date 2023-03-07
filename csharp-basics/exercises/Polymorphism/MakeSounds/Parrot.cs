using System;

namespace MakeSounds
{
    internal class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Polly need a Cracker!");
        }
    }
}
