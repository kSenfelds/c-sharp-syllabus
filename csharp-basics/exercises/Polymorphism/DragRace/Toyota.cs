using System;

namespace DragRace
{
    internal class Toyota : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 6;
        }

        public void SlowDown()
        {
            currentSpeed -= 5;
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Klak....klakklakklak");
        }
    }
}