namespace Exercise8
{
    internal class Program
    {
        static string[] hangmanWords = { "bumfuzzle", "hullaballoo", "meldrop", "bumbershoot", "smicker", "collywobbles" };
        static string misses = "";
        static string guess = "Guess:  ";
        static char[] selectedWord = GetWord(hangmanWords);
        static char[] playChars = EraseWord(selectedWord);

        static void Main(string[] args)
        {
            int turns = selectedWord.Length + 5;
            int turn = 0;
            while (turn < turns)
            {
                PrintBoard(playChars, misses, guess);
                turn++;
            }
        }
        static void PrintBoard(char[] word, string misses, string guess)
        {
            string topBottom = new string('-', word.Length * 2 + 8);
            Console.WriteLine(topBottom);
            Console.WriteLine();
            Console.WriteLine($"Word:   {string.Join(' ', word)}");
            Console.WriteLine();
            Console.WriteLine($"Misses: {misses}");
            Console.WriteLine();
            PlayerMove(playChars);
            Console.WriteLine();
        }
        static char[] GetWord(string[] hangmanWords)
        {
            Random random = new Random();

            return hangmanWords[random.Next(0, hangmanWords.Length)].ToCharArray();
        }
        static char[] EraseWord(char[] word)
        {
            char[] result = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                result[i] = '_';
            }

            return result;
        }
        static string PlayerMove(char[] playChars)
        {
            string guess = "Guess:  ";
            if (!playChars.Contains('_'))
            {
                guess = "YOU GOT IT!";

                return guess;
            }
            else
            {
                bool guessed = false;
                Console.Write(guess);
                char playerInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                guess = playerInput.ToString();
                for (int i = 0; i < playChars.Length; i++)
                {
                    if (playerInput == selectedWord[i])
                    {
                        playChars[i] = playerInput;
                        guessed = true;
                    }
                }
                if (!guessed)
                {
                    misses += playerInput.ToString();
                }

                return guess;
            }
        }
    }
}