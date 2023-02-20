namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a text");
            var input = Console.ReadLine();
            Console.WriteLine(mapPhoneWordNestedIf(input.ToLower()));
            Console.WriteLine(mapPhoneWordSwitchCase(input.ToLower()));
            Console.ReadKey();
        }
        static string mapPhoneWordNestedIf (string word)
        { 
            bool isAlphabet = word.All(char.IsLetter);
            string result = "";
            
            if (isAlphabet)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == 'a' || word[i] == 'b' || word[i] == 'c')
                    {
                        result += "2";
                    }
                    else if (word[i] == 'd' || word[i] == 'e' || word[i] == 'f')
                    {
                        result += "3";
                    }
                    else if (word[i]=='g' || word[i] == 'h' || word[i] == 'i')
                    {
                        result += "4";
                    }
                    else if (word[i] == 'j' || word[i] == 'k' || word[i] == 'l')
                    {
                        result += "5";
                    }
                    else if (word[i] == 'm' || word[i] == 'n' || word[i] == 'o')
                    {
                        result += 6;
                    }
                    else if (word[i] == 'p' || word[i] == 'q' || word[i] == 'r'|| word[i]== 's')
                    {
                        result += 7;
                    }
                    else if (word[i] == 't'|| word[i] == 'u' || word[i]== 'v')
                    {
                        result += 8;
                    }
                    else
                    {
                        result += "9";
                    }
                }
            }
            else
            {
              result = "Text includes non letters";
            }
            return result;
            
        }
        static string mapPhoneWordSwitchCase (string word)
        {
            string result = "";

                foreach (char c in word)
                {
                    switch (c)
                    {
                        case 'a': case 'b': case 'c':
                            result += "2"; 
                            break;
                        case 'd': case 'e': case 'f':
                            result += "3";
                            break;
                        case 'g': case 'h': case 'i':
                            result += "4";
                            break;
                        case 'j': case 'k': case 'l':
                            result += "5";
                            break;
                        case 'm': case 'n': case 'o':
                            result += "6";
                            break;
                        case 'p': case 'q': case 'r': case 's':
                            result += "7";
                            break;
                        case 't': case 'u': case 'v':
                            result += "8";
                            break;
                        case 'w': case 'x': case 'y': case 'z':
                            result += "9";
                            break;
                    default: result += "?"; break;

                    }
                }

             return result;
        }
    }
}