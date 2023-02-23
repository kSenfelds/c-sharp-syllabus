namespace Exercise_9
{
    internal class RollTwoDice
    {
        public void rollTwoDice()
        {
            Console.Write("Enter desired sum:");
            int desiredSum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Desired sum: {desiredSum}");
            Random dice = new Random();
            bool isRolling = true;
            while (isRolling)
            {
                int dice1 = dice.Next(1, 7);
                int dice2 = dice.Next(1, 7);
                Console.WriteLine($"{dice1} and {dice2} = {dice1 + dice2}");
                if (dice1 + dice2 == desiredSum)
                {
                    isRolling = false;
                }
            }
        }
    }
}
