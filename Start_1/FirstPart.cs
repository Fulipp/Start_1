using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Start_1
{
    public class FirstPart
    {
        private readonly int[] array;

        public FirstPart(int[] arr)
        {
            array = arr;
        }
        public FirstPart(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            var random = new Random();

            array = new int[length];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < length; i++)

            {
                array[i] = random.Next(-10, 10);
                Console.Write(array[i] + " ");
            }


        }

        public void getMass(int[] array)
        {
            Console.WriteLine("Ваш массив");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + "\t");

        }
        //Метод находит максимальный элемент
        public int MaxElemet()
        {
            int max = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        //Метод находит сумму до ласт позитив элемента 
        public int SumElementPositive()
        {
            int sum = 0;
            bool foundPositive = false;

            for (int j = array.Length - 1; j >= 0; j--)
            {
                int num = array[j];
                if (num > 0 && !foundPositive)
                {
                    foundPositive = true;
                    sum -= num;
                }
                if (foundPositive)
                {
                    sum += num;
                }
            }
            return sum;

        }

           

    }
}



    



    

