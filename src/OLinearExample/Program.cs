int[] numbers = { 10, 25, 30, 45, 50, 60, 70, 80, 90, 100 };

int largest = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }
}

Console.WriteLine("=== Example 1: Finding the largest element ===");
Console.WriteLine($"Array: [{string.Join(", ", numbers)}]");
Console.WriteLine($"Largest element: {largest}");
Console.WriteLine("Complexity: O(n) - Must iterate through all elements");

Console.WriteLine();

int[] numbersToSum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = 0;
for (int i = 0; i < numbersToSum.Length; i++)
{
    sum += numbersToSum[i];
}

Console.WriteLine("=== Example 2: Summing all elements ===");
Console.WriteLine($"Array: [{string.Join(", ", numbersToSum)}]");
Console.WriteLine($"Sum: {sum}");
Console.WriteLine("Complexity: O(n) - Must visit each element once");
