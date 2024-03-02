using System;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

        int lowerBound = numbers.GetLowerBound(0);
        int upperBound = numbers.GetUpperBound(0);

        Console.Write("Введите число от 1 до 15 --> ");
        int.TryParse(Console.ReadLine(), out int input);
        
        var result = BinarySearch(input, numbers, lowerBound, upperBound);

        Console.WriteLine($"Индекс запрошенного элемента: { result}");
    }

    static int BinarySearch(int desiredElement, int[] array, int lowerBound, int upperBound)
    {
        var middle = (lowerBound + upperBound) / 2;

        if (array[middle] == desiredElement)
            return middle;

        if(lowerBound < upperBound)
        {
            if (desiredElement < array[middle])
                return BinarySearch(desiredElement, array, lowerBound, middle - 1);

            return BinarySearch(desiredElement, array, middle + 1, upperBound);
        }

        return -1;
            


    }
}