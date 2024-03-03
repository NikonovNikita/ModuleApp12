using System;

class Program
{
    static void Main(string[] args)
    {
        var inputArray = new int[] { 9, 12, 9, 4, 17, 5, 3, 6 };

        int[] sortedArray = QuickSort(inputArray, inputArray.GetLowerBound(0), inputArray.GetUpperBound(0));
        Console.WriteLine($"Отсортированный массив: {string.Join(' ', sortedArray)}");
    }

    private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if(minIndex >= maxIndex)
            return array;

        int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);
        
        return array;
    }

    private static int GetPivotIndex(int[] array, int minIndx, int maxIndx)
    {
        int pivot = minIndx - 1;

        for(int i = minIndx; i <= maxIndx; i++)
        {
            if (array[i] < array[maxIndx])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndx]);

        return pivot;
    }

    private static void Swap(ref int leftItem, ref int  rightItem)
    {
        int temp = leftItem;

        leftItem = rightItem;

        rightItem = temp;
    }
}