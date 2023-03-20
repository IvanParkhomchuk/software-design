using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        int cellAmount = 9;
        char player;
        string userTurn;

        WinCheck winCheck = new WinCheck();

        public void Play()
        {
            int fpScore = 0;
            int spScore = 0;

            int gameNum = 0;

            while (true)
            {
                Console.Clear();

                Field field = new Field(cellAmount);

                for (int i = 0; i < cellAmount; i++)
                {
                    player = (gameNum + i) % 2 == 0 ? 'X' : 'O';

                    introductoryMessage(fpScore, spScore, gameNum);
                    field.ShowField(field.cells);

                    userTurn = Console.ReadLine();
                    bool isNum = int.TryParse(userTurn.ToString(), out int userTurnNum);

                    while (!isNum || (!(userTurnNum >= 1) || !(userTurnNum <= 9)) || (field.cells[userTurnNum - 1] == 'X' || field.cells[userTurnNum - 1] == 'O'))
                    {
                        Console.Clear();

                        introductoryMessage(fpScore, spScore, gameNum);

                        field.ShowField(field.cells);

                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        if (!isNum)
                        {
                            Console.WriteLine("Please enter a valid number between 1 and 9.\n");
                        }
                        else if (!(userTurnNum >= 1) || !(userTurnNum <= 9))
                        {
                            Console.WriteLine($"There is no cell \"{userTurnNum}\" on the field.\n");
                        }
                        else if (field.cells[userTurnNum- 1] == 'X' || field.cells[userTurnNum- 1] == 'O')
                        {
                            Console.WriteLine($"Cell \"{userTurnNum}\" is already set.\n");
                        }

                        Console.ForegroundColor = ConsoleColor.White;

                        userTurn = Console.ReadLine();

                        isNum = int.TryParse(userTurn, out userTurnNum);
                    }

                    field.cells[userTurnNum - 1] = player;

                    char[,] cellsMatrix = ConvertToMatrix(field.cells);

                    if (winCheck.CheckResult(cellsMatrix))
                    {
                        resultMessage(field, $"Player {player} win!");

                        if (player == 'X')
                        {
                            fpScore++;
                        } else
                        {
                            spScore++;
                        }

                        break;
                    }
                    else if (i == 8)
                    {
                        resultMessage(field, "Draw!");
                        break;
                    }

                    Console.Clear();
                }

                Console.WriteLine("\nDo you want to play again? (y/n)\n");
                string playAgain = Console.ReadLine();

                gameNum++;

                if (playAgain != "y")
                {
                    break;
                }
            }

        }

        public void introductoryMessage(int fpScore, int spScore, int gameNum)
        {
            Console.ForegroundColor = ConsoleColor.White;

            char player1 = gameNum % 2 == 0 ? 'X' : 'O';
            char player2 = (gameNum + 1) % 2 == 0 ? 'X' : 'O';

            Console.WriteLine("Let\'s play Tic Tac Toe!");
            Console.WriteLine($"Player 1: {player1} [{fpScore}]");
            Console.WriteLine($"Player 2: {player2} [{spScore}]");

            Console.WriteLine($"\nPlayer {player} turn. Select from 1 to 9 from the game board\n");
        }

        char[,] ConvertToMatrix(char[] cells)
        {
            int index = 0;
            char[,] matrix = new char[3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrix[x, y] = cells[index++];
                }
            }

            return matrix;
        }

        public void resultMessage(Field field, string result)
        {
            Console.Clear();
            field.ShowField(field.cells);
            Console.WriteLine(result);
        }
    }
}
