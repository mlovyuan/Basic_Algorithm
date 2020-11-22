using System;

namespace Basic_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 3, 2, 1, 9, 8 };
            a.BubbleSort();
        }
    }

    public static class Algorithm
    {
        // 泡泡排序法
        public static void BubbleSort(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            array.Print();
        }

        // 選擇排序法，是泡泡排序法的進階，取代了泡泡排序法多餘的交換動作。



        private static void Print(this Array values)
        {
            foreach (var value in values)
            {
                Console.Write($"{value} ");
            }
            Console.ReadLine();
        }
    }
}
