using System;

/// <summary>
/// This program demonstrates a binary search algorithm in C#.
/// Binary search is an efficient algorithm for finding an item from a sorted list of items.
/// It works by repeatedly dividing in half the portion of the list that could contain the item,
/// until you've narrowed down the possible locations to just one.
/// </summary>
class Program
{
    /// <summary>
    /// Performs a binary search on a sorted array to find the index of the target element.
    /// </summary>
    /// <param name="arr">The sorted array to search in.</param>
    /// <param name="target">The element to search for.</param>
    /// <returns>The index of the target element if found, otherwise -1.</returns>
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0; // Left boundary of the search range
        int right = arr.Length - 1; // Right boundary of the search range

        while (left <= right)
        {
            // Calculate the middle index to avoid integer overflow
            int mid = left + (right - left) / 2;

            // Check if the middle element is the target
            if (arr[mid] == target)
                return mid; // Target found, return its index

            // If target is greater, ignore left half
            if (arr[mid] < target)
                left = mid + 1;
            // If target is smaller, ignore right half
            else
                right = mid - 1;
        }

        return -1; // Target not found in the array
    }

    /// <summary>
    /// Main method to test the binary search function.
    /// </summary>
    /// <param name="args">Command line arguments (not used).</param>
    static void Main(string[] args)
    {
        // Sample sorted array
        int[] arr = { 2, 3, 4, 10, 40 };
        // Target element to search for
        int target = 10;
        // Perform binary search
        int result = BinarySearch(arr, target);
        // Output the result
        Console.WriteLine(result != -1 ? $"Element found at index {result}" : "Element not found");
    }
}