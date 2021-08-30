using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            //SelectionSort(arr);
            //BubbleSort(arr);
            RecursiveBubbleSort(arr, arr.Length);
            //InsertionSort(arr);
            //RecursiveInsertionSort(arr, arr.Length);
        }

        private static void Log(int[] arr)
        {
            var length = arr.Length;

            for (int i = 0; i < length; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }

        private static void SelectionSort(int[] arr)
        {
            Log(arr);
            var length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                // Find the minimum element in unsorted array
                var minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                // Swap the found minimum element with the first element
                var temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
                Log(arr);
            }
        }

        private static void BubbleSort(int[] arr)
        {
            Log(arr);
            var length = arr.Length;

            for (int i = 0; i < length -1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    Log(arr);
                }
            }
        }

        private static void RecursiveBubbleSort(int[] arr, int length)
        {
            if (length == 1)
                return;

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    Log(arr);
                }
            }
            length--;
            RecursiveBubbleSort(arr, length);
        }

        private static void InsertionSort(int[] arr)
        {
            //[ 64, 25, 12, 22, 11 ]
            //[ 25, 64, 12, 22, 11 ]
            //[ 12, 25, 64, 22, 11 ]
            //[ 12, 22, 25, 64, 11 ]
            //[ 11, 12, 22, 25, 64 ]
            Log(arr);
            var length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                var value = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = value;
                Log(arr);
            }
        }

        private static void RecursiveInsertionSort(int[] arr, int length)
        {
            if (length <= 1)
                return;

            // Sort first n-1 elements
            RecursiveInsertionSort(arr, length - 1);

            var value = arr[length - 1];
            var j = length - 2;

            while (j >= 0 && arr[j] > value)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = value;
            Log(arr);
        }
    }
}
