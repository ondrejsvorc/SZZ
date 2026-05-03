static void SelectionSort(int[] array)
{
    for (int sortedBoundary = 0; sortedBoundary < array.Length - 1; sortedBoundary++)
    {
        int minIndex = sortedBoundary;

        for (int j = sortedBoundary + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }

        if (minIndex != sortedBoundary)
        {
            (array[sortedBoundary], array[minIndex]) = (array[minIndex], array[sortedBoundary]);
        }
    }
}

int[] values = [3, 1, 4, 1, 5, 9, 2, 6];
SelectionSort(array: values);
Console.WriteLine(string.Join(", ", values));

// Idea: left part [0..sortedBoundary) is already sorted; each pass picks
// the smallest element in [sortedBoundary..Length) and swaps it to sortedBoundary.
//
// Time complexity:
//   comparisons: (n-1) + (n-2) + ... + 1 = n(n-1)/2  =>  Θ(n²) always
//   swaps: at most n-1  =>  O(n) worst case
//
// Space: O(1) extra (in-place), input still Θ(n) for the array itself.