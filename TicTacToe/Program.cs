using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            TicTacToeGame tictactoe = new TicTacToeGame();
            char[] board = tictactoe.CreateABoard();
            char letterOfUser = tictactoe.ChooseALetter();
            Console.WriteLine("Player choses " + letterOfUser);

        }
    }
}
