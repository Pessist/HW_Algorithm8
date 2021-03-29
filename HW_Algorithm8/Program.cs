using System;
using System.Linq;

namespace HW_Algorithm8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 8, 12, 18, 25, 66, 150, 11, 69, 100, 35, 13, 1, 7, 3, 2, 5, 9, 4 }; //new int[10_000];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = random.Next(100);
            //}

            //Эталонный массив для теста
            int[] myTestArray = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 11, 12, 13, 18, 25, 35, 66, 69, 100, 150 };

            Console.WriteLine(String.Join(" ", myArray));
            MyBucketSort.BucketSort(myArray);
            Console.WriteLine(String.Join(" ", myArray));

            bool checkArrays = Enumerable.SequenceEqual(myArray, myTestArray);

            if (checkArrays)
            {
                Console.WriteLine("Блочная сортировка выполнена верно!");
            }
            else
            {
                Console.WriteLine("Блочная сортировка выполнена не верно!");
            }
        }
    }
}
