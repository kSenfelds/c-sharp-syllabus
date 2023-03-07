using System;

namespace DragRace
{
    public class Tesla :ICar
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed+=9;
        }

        public void SlowDown() 
        {
            currentSpeed-=10;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}