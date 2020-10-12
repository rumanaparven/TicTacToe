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
            Console.WriteLine(toss + " wins the toss.");
            if (toss == "computer")
            {
                tictactoe.UC8_MakeAMoveForComputer(board, letterOfUser, letterOfComputer);
                tictactoe.UC3_ShowBoard(board);
            }
            while (true)
            {
                Console.WriteLine("Turn for user");
                tictactoe.UC7_MakeAMoveForPlayer(board,letterOfUser);
                tictactoe.UC3_ShowBoard(board);
                if (tictactoe.CheckIfWon(board, letterOfUser))
                {
                    Console.WriteLine("user wins");
                    break;
                }
                if (tictactoe.CheckIfBoardIsFull(board))
                {
                    Console.WriteLine("Its a tie.");
                    break;
                }
                Console.WriteLine("Turn for computer");
                tictactoe.UC8_MakeAMoveForComputer(board, letterOfUser, letterOfComputer);
                tictactoe.UC3_ShowBoard(board);
                if (tictactoe.CheckIfWon(board, letterOfComputer))
                {
                    Console.WriteLine("Computer wins");
                    break;
                }
                if (tictactoe.CheckIfBoardIsFull(board))
                {
                    Console.WriteLine("Its a tie.");
                    break;
                }

            }
            

        }
    }
}
