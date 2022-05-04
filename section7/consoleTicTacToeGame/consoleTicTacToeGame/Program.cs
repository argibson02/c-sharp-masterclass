using System;

namespace consoleTicTacToeGame
{
    internal class Program
    {
        static string[,] board = {
                { " ", " ", " " },
                { " ", " ", " " },
                { " ", " ", " " }
            };

        static int numOfMoves = 0;
        static bool playComp = false;
        static bool compTurn = false;
        static string compMarker;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the TicTacToe in console game!");
            Console.WriteLine("===========================================================================");
            HumanOrComp();
            Console.Read();
        }

        static void HumanOrComp()
        {
            Console.WriteLine($"Press '1' to play against a human, press '2' to play against the computer.");
            string userEntry = Console.ReadLine();
            Console.WriteLine("");

            if (int.TryParse(userEntry, out int selection))
            {
                if (selection == 1)
                {
                    Console.WriteLine($"+++++++++ TUTORIAL +++++++++++");
                    Console.WriteLine("Please enter in the NUMBER of the cell you would like to take.");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|   1   |   2   |   3   |");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|   4   |   5   |   6   |");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|   7   |   8   |   9   |");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"+++++++++ TUTORIAL +++++++++++\n");
                    Play();
                }
                else if (selection == 2)
                {
                    playComp = true;

                    Console.WriteLine($"+++++++++ TUTORIAL +++++++++++");
                    Console.WriteLine("Please enter in the NUMBER of the cell you would like to take.\nX will always go first.");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|   1   |   2   |   3   |");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|   4   |   5   |   6   |");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|   7   |   8   |   9   |");
                    Console.WriteLine($"|       |       |       |");
                    Console.WriteLine($"|-------+-------+-------|");
                    Console.WriteLine($"+++++++++ TUTORIAL +++++++++++\n");
                    PlayComp();
                }
                else
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("~ Invalid entry. Please enter in '1' or '2'. ~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    HumanOrComp();
                }
            }
        }

        static void PlayComp()
        {
            Random firstMove = new Random();

            if (firstMove.Next(0, 2) == 1)
            {
                Console.WriteLine($"=================================");
                Console.WriteLine("= Computer plays the first move. =");
                Console.WriteLine("==================================");

                compMarker = "X";
                compTurn = true;
                Play();
            }
            else
            {
                Console.WriteLine("============================");
                Console.WriteLine("= You play the first move. =");
                Console.WriteLine("============================");

                compMarker = "0";
                Play();
            }
        }

        static void Play()
        {
            string move;
            string player;

            if (numOfMoves % 2 == 0)
            {
                player = "X";
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Player X, please make a move.");
            }
            else
            {
                player = "O";
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Player O, please make a move.");
            }

            DisplayBoard();

            if (!playComp)
            {
                Console.Write("Move: ");
                move = Console.ReadLine();
                Console.WriteLine("\n");

                ValidatePlayerMove(move, player);
            }
            else
            {
                if (compTurn)
                {
                    ValidateCompMove(generateCompMove(), player);

                }
                else
                {
                    Console.Write("Move: ");
                    move = Console.ReadLine();
                    Console.WriteLine("");

                    ValidatePlayerMove(move, player);
                }
            }

            if (numOfMoves > 4)
            {
                CheckForWinner();
            }
            else
            {
                Play();
            }
        }

        static int generateCompMove()
        {
            Random compMove = new Random();
            return compMove.Next(1, 10);
        }

        static void ValidateCompMove(int integerMove, string player)
        {
            switch (integerMove)
            {
                case 1:
                    if (!(board[0, 0].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[0, 0] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 2:
                    if (!(board[0, 1].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[0, 1] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 3:
                    if (!(board[0, 2].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[0, 2] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 4:
                    if (!(board[1, 0].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[1, 0] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 5:
                    if (!(board[1, 1].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[1, 1] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 6:
                    if (!(board[1, 2].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[1, 2] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 7:
                    if (!(board[2, 0].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[2, 0] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 8:
                    if (!(board[2, 1].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[2, 1] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                case 9:
                    if (!(board[2, 2].Equals(" ")))
                    {
                        ValidateCompMove(generateCompMove(), player);
                    }
                    else
                    {
                        board[2, 2] = player;
                        numOfMoves++;
                        compTurn = false;
                    }
                    break;
                default:
                    Console.WriteLine($"something wrong with comp: {integerMove}");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("~ Invalid entry. Please select a number between 1 - 9 ~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                    Play();
                    break;
            }
        }


        static void ValidatePlayerMove(string move, string player)
        {
            if (int.TryParse(move, out int integerMove))
            {
                switch (integerMove)
                {
                    case 1:
                        if (!(board[0, 0].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[0, 0] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 2:
                        if (!(board[0, 1].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[0, 1] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 3:
                        if (!(board[0, 2].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[0, 2] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 4:
                        if (!(board[1, 0].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[1, 0] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 5:
                        if (!(board[1, 1].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[1, 1] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 6:
                        if (!(board[1, 2].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[1, 2] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 7:
                        if (!(board[2, 0].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[2, 0] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 8:
                        if (!(board[2, 1].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[2, 1] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    case 9:
                        if (!(board[2, 2].Equals(" ")))
                        {
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n~ That space has already been taken! ~\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            Play();
                        }
                        else
                        {
                            board[2, 2] = player;
                            numOfMoves++;

                            if (playComp)
                            {
                                compTurn = true;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("~ Invalid entry. Please select a number between 1 - 9 ~");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                        Play();
                        break;
                }
            }
            else
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~ Invalid entry. Please select a number between 1 - 9 ~");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Play();
            }
        }

        static void DisplayBoard()
        {
            Console.WriteLine($"|-------+-------+-------|");
            Console.WriteLine($"|       |       |       |");
            Console.WriteLine($"|   {board[0, 0]}   |   {board[0, 1]}   |   {board[0, 2]}   |");
            Console.WriteLine($"|       |       |       |");
            Console.WriteLine($"|-------+-------+-------|");
            Console.WriteLine($"|       |       |       |");
            Console.WriteLine($"|   {board[1, 0]}   |   {board[1, 1]}   |   {board[1, 2]}   |");
            Console.WriteLine($"|       |       |       |");
            Console.WriteLine($"|-------+-------+-------|");
            Console.WriteLine($"|       |       |       |");
            Console.WriteLine($"|   {board[2, 0]}   |   {board[2, 1]}   |   {board[2, 2]}   |");
            Console.WriteLine($"|       |       |       |");
            Console.WriteLine($"|-------+-------+-------|\n");
        }

        static void CheckForWinner()
        {
            if (LineWin("X").Equals("X"))
            {
                if (playComp && compMarker.Equals("X"))
                {
                    Console.WriteLine($"\n************************");
                    Console.WriteLine($"** Computer (X) wins! **");
                    Console.WriteLine($"************************\n");
                }
                else if (playComp)
                {
                    Console.WriteLine($"\n******************");
                    Console.WriteLine($"** You (X) win! **");
                    Console.WriteLine($"******************\n");
                }
                else
                {
                    Console.WriteLine($"\n*************");
                    Console.WriteLine($"** X wins! **");
                    Console.WriteLine($"*************\n");
                }
                DisplayBoard();
                PlayAgain();
            }
            else if (LineWin("O").Equals("O"))
            {
                if (playComp && compMarker.Equals("O"))
                {
                    Console.WriteLine($"\n************************");
                    Console.WriteLine($"** Computer (O) wins! **");
                    Console.WriteLine($"************************\n");
                }
                else if (playComp)
                {
                    Console.WriteLine($"\n******************");
                    Console.WriteLine($"** You (O) win! **");
                    Console.WriteLine($"******************\n");
                }
                else
                {
                    Console.WriteLine($"\n*************");
                    Console.WriteLine($"** O wins! **");
                    Console.WriteLine($"*************\n");
                }
                DisplayBoard();
                PlayAgain();
            }
            else if (numOfMoves == 9)
            {
                Console.WriteLine($"The match was a Draw!\n");
                Console.WriteLine($"\n****************************");
                Console.WriteLine($"** The match was a Draw! **");
                Console.WriteLine($"****************************\n");
                DisplayBoard();
                PlayAgain();
            }
            else
            {
                Play();
            }
        }

        static string LineWin(string marker)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (board[i, 0].Equals(marker) && board[i, 1].Equals(marker) && board[i, 2].Equals(marker))
                {
                    return marker;
                }
                else if (board[0, i].Equals(marker) && board[1, i].Equals(marker) && board[2, i].Equals(marker))
                {
                    return marker;
                }
            }

            if (board[0, 0].Equals(marker) && board[1, 1].Equals(marker) && board[2, 2].Equals(marker))
            {
                return marker;
            }
            else if (board[0, 2].Equals(marker) && board[1, 1].Equals(marker) && board[2, 0].Equals(marker))
            {
                return marker;
            }

            return "";
        }

        static void PlayAgain()
        {
            Console.WriteLine($"Would you like to play again? Press '1' to play again, press '2' to quit.");
            string userEntry = Console.ReadLine();
            Console.WriteLine("");

            if (int.TryParse(userEntry, out int selection))
            {
                if (selection == 1)
                {
                    numOfMoves = 0;
                    playComp = false;
                    compTurn = false;
                    for (int i = 0; i < board.GetLength(0); i++)
                    {
                        for (int j = 0; j < board.GetLength(1); j++)
                        {
                            board[i, j] = " ";
                        }
                    }

                    HumanOrComp();
                }
                else if (selection == 2)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("GoodBye.");
                    return;
                }
                else
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("~ Invalid entry. Please enter in '1' or '2'. ~");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    PlayAgain();
                }
                return;
            }
            return;
        }
    }
}
