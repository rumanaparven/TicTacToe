using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] CreateABoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < 10; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char ChooseALetter()
        {
            Console.WriteLine("Choose a letter between 'X' and 'O' : ");
            string letterOfTheUser = Console.ReadLine();
            char letter = letterOfTheUser[0];
            return letter;
        }
    }
}
