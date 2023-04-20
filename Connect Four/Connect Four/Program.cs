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

        static void resetboard(int[,] board) 
        {

            for (int i = 0; i < board.GetLength(0); i++)
            {

                for (int j = 0; j < board.GetLength(1); j++)
                {

                    board[i, j] = 0;

                }

            }

        }

        static void Main(string[] args)
        {

            int[,] board = new int[6, 7];

            Boolean run = true;

            Boolean p1turn = true, p2turn = false;

            int rp = 0, two = 0, three = 0, four = 0, twov = 0, threev = 0, fourv = 0, turn=0;

            while (run == true)
            {

                turn++;

                while (p1turn == true)
                {

                    printboard(board);

                    Console.WriteLine("");

                    Console.WriteLine("Enter Which Column You Want To Place Your Piece In, Player 1");

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

                                            if (board[0, tempcolumn] != 0)
                                            {

                                                Console.WriteLine("Invalid Choice Please Choose Again");

                                                Console.WriteLine("");

                                                p1turn = true;

                                            }
                                            else
                                            {

                                                p1turn = false;

                                                p2turn = true;

                                                board[0, tempcolumn] = 1;

                                                rp = 0;    

                                            }
                                    }
                                    else
                                    {

                                        p1turn = false;

                                        p2turn = true;

                                        board[1, tempcolumn] = 1;

                                        rp = 1;

                                    }
                                }
                                else
                                {

                                    p1turn = false;

                                    p2turn = true;

                                    board[2, tempcolumn] = 1;

                                    rp = 2;

                                }
                            }
                            else
                            {

                                p1turn = false;

                                p2turn = true;

                                board[3, tempcolumn] = 1;

                                rp = 3;

                            }
                        }
                        else
                        {

                            p1turn = false;

                            p2turn = true;

                            board[4, tempcolumn] = 1;

                            rp = 4;

                        }
                    }
                    else
                    {

                        p1turn = false;

                        p2turn = true;

                        board[5, tempcolumn] = 1;

                        rp = 5;


                    }

                    /*horizontals*/

                    if (rp <= 5) 
                    {

                        if (tempcolumn < 4) 
                        {

                            two = tempcolumn+1;

                            three = tempcolumn+2;

                            four = tempcolumn+3;

                            if (board[rp, two] == 1) 
                            {

                                if (board[rp, three] == 1) 
                                {

                                    if (board[rp, four] == 1) 
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;
                                        
                                        p2turn=false;

                                        turn = 0;

                                        resetboard(board);

                                    }
                                
                                }
                            
                            }

                        }
                    
                    }

                    if (rp <= 5)
                    {

                        if (tempcolumn > 2)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn - 3;

                            if (board[rp, two] == 1)
                            {

                                if (board[rp, three] == 1)
                                {

                                    if (board[rp, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp <= 5)
                    {

                        if (tempcolumn > 0 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn + 1;

                            four = tempcolumn + 2;

                            if (board[rp, two] == 1)
                            {

                                if (board[rp, three] == 1)
                                {

                                    if (board[rp, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp <= 5)
                    {

                        if (tempcolumn > 2 && tempcolumn < 6)
                        {

                            two = tempcolumn - 2;

                            three = tempcolumn - 1;

                            four = tempcolumn + 1;

                            if (board[rp, two] == 1)
                            {

                                if (board[rp, three] == 1)
                                {

                                    if (board[rp, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    /*diagonals bottom left top right*/

                    if (rp > 2)
                    {

                        if (tempcolumn < 4)
                        {

                            two = tempcolumn + 1;

                            three = tempcolumn + 2;

                            four = tempcolumn + 3;

                            twov = rp - 1;

                            threev = rp - 2;

                            fourv = rp - 3;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 3)
                    {

                        if (tempcolumn > 2)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn - 3;

                            twov = rp + 1;

                            threev = rp + 2;

                            fourv = rp + 3;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 5 && rp > 1)
                    {

                        if (tempcolumn > 0 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn + 1;

                            four = tempcolumn + 2;

                            twov = rp + 1;

                            threev = rp - 1;

                            fourv = rp - 2;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 4 && rp > 0)
                    {

                        if (tempcolumn > 1 && tempcolumn < 6)
                        {

                            two = tempcolumn - 2;

                            three = tempcolumn - 1;

                            four = tempcolumn + 1;

                            twov= rp + 2;

                            threev= rp + 1;

                            fourv= rp - 1;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    /*diagonals top left bottom right*/

                    if (rp < 3)
                    {

                        if (tempcolumn < 4)
                        {

                            two = tempcolumn + 1;

                            three = tempcolumn + 2;

                            four = tempcolumn + 3;

                            twov = rp + 1;

                            threev = rp + 2;

                            fourv = rp + 3;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp > 2)
                    {

                        if (tempcolumn > 2)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn - 3;

                            twov = rp - 1;

                            threev = rp - 2;

                            fourv = rp - 3;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 4 && rp > 0)
                    {

                        if (tempcolumn > 0 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn + 1;

                            four = tempcolumn + 2;

                            twov = rp - 1;

                            threev = rp + 1;

                            fourv = rp + 2;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 5 && rp > 1)
                    {

                        if (tempcolumn > 1 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn + 1;

                            twov = rp - 1;

                            threev = rp - 2;

                            fourv = rp + 1;

                            if (board[twov, two] == 1)
                            {

                                if (board[threev, three] == 1)
                                {

                                    if (board[fourv, four] == 1)
                                    {

                                        Console.WriteLine("Player 1 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    /*vertical*/

                    if (rp < 3) 
                    {

                        twov = rp + 1;

                        threev = rp + 2;

                        fourv = rp + 3;

                        if (board[twov, tempcolumn] == 1)
                        {

                            if (board[threev, tempcolumn] == 1)
                            {

                                if (board[fourv, tempcolumn] == 1)
                                {

                                    Console.WriteLine("Player 1 Wins");

                                    Console.WriteLine("Resetting Board");

                                    p1turn = true;

                                    p2turn = false;

                                    turn = 0;

                                    resetboard(board);

                                }

                            }

                        }

                    }

                }

                while (p2turn == true)
                {

                    printboard(board);

                    Console.WriteLine("");

                    Console.WriteLine("Enter Which Column You Want To Place Your Piece In, Player 2");

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

                                        if (board[0, tempcolumn] != 0)
                                        {

                                            Console.WriteLine("Invalid Choice Please Choose Again");

                                            Console.WriteLine("");

                                            p2turn = true;

                                        }
                                        else
                                        {

                                            p1turn = true;

                                            p2turn = false;

                                            board[0, tempcolumn] = 2;

                                            rp = 0;

                                        }

                                    }
                                    else 
                                    { 

                                    p1turn = true;

                                    p2turn = false;

                                    board[1, tempcolumn] = 2;

                                        rp = 1;

                                    }
                                }
                                else
                                {

                                p1turn = true;

                                p2turn = false;

                                board[2, tempcolumn] = 2;

                                    rp = 2;

                                }
                            }
                            else 
                            { 

                            p1turn = true;

                            p2turn = false;

                            board[3, tempcolumn] = 2;

                                rp = 3;

                            }
                        }
                        else
                        { 

                        p1turn = true;

                        p2turn = false;

                        board[4, tempcolumn] = 2;

                            rp = 4;

                        }
                    }
                    else
                    {

                        p1turn = true;

                        p2turn = false;

                        board[5, tempcolumn] = 2;

                        rp = 5;

                    }

                    /*horizontals*/

                    if (rp <= 5)
                    {

                        if (tempcolumn < 4)
                        {

                            two = tempcolumn + 1;

                            three = tempcolumn + 2;

                            four = tempcolumn + 3;

                            if (board[rp, two] == 2)
                            {

                                if (board[rp, three] == 2)
                                {

                                    if (board[rp, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp <= 5)
                    {

                        if (tempcolumn > 2)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn - 3;

                            if (board[rp, two] == 2)
                            {

                                if (board[rp, three] == 2)
                                {

                                    if (board[rp, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp <= 5)
                    {

                        if (tempcolumn > 0 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn + 1;

                            four = tempcolumn + 2;

                            if (board[rp, two] == 2)
                            {

                                if (board[rp, three] == 2)
                                {

                                    if (board[rp, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp <= 5)
                    {

                        if (tempcolumn > 2 && tempcolumn < 6)
                        {

                            two = tempcolumn - 2;

                            three = tempcolumn - 1;

                            four = tempcolumn + 1;

                            if (board[rp, two] == 2)
                            {

                                if (board[rp, three] == 2)
                                {

                                    if (board[rp, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    /*diagonals bottom left top right*/

                    if (rp > 2)
                    {

                        if (tempcolumn < 4)
                        {

                            two = tempcolumn + 1;

                            three = tempcolumn + 2;

                            four = tempcolumn + 3;

                            twov = rp - 1;

                            threev = rp - 2;

                            fourv = rp - 3;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 3)
                    {

                        if (tempcolumn > 2)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn - 3;

                            twov = rp + 1;

                            threev = rp + 2;

                            fourv = rp + 3;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 5 && rp > 1)
                    {

                        if (tempcolumn > 0 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn + 1;

                            four = tempcolumn + 2;

                            twov = rp + 1;

                            threev = rp - 1;

                            fourv = rp - 2;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 4 && rp > 0)
                    {

                        if (tempcolumn > 1 && tempcolumn < 6)
                        {

                            two = tempcolumn - 2;

                            three = tempcolumn - 1;

                            four = tempcolumn + 1;

                            twov = rp + 2;

                            threev = rp + 1;

                            fourv = rp - 1;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    /*diagonals top left bottom right*/

                    if (rp < 3)
                    {

                        if (tempcolumn < 4)
                        {

                            two = tempcolumn + 1;

                            three = tempcolumn + 2;

                            four = tempcolumn + 3;

                            twov = rp + 1;

                            threev = rp + 2;

                            fourv = rp + 3;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp > 2)
                    {

                        if (tempcolumn > 2)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn - 3;

                            twov = rp - 1;

                            threev = rp - 2;

                            fourv = rp - 3;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 4 && rp > 0)
                    {

                        if (tempcolumn > 0 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn + 1;

                            four = tempcolumn + 2;

                            twov = rp - 1;

                            threev = rp + 1;

                            fourv = rp + 2;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    if (rp < 5 && rp > 1)
                    {

                        if (tempcolumn > 1 && tempcolumn < 5)
                        {

                            two = tempcolumn - 1;

                            three = tempcolumn - 2;

                            four = tempcolumn + 1;

                            twov = rp - 1;

                            threev = rp - 2;

                            fourv = rp + 1;

                            if (board[twov, two] == 2)
                            {

                                if (board[threev, three] == 2)
                                {

                                    if (board[fourv, four] == 2)
                                    {

                                        Console.WriteLine("Player 2 Wins");

                                        Console.WriteLine("Resetting Board");

                                        p1turn = true;

                                        p2turn = false;

                                        turn = 0;

                                        resetboard(board);

                                    }

                                }

                            }

                        }

                    }

                    /*vertical*/

                    if (rp < 3)
                    {

                        twov = rp + 1;

                        threev = rp + 2;

                        fourv = rp + 3;

                        if (board[twov, tempcolumn] == 2)
                        {

                            if (board[threev, tempcolumn] == 2)
                            {

                                if (board[fourv, tempcolumn] == 2)
                                {

                                    Console.WriteLine("Player 2 Wins");

                                    Console.WriteLine("Resetting Board");

                                    p1turn = true;

                                    p2turn = false;

                                    turn = 0;

                                    resetboard(board);

                                }

                            }

                        }

                    }

                }

                if (turn >= 21) 
                {

                    Console.WriteLine("Out Of Space");

                    Console.WriteLine("Resetting Board");

                    p1turn = true;

                    p2turn = false;

                    turn = 0;

                    resetboard(board);

                }

            }

        }
    }

}
