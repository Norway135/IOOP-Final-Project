using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_Four
{
    
    class Board 
    {

        private const int row = 6;

        private const int col = 7;

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] board = new int[6,7];

            for (int j = 0; j < board.GetLength(0); j++)
            {

                for (int i = 0; i < board.GetLength(1); i++)
                {

                    Console.Write(board[0, 1]);

                    Console.Write(" ");


                }

                Console.WriteLine("");

            }
        }
    }
}
