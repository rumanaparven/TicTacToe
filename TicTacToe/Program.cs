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
            Console.WriteLine("Player choses " + letterOfUser);
            tictactoe.UC3_ShowBoard(board);
            tictactoe.UC4_MakeAMoveForPlayer(board, letterOfUser);
            string toss = tictactoe.UC6_WhoPlaysFirst();
            Console.WriteLine(toss + " plays first.");
        }
    }
}
