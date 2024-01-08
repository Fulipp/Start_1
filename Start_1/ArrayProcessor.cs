// See https://aka.ms/new-console-template for more information

namespace Start_1
{
    class ArrayProcessor
    {
        //Сжать массив, удалив из него все элементы, модуль которых находится в интервале
        //[а, b]. Освободившиеся в конце массива элементы заполнить нулями.
        public int[] RemoveAndFillWithZeros(int[] inputArray, int a, int b)
        {
            int resultLength = 0;
            int[] removedValues = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (Math.Abs(inputArray[i]) < a || Math.Abs(inputArray[i]) > b)
                {
                    removedValues[resultLength] = inputArray[i];
                    inputArray[resultLength] = inputArray[i];
                    resultLength++;
                }
            }

            // Заполняем оставшуюся часть массива нулями
            for (int i = resultLength; i < inputArray.Length; i++)
            {
                inputArray[i] = 0;
            }

            // Уменьшаем размер массива до фактической длины
            Array.Resize(ref removedValues, resultLength);

            return removedValues;
        }
    }
}
    
    
