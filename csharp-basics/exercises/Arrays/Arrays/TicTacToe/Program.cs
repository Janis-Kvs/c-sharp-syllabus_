using System;
using System.Diagnostics.Eventing;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static bool tie = false;
        private static bool win = false;
        private static char playerTurn = 'X';
        private static int row;
        private static int column;

        private static void Main(string[] args)
        {
            InitBoard();
            do
            {
                DisplayBoard();
                Console.WriteLine($"'{playerTurn}', choose your location of row and column in format: row,column ");
                string answer = Console.ReadLine();
                string[] subsString = answer.Split(','); // split the answer in string array
                if (subsString.Length != 2)
                {
                    Console.WriteLine("\nPlease insert row and column in the right format as asked!\n");
                    continue;
                }
                int.TryParse(subsString[0], out row); // parse the input to row integer
                int.TryParse(subsString[1], out column); // parse the input to row integer
                if (row > 2 || row < 0 || column > 2 || column < 0)
                {
                    Console.WriteLine("\nPlease insert row and column range between 0 and 2\n");
                    continue;
                }

                FillBoard();
                IsWin();
                IsTie();
                ChangePlayer();
                
                if (!win && tie)
                    Console.WriteLine($"It is a Tie!");

            } while (!win || !tie);
            Console.ReadKey();
        }

        private static void FillBoard()
        {
            // fills board with X or O
            if (board[row, column] == ' ')
            {
                board[row, column] = playerTurn;
            }
            else
            {
                return;
            }
        }

        private static void ChangePlayer()
        {
            // changes players
            playerTurn = playerTurn == 'X' ? 'O' : 'X';
        }

        private static void IsTie()
        {
            // declares if there is a tie
            int filledFields = 0;
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    if (board[r, c] != ' ')
                        filledFields++;
                    
            }
            if (filledFields == 9)
                tie = true;
        }

        private static void IsWin()
        {
            // declares if there is a winner
            int[][] winCombinations = new int[][]
            {
                new int[]{0,0,0,1,0,2},
                new int[]{1,0,1,1,1,2},
                new int[]{2,0,2,1,2,2},
                new int[]{0,0,1,0,2,0},
                new int[]{0,1,1,1,2,1},
                new int[]{0,2,1,2,2,2},
                new int[]{0,0,1,1,2,2},
                new int[]{0,2,1,1,2,0}
            };
            foreach (int[] combination in winCombinations)
            {
                if (board[combination[0], combination[1]] == playerTurn && board[combination[2], combination[3]] == playerTurn && board[combination[4], combination[5]] == playerTurn)
                {
                    win = true;
                    Console.WriteLine($"Player '{playerTurn}' won the game!");
                }
            }
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     0 1 2");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
