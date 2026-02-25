int[] numbers = { 10, 25, 30, 45, 50, 60, 70, 80, 90, 100 };

int largest = numbers[numbers.Length - 1];
int position = numbers.Length - 1;

Console.WriteLine($"Largest element: {largest}");
Console.WriteLine($"Position: {position}");
Console.WriteLine("Complexity: O(1) - Direct index access in sorted array");

Console.WriteLine();

int number = 42;
bool isEven = number % 2 == 0;

Console.WriteLine($"Number: {number}");
Console.WriteLine($"Is even? {isEven}");
Console.WriteLine("Complexity: O(1) - Constant time, independent of the number value");
