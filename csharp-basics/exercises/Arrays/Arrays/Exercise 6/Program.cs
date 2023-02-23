namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 101);
            }
            int[] array2 = new int[array1.Length];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }
            array1[array1.Length - 1] = -7;
            Console.WriteLine($"Array 1 : {String.Join(" ", array1)}");
            Console.WriteLine($"Array 2 : {String.Join(" ", array2)}");
            Console.ReadKey();
        }
    }
}