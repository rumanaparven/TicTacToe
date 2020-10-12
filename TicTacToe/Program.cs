using System;

namespace TicTacToe
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe game");
            TicTacToeGame tictactoe = new TicTacToeGame();
            char[] board = tictactoe.CreateABoard();
            char letterOfUser = tictactoe.ChooseALetter();
            char letterOfComputer = tictactoe.GetLetterOfComouter(letterOfUser);
            Console.WriteLine("Player choses " + letterOfUser);
            tictactoe.UC3_ShowBoard(board);
            string toss = tictactoe.UC6_WhoPlaysFirst();
            Console.WriteLine(toss + " plays first.");

            tictactoe.UC7_MakeAMoveForPlayer(board, letterOfUser);
            tictactoe.UC3_ShowBoard(board);
            tictactoe.UC8_MakeAMoveForComputer(board,letterOfUser, letterOfComputer);
            tictactoe.UC3_ShowBoard(board);

        }
    }
}
