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
            char letter='a';
            Console.WriteLine("Choose a letter between 'X' and 'O' : ");
            string letterOfTheUser = Console.ReadLine();
            letter = letterOfTheUser[0];
            if (letterOfTheUser[0].Equals('x'))
                letter = 'X';
            else if(letterOfTheUser[0].Equals('o'))
                letter = 'O';
            while (!(letter.Equals('X') || letter.Equals('O'))) 
            {
                Console.WriteLine("Enter a valid Input");
                letterOfTheUser = Console.ReadLine();
                if (letterOfTheUser[0].Equals('x'))
                    letter = 'X';
                else if (letterOfTheUser[0].Equals('o'))
                    letter = 'O';
            }
            return letter;
            
        }
        public void UC3_ShowBoard(char[] board)
        {
            Console.WriteLine("Tic Tac Toe Board :");
            Console.WriteLine(board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("---------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("---------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}
