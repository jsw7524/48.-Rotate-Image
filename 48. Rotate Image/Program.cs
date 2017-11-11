using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48.Rotate_Image
{
    public class Solution
    {
        void Trasnpose(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }
        }

        void Mirror(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n/2; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, (n-1)-j];
                    matrix[i, (n - 1) - j] = tmp;
                }
            }
        }

        public void Rotate(int[,] matrix)
        {
            Trasnpose(matrix);
            Mirror(matrix);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
