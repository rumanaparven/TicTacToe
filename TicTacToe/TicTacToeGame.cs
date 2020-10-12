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
        public void UC7_MakeAMoveForPlayer(char[] board, char letter)
        {
            Console.WriteLine("Enter the position of your move : ");

            int position = Convert.ToInt32(Console.ReadLine());
            while (position < 1 || position > 9)
            {
                Console.WriteLine("You have entered an Invalid position");
                Console.WriteLine("Position should be between 1-9.");
                Console.WriteLine("Enter the position of your move : ");
                position = Convert.ToInt32(Console.ReadLine());
            }

            while (!(board[position] == ' '))
            {
                Console.WriteLine("Position already full.");
                Console.WriteLine("Enter another position between 1-9 : ");
                position = Convert.ToInt32(Console.ReadLine());
            }
            board[position] = letter;
        }
        public string UC6_WhoPlaysFirst()
        {
            Random random = new Random();
            int toss=random.Next(0, 2);
            if (toss == 0)
            {
                return "user";
            }
            else
                return "computer";
        }
        public char GetLetterOfComouter(char letterOfUser)
        {
            if (letterOfUser.Equals('X'))
                return 'O';
            else
                return 'X';
        }
        public char[] GetCopyOfBoard(char[] board)
        {
            char[] copyOfBoard = new char[10];
            for(int i = 0; i < 10; i++)
            {
                copyOfBoard[i] = board[i];
            }
            return copyOfBoard;
        }
        public bool IsSpaceFree(char[] copyOfBoard, int index)
        {
            if ((copyOfBoard[index] == ' '))
                return true;
            else
                return false;
        }
        public int GetWinningMove(char[] board, char letterOfUser)
        {
            for(int index = 1; index < board.Length; index++)
            {
                char[] copyOfBoard = GetCopyOfBoard(board);
                if (IsSpaceFree(copyOfBoard, index))
                {
                    MakeAMove(index, letterOfUser,copyOfBoard);
                    if (CheckIfWon(copyOfBoard, letterOfUser))
                    {
                        return index;
                    }
                }
            }
            return 0;
        }
        public void UC8_MakeAMoveForComputer(char[] board, char letterOfUser, char letterOfComputer)
        {
            int userWinningMove = 0;
            int winningMove = GetWinningMove(board, letterOfUser);
            if (winningMove != 0)
                board[winningMove] = letterOfComputer;
            else if (true)
            {
                userWinningMove = GetWinningMove(board, letterOfUser);
                if (userWinningMove != 0)
                    board[userWinningMove] = letterOfComputer;
            }
            if(winningMove == 0 && userWinningMove == 0)
            {
                int[] cornerMove = { 1, 3, 7, 9 };
                int move = GetRandomCornerMove(board, cornerMove);
                board[move] = letterOfComputer;
            }
            

        }
        public int GetRandomCornerMove(char[] board, int[] cornerMove)
        {
            for(int i = 0; i < 4; i++)
            {
                if (board[cornerMove[i]] == ' ')
                    return cornerMove[i];
            }
            return 0;
        }
        public void MakeAMove(int position, char letter,char[] b)
        {
            b[position] = letter;
        }
        public bool CheckIfWon(char[] board, char letter)
        {
            bool row1 = (board[1] == letter && board[2] == letter && board[3] == letter);
            bool row2 = (board[4] == letter && board[5] == letter && board[6] == letter);
            bool row3 = (board[7] == letter && board[8] == letter && board[9] == letter);
            bool col1 = (board[1] == letter && board[4] == letter && board[7] == letter);
            bool col2 = (board[2] == letter && board[5] == letter && board[8] == letter);
            bool col3 = (board[3] == letter && board[6] == letter && board[9] == letter);
            bool diag1 = (board[1] == letter && board[5] == letter && board[9] == letter);
            bool diag2 = (board[3] == letter && board[5] == letter && board[7] == letter);
            return (row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2);

        }
    }
}
