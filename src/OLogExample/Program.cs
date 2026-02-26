int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31 };

Console.WriteLine("=== Example 1: Binary Search (Iterative) ===");
Console.WriteLine($"Array: [{string.Join(", ", sortedArray)}]");
Console.WriteLine();

int target1 = 15;
int result1 = BinarySearchIterative(sortedArray, target1);
Console.WriteLine($"Search for {target1}: {(result1 >= 0 ? $"Found at index {result1}" : "Not found")}");
Console.WriteLine("Complexity: O(log n) - halves search space each iteration");

Console.WriteLine();

int target2 = 100;
int result2 = BinarySearchIterative(sortedArray, target2);
Console.WriteLine($"Search for {target2}: {(result2 >= 0 ? $"Found at index {result2}" : "Not found")}");

Console.WriteLine();
Console.WriteLine("=== Example 2: Binary Search (Recursive) ===");
Console.WriteLine($"Array: [{string.Join(", ", sortedArray)}]");
Console.WriteLine();

int target3 = 21;
int result3 = BinarySearchRecursive(sortedArray, target3, 0, sortedArray.Length - 1);
Console.WriteLine($"Search for {target3}: {(result3 >= 0 ? $"Found at index {result3}" : "Not found")}");
Console.WriteLine("Complexity: O(log n) - halves search space each recursive call");

Console.WriteLine();

int target4 = 8;
int result4 = BinarySearchRecursive(sortedArray, target4, 0, sortedArray.Length - 1);
Console.WriteLine($"Search for {target4}: {(result4 >= 0 ? $"Found at index {result4}" : "Not found")}");

static int BinarySearchIterative(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (array[mid] == target)
            return mid;
        else if (array[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1;
}

static int BinarySearchRecursive(int[] array, int target, int left, int right)
{
    if (left > right)
        return -1;

    int mid = left + (right - left) / 2;

    if (array[mid] == target)
        return mid;
    else if (array[mid] < target)
        return BinarySearchRecursive(array, target, mid + 1, right);
    else
        return BinarySearchRecursive(array, target, left, mid - 1);
}
