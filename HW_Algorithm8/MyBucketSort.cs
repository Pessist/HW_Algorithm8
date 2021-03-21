using System;
using System.Collections.Generic;


namespace HW_Algorithm8
{
    class MyBucketSort
    {
        public static void BucketSort(int[] array)
        {
            // Примем, что количество корзин равно количеству элементов в массиве-источнике.
            // Тогда:
            // массив корзин
            List<int>[] bucketSort = new List<int>[array.Length];

            // каждую корзину проинициализировать
            for (int i = 0; i < bucketSort.Length; ++i)
                bucketSort[i] = new List<int>();

            // найти диапазон значений в массиве-источнике
            int minValue = array[0];
            int maxValue = array[0];

            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] < minValue)
                    minValue = array[i];
                else if (array[i] > maxValue)
                    maxValue = array[i];
            }

            //эта величина будет использоваться a.Length раз, поэтому имеет смысл её сохранить.
            double numRange = maxValue - minValue;

            for (int i = 0; i < array.Length; ++i)
            {
                // вычисление индекса корзины
                int bucketIndex = (int)Math.Floor((array[i] - minValue) / numRange * (bucketSort.Length - 1));

                // добавление элемента в соответствующую корзину
                bucketSort[bucketIndex].Add(array[i]);
            }

            // сортировка корзин методом пузырька
            for (int i = 0; i < bucketSort.Length; i++)
            {
                BubbleSortList(bucketSort[i]);
            }

            // собираем отсортированные элементы обратно в массив-источник
            int index = 0;
            for (int i = 0; i < bucketSort.Length; ++i)
            {
                for (int j = 0; j < bucketSort[i].Count; ++j)
                    array[index++] = bucketSort[i][j];
            }
        }

        //Сортировка пузырьком
        public static int[] BubbleSortList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input.ToArray();
        }
    }
}
