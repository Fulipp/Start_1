// See https://aka.ms/new-console-template for more information

using System;
using System.Drawing;
namespace Start_1
{
class Program
{
    
    static void Main(string[] args)
    {

            FirstPart test1 = new FirstPart(10);
            int max = test1.MaxElemet(); 
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент: "+ max);
            Console.WriteLine();
           
            //Пример использования 
            FirstPart test2 = new FirstPart(5);
            int maxsum = test2.SumElementPositive();
            Console.WriteLine();
            Console.WriteLine("Сумма до последнего положительного элемента: " + maxsum);
            Console.WriteLine();



            // Пример использования удаление из массива элементы, модуль которых находится в интервале [a, b] + удаление
            int[] array = { 1,2,3,4,5,6,7,8,9,10 };
            int a = 2;
            int b = 5;

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            ArrayProcessor test3 = new ArrayProcessor();
            int[] removedValues = test3.RemoveAndFillWithZeros(array, a, b);

            Console.WriteLine("Массив после удаления:");
            PrintArray(array);
            Console.WriteLine();

          

            // метод выводит однеомернный массив 
            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            //метод выводит двухмерный массив 
            static void PrintArray2(int[,] arr)
            {
                int rows = arr.GetLength(0);
                int columns = arr.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }



            //Вторая часть лабы 
            SecondPart class2 = new SecondPart();
            int[,] mas3 = class2.GenerateRandomArray(2, 2);
            Console.WriteLine("Исходный массив:");
            PrintArray2(mas3);
            //Console.WriteLine();
            
            int sumpolcolumns = class2.SumOfColumnsWithNoNegatives(mas3);
            Console.WriteLine("Сумма положительный столбцов матрицы: " + sumpolcolumns);
            Console.WriteLine();   
            
            //Второй пункт 
            SecondPart class21 = new SecondPart();
            int[,] mas4 = class2.GenerateRandomArray(3,3);
            Console.WriteLine("Исходный массив:");
            PrintArray2(mas4);
            Console.WriteLine();
            int minsummas4 = class21.MinSumOfDiagonalParallelToSecondary(mas4);
            Console.WriteLine("Сумма диоганалей:" + minsummas4);
            

        }
}
}
  


