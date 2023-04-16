using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four
{

    internal class Program
    {

        static void printboard(int[,] board)
        {

            Console.Write(" ");

            for (int l = 0; l < board.GetLength(1); l++)
            {

                int hold;

                hold = l + 1;

                Console.Write(" ");

                Console.Write(hold);

            }

            Console.WriteLine("");

            for (int i = 0; i < board.GetLength(0); i++)
            {

                int temp;

                temp = i + 1;

                Console.Write(temp + " ");

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    Console.Write(board[i, j]);

                    Console.Write(" ");

                }

                Console.WriteLine("");

            }

            Console.WriteLine("");

            Console.WriteLine("");

        }

        static void Main(string[] args)
        {

            int[,] board = new int[6, 7];

            Boolean run = true;

            Boolean p1turn = true, p2turn = false;

            while (run == true)
            {

                while (p1turn == true)
                {

                    printboard(board);

                    Console.WriteLine("");

                    Console.WriteLine("Enter Which Column You Want To place Your Piece In, Player 1");

                    int column = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");

                    int tempcolumn = column - 1;

                    if (board[5, tempcolumn] != 0)
                    {

                        if (board[4, tempcolumn] != 0)
                        {

                            if (board[3, tempcolumn] != 0)
                            {

                                if (board[2, tempcolumn] != 0)
                                {

                                    if (board[1, tempcolumn] != 0)
                                    {

                                        if (board[1, tempcolumn] != 0)
                                        {

                                            Console.WriteLine("Invalid Choice Please Choose Again");

                                            p1turn = true;

                                        }
                                        else
                                        {

                                            p1turn = false;

                                            p2turn = true;

                                            board[0, tempcolumn] = 1;
                                        }
                                    }
                                    else
                                    {

                                        p1turn = false;

                                        p2turn = true;

                                        board[1, tempcolumn] = 1;
                                    }
                                }
                                else
                                {

                                    p1turn = false;

                                    p2turn = true;

                                    board[2, tempcolumn] = 1;
                                }
                            }
                            else
                            {

                                p1turn = false;

                                p2turn = true;

                                board[3, tempcolumn] = 1;
                            }
                        }
                        else
                        {

                            p1turn = false;

                            p2turn = true;

                            board[4, tempcolumn] = 1;
                        }
                    }
                    else
                    {

                        p1turn = false;

                        p2turn = true;

                        board[5, tempcolumn] = 1;

                    }

                }

                while (p2turn == true)
                {

                    printboard(board);

                    Console.WriteLine("");

                    Console.WriteLine("Enter Which Column You Want To place Your Piece In, Player 2");

                    int column = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("");

                    int tempcolumn = column - 1;

                    if (board[5, tempcolumn] != 0)
                    {

                        if (board[4, tempcolumn] != 0)
                        {

                            if (board[3, tempcolumn] != 0)
                            {

                                if (board[2, tempcolumn] != 0)
                                {

                                    if (board[1, tempcolumn] != 0)
                                    {

                                        if (board[1, tempcolumn] != 0)
                                        {

                                            Console.WriteLine("Invalid Choice Please Choose Again");

                                            p2turn = true;

                                        }else 
                                        { 

                                        p1turn = true;

                                        p2turn = false;

                                        board[0, tempcolumn] = 2;
                                        }
                                    }else 
                                    { 

                                    p1turn = true;

                                    p2turn = false;

                                    board[1, tempcolumn] = 2;
                                    }
                                }
                                else
                                {

                                p1turn = true;

                                p2turn = false;

                                board[2, tempcolumn] = 2;
                                }
                            }else 
                            { 

                            p1turn = true;

                            p2turn = false;

                            board[3, tempcolumn] = 2;
                            }
                        }else
                        { 

                        p1turn = true;

                        p2turn = false;

                        board[4, tempcolumn] = 2;
                        }
                    }
                    else
                    {

                        p1turn = true;

                        p2turn = false;

                        board[5, tempcolumn] = 2;

                    }

                }

            }

        }
    }

}
