# Big O Notation

## What is Big O?

It is a mathematical notation that describes **how an algorithm scales** as the input size (n) grows. It does not measure direct performance, but rather **scalability**.

---

## Time Complexity vs Space Complexity

| Type | What it measures |
|------|------------------|
| **Time** | How many times the code executes (runtime) |
| **Space** | Amount of additional memory allocated |

---

## O(1) - Constant

Execution time **does not depend** on input size.

- Accessing the first element of an array
- Checking if a number is even/odd

**Space:** Constant - does not matter the input size

---

## Example in Code

This project contains two O(1) examples:

### Example 1: Finding the largest element in a sorted array

```csharp
int[] numbers = { 10, 25, 30, 45, 50, 60, 70, 80, 90, 100 };

int largest = numbers[numbers.Length - 1];
int position = numbers.Length - 1;
```

Since the array is sorted, the largest element is always at the last index. We access it directly without iterating through the array.

### Example 2: Checking if a number is even

```csharp
int number = 42;
bool isEven = number % 2 == 0;
```

A single modulo operation determines if the number is even, regardless of the number's value.
