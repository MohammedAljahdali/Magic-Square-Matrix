using System;

namespace MagicSquareMatrix
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int row = 3;
            int col = 3;
            Console.WriteLine(5 / 2);
            bool condation = true;
            do
            {
                Console.WriteLine("Enter Dimensions of the Materix (note it should be odd and Equal).");
                Console.Write("Enter Number of rows: ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Enter Number of Colm: ");
                col = int.Parse(Console.ReadLine());
                condation = row % 2 == 1 && col % 1 == 0 && row == col;
            } while (!condation);
            int[,] mat = new int[row, col];
    
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mat [i,j] = 0;
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[i, j] + "  ");
                }
                Console.WriteLine("");
            }
            mat[0, col / 2] = 1;
            for (int i = 0, j = col/2, count = 0, num = 2; count < row * col - 1;count++,num++)
            {
                int oldI = i;
                int oldJ = j;
                i--;
                j++;
                
                if (i >= row || i < 0)
                    i = row - 1;
                if (j >= col)
                    j = 0;
                if (mat[i,j] != 0)
                {
                    i = oldI + 1;
                    j = oldJ;
                }
                //Console.WriteLine("i:" + i);
                //Console.WriteLine("j:" + j);
                mat[i, j] = num;

            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //if (mat[i,j] > 9)
                    //{
                    //    Console.Write(mat[i, j] + "   ");
                    //}
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine("");
            }






        }
    }
}
