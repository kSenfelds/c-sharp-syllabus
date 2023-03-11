using System;

namespace DragRace
{
    internal class Volkswagen : ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 9;
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Prrrrrrrrrr");
        }
    }
}