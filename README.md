# SampleTest

This repository contains a sample C# implementation of the binary search algorithm.

## Binary Search

Binary search is an efficient algorithm for finding an item from a sorted list of items. It works by repeatedly dividing in half the portion of the list that could contain the item, until you've narrowed down the possible locations to just one.

### Usage

1. Ensure you have .NET 8.0 installed.
2. Build the project: `dotnet build`
3. Run the program: `dotnet run`

The program will search for the target element (10) in the sample array {2, 3, 4, 10, 40} and output the index if found.

### Files

- `Program.cs`: Contains the binary search implementation and main method.
- `SampleTest.csproj`: Project file for the C# console application.
