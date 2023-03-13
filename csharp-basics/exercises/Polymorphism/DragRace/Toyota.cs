using System;

namespace DragRace
{
    internal class Toyota : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 6;
        }

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 10;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Klak....klakklakklak");
        }
    }
}