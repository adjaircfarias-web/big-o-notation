int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

Console.WriteLine("=== Example 1: Bubble Sort ===");
Console.WriteLine($"Original array: [{string.Join(", ", numbers)}]");

int[] sorted = BubbleSort(numbers);

Console.WriteLine($"Sorted array: [{string.Join(", ", sorted)}]");
Console.WriteLine("Complexity: O(n²) - Two nested loops");

Console.WriteLine();

Console.WriteLine("=== Example 2: Find all pairs with sum ===");
int[] arr = { 1, 2, 3, 4 };
Console.WriteLine($"Array: [{string.Join(", ", arr)}]");
Console.WriteLine("Finding all pairs:");

FindAllPairs(arr);

static int[] BubbleSort(int[] array)
{
    int n = array.Length;
    int[] result = (int[])array.Clone();
    
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (result[j] > result[j + 1])
            {
                int temp = result[j];
                result[j] = result[j + 1];
                result[j + 1] = temp;
            }
        }
    }
    
    return result;
}

static void FindAllPairs(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            Console.WriteLine($"({array[i]}, {array[j]})");
        }
    }
    Console.WriteLine("Complexity: O(n²) - Compare each element with every other element");
}
