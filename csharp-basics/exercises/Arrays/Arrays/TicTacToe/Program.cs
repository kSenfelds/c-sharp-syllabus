using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char player = 'O';
        private static int moves = 0;

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            while (!CheckWinner())
            {
                PlayerMove();
                DisplayBoard();
            }

            Console.ReadKey();
            
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static void PlayerMove()
        {
            Console.WriteLine($"{player}, choose your location (row, column)");
            var input = Console.ReadLine();
            if (board[int.Parse(input[0].ToString()), int.Parse(input[2].ToString())] != ' ')
            {
                Console.WriteLine("Location taken!");
                
            }
            else 
            {
                board[int.Parse(input[0].ToString()), int.Parse(input[2].ToString())] = player == 'O' ? 'O' : 'X';
                player = player == 'O' ? 'X' : 'O';
            }
            
        }

        private static bool CheckWinner ()
        {
            
            if (board[0, 0] == board[0, 1]&& board[0, 1]== board[0, 2]&& board[0, 0]!= ' ')
            {
                Console.WriteLine($"Winner is {board[0, 0]}"); 
                return true;
            }

           else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != ' ')
            {
                Console.WriteLine($"Winner is {board[1, 1]}");
                return true;
            }

           else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != ' ')
            {
                Console.WriteLine($"Winner is {board[2, 0]}");
                return true;
            }

            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[2, 0] != ' ')
            {
                Console.WriteLine($"Winner is {board[2, 0]}");
                return true;
            }

            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[1, 1] != ' ')
            {
                Console.WriteLine($"Winner is {board[1, 1]}");
                return true;
            }

            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[2, 2] != ' ')
            {
                Console.WriteLine($"Winner is {board[2, 2]}");
                return true;
            }

            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[1, 1] && board[2, 2] != ' ')
            {
                Console.WriteLine($"Winner is {board[1, 1]}");
                return true;
            }

            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[1, 1] != ' ')
            {
                Console.WriteLine($"Winner is {board[1, 1]}");
                return true;
            }

            else if (moves == 9)
            {
                Console.WriteLine("The game is a tie.");
                return true;
            }

            else
            {
                return false;
            }

        }

    }
}
