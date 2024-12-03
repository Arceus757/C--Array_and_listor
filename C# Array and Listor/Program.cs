internal class Program
{
    private static void Main(string[] args)
    {

        // Uppgift 1 

        // int[] numbers = new int[5];

        // Console.WriteLine("Ange 5 heltal:");

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.Write($"Tal {i + 1}: ");
        //     numbers[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Talen i omvänd ordning:");

        // for (int i = numbers.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(numbers[i]);
        // }


        // Uppgift 2
    //     int[][] arrays = new int[][]
    //     {
    //         new int[] { 1, 2, 3, 4, 5 },
    //         new int[] { 10, 20, 30, 40, 50 },
    //         new int[] { 7, 14, 21, 28, 35 }
    //     };

    //     for (int i = 0; i < arrays.Length; i++)
    //     {
    //         double average = CalculateAverage(arrays[i]);
    //         Console.WriteLine($"The average of the field {i + 1} is: {average}");
    //     }
    // }

    // private static double CalculateAverage(int[] numbers)
    // {
    //     int sum = 0;
    //     for (int i = 0; i < numbers.Length; i++)
    //     {
    //         sum += numbers[i];
    //     }
    //     return (double)sum / numbers.Length;

    // Uppgift 3
    // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //     List<int> evenNumbers = new List<int>();
    //     List<int> oddNumbers = new List<int>();

    //     foreach (int number in numbers)
    //     {
    //         if (number % 2 == 0)
    //         {
    //             evenNumbers.Add(number);
    //         }
    //         else
    //         {
    //             oddNumbers.Add(number);
    //         }
    //     }

    //     Console.WriteLine("Jämna tal:");
    //     foreach (int number in evenNumbers)
    //     {
    //         Console.WriteLine(number);
    //     }

    //     Console.WriteLine("Udda tal:");
    //     foreach (int number in oddNumbers)
    //     {
    //         Console.WriteLine(number);
    //     }

    // Uppgift 4
    //  Console.Write("Ange antalet rader: ");
    //     int rows = int.Parse(Console.ReadLine());

    //     Console.Write("Ange antalet kolumner: ");
    //     int columns = int.Parse(Console.ReadLine());

    //     int[,] multiplicationTable = new int[rows, columns];

    //     for (int i = 0; i < rows; i++)
    //     {
    //         for (int j = 0; j < columns; j++)
    //         {
    //             multiplicationTable[i, j] = (i + 1) * (j + 1);
    //         }
    //     }

    //     Console.WriteLine("Multiplikationstabell:");
    //     for (int i = 0; i < rows; i++)
    //     {
    //         for (int j = 0; j < columns; j++)
    //         {
    //             Console.Write(multiplicationTable[i, j] + "\t");
    //         }
    //         Console.WriteLine();
    //     }

    // Uppgift 5
    // int[] numbers = { 3, 5, 7, 2, 8, 6, 4, 7, 10, 1 };

    //     if (numbers.Length < 2)
    //     {
    //         Console.WriteLine("Array must contain at least two elements.");
    //         return;
    //     }

    //     int largest = int.MinValue;
    //     int secondLargest = int.MinValue;

    //     foreach (int number in numbers)
    //     {
    //         if (number > largest)
    //         {
    //             secondLargest = largest;
    //             largest = number;
    //         }
    //         else if (number > secondLargest && number != largest)
    //         {
    //             secondLargest = number;
    //         }
    //     }

    //     Console.WriteLine("The second largest number is: " + secondLargest);

    // Uppgift 6
    int[] numbers = { 3, 5, 7, 2, 8, 6, 4, 7, 10, 1 };

        BubbleSort(numbers);

        Console.WriteLine("Sorted array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    private static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                { 
                    // Swap array[j] and array[j + 1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

    }
}