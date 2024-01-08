using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start_1
{
    public class SecondPart
    {
        private readonly int[,] resultArray;
        //private int rows, cols;
        public SecondPart(int[,] arr2)
        {
            resultArray = arr2;
            
        }
        public SecondPart()
        {

        }
        
        //заполняет двумерный массив случайными числами
        public int[,] GenerateRandomArray(int rows, int columns)
        {
            Random random = new Random();
            int[,] resultArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    resultArray[i, j] = random.Next(-10, 20); // Генерируем  случайное число от 1 до 100
                }
            }

            return resultArray;
        }
        // метод вычисляет суммму положительных столбцов 
        public int SumOfColumnsWithNoNegatives(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            int sum = 0;

            for (int col = 0; col < columns; col++)
            {
                bool hasNegative = false;

                for (int row = 0; row < rows; row++)
                {
                    if (array[row, col] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (!hasNegative)
                {
                    for (int row = 0; row < rows; row++)
                    {
                        sum += array[row, col];
                    }
                }
            }

            return sum;
        }
        //Сумма диоганалей 

        public int MinSumOfDiagonalParallelToSecondary(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int minSum = int.MaxValue;

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                int row = 0;
                int column = col;

                while (row < rows && column < cols)
                {
                    sum += Math.Abs(matrix[row, column]);
                    row++;
                    column++;
                }

                minSum = Math.Min(minSum, sum);
            }

            for (int row = 1; row < rows; row++)
            {
                int sum = 0;
                int r = row;
                int c = 0;

                while (r < rows && c < cols)
                {
                    sum += Math.Abs(matrix[r, c]);
                    r++;
                    c++;
                }

                minSum = Math.Min(minSum, sum);
            }

            return minSum;
        }

    }
}
