using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static System.Console;

namespace TicTacToe
{
    public class TicTacToe
    {

        public char[] board = new char[9];
        public static int[,] win_combos = new int[,] {
            { 0, 1, 2 },
            { 3, 4, 5 },
            { 6, 7, 8 },
            { 0, 3, 6 },
            { 1, 4, 7 },
            { 2, 5, 8 },
            { 0, 4, 8 },
            { 2, 4, 6 }
        };
        public bool current_player; // true: player 1, false: player 2
        public int turn_count;

        public TicTacToe()
        {
            Reset();
        }

        public void Reset()
        {
            // Display a message
            WriteLine("Starting a new game of Tic Tac Toe!");

            // Reset the board
            for (int i = 0; i < 9; i++)
            {
                board[i] = ' ';
            }

            // Start with player 1
            current_player = true;
            turn_count = 1;
        }

        public void PrintBoard()
        {
            WriteLine("     |     |      ");
            WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            WriteLine("_____|_____|_____ ");
            WriteLine("     |     |      ");
            WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            WriteLine("_____|_____|_____ ");
            WriteLine("     |     |      ");
            WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            WriteLine("     |     |      ");
        }

        public int CheckForWinner()
        {
            // 0 = no winner; 1 = player 1; 2 = player 2
            for (int i = 0; i < 8; i++)
            {
                // Check each winning combination
                if (board[win_combos[i, 0]] == 'X' &&
                    board[win_combos[i, 1]] == 'X' &&
                    board[win_combos[i, 2]] == 'X')
                {
                    return 1;
                }
                else if (board[win_combos[i, 0]] == 'O' &&
                            board[win_combos[i, 1]] == 'O' &&
                            board[win_combos[i, 2]] == 'O')
                {
                    return 2;
                }
            }

            return 0;
        }

        public bool SetTile(int tile)
        {
            // Returns true if the move is successful, false otherwise

            // Check for issues before we apply the move
            if (tile < 1 || tile > 9 || (board[tile - 1] != ' '))
            {
                WriteLine("Invalid move. Please choose a tile that is not already occupied.");
                return false;
            }

            // Tiles are numbered from 1 to 9, so subtract 1 to get the correct index
            board[tile - 1] = current_player ? 'X' : 'O';

            return true;
        }

        public void Run()
        {
            PrintBoard();

            while (true)
            {
                int tile;
                do
                {
                    Write("{0}, please enter your move (1-9): ", (current_player ? "Player 1" : "Player 2"));
                    tile = int.Parse(ReadLine());
                    if (tile == 0) return;
                } while (!SetTile(tile)); // SetTile returns true for success. We want to loop if it fails instead.

                PrintBoard();

                if (CheckForWinner() > 0)
                {
                    WriteLine("Congratulations {0}! You have won!", (current_player ? "Player 1" : "Player 2"));
                    break;
                }

                if (turn_count > 8)
                {
                    WriteLine("It's a draw!");
                    Reset();
                    PrintBoard();
                }
                else
                {
                    turn_count++;
                }

                current_player = !current_player;
            }
        }
    }
}
