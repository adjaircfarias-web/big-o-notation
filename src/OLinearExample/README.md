# Big O Notation

## O(n) - Linear

Time scales **proportionally** to the input size.

- Traversing an array to find the largest element
- Summing all elements of an array

**Space:** O(n) if creating a new array; O(1) if using fixed variables

---

## Example in Code

This project contains two O(n) examples:

### Example 1: Finding the largest element in an array

```csharp
int[] numbers = { 10, 25, 30, 45, 50, 60, 70, 80, 90, 100 };

int largest = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > largest)
    {
        largest = numbers[i];
    }
}
```

We iterate through the entire array to find the largest element. The time complexity is O(n) because we must check each element once.

### Example 2: Summing all elements in an array

```csharp
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
```

We iterate through all elements to calculate the sum. The time complexity is O(n) because we must visit each element once.
