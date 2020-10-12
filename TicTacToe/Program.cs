using System;

namespace TicTacToe
{

    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;
            do
            {
                Console.WriteLine("Welcome to Tic Tac Toe game");
                TicTacToeGame tictactoe = new TicTacToeGame();
                char[] board = tictactoe.CreateABoard();
                char letterOfUser = tictactoe.ChooseALetter();
                char letterOfComputer = tictactoe.GetLetterOfComouter(letterOfUser);
                Console.WriteLine("Player choses " + letterOfUser);
                Console.WriteLine("Tic Tac Toe Board :");
                tictactoe.UC3_ShowBoard(board);
                string toss = tictactoe.UC6_WhoPlaysFirst();
                Console.WriteLine();
                Console.WriteLine(toss + " wins the toss.");
                Console.WriteLine();
                if (toss == "computer")
                {
                    Console.WriteLine("Turn for computer");
                    tictactoe.UC8_MakeAMoveForComputer(board, letterOfUser, letterOfComputer);
                    tictactoe.UC3_ShowBoard(board);
                }
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Turn for user");
                    tictactoe.UC7_MakeAMoveForPlayer(board, letterOfUser);
                    tictactoe.UC3_ShowBoard(board);
                    Console.WriteLine();
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
                    Console.WriteLine();
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
                Console.WriteLine();
                Console.WriteLine("Do you want to play again?(Y/N)");
                playAgain = Console.ReadLine();
                if (playAgain.Equals("y"))
                    playAgain = "Y";
                else if (playAgain.Equals("n"))
                    playAgain = "N";
                while (!(playAgain.Equals("Y") || playAgain.Equals("N")))
                {
                    Console.WriteLine("Enter a valid Input");
                    playAgain = Console.ReadLine();
                    if (playAgain.Equals("y"))
                        playAgain = "Y";
                    else if (playAgain.Equals("n"))
                        playAgain = "N";
                }
            } while (playAgain != "N");
        
            

        }
    }
}
