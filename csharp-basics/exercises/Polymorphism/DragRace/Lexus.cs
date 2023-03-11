using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public void SpeedUp()
        {
            currentSpeed += 8;
        }

        public void SlowDown()
        {
            currentSpeed -= 4;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 10;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}