int[] values = [3, 1, 4, 1, 5, 9, 2, 6];
int[] sorted = MergeSort.Sort(array: values);
Console.WriteLine(string.Join(", ", sorted));

internal static class MergeSort
{
    public static int[] Sort(int[] array)
    {
        // Base case: recursion stops on length 0 or 1 (already sorted as a trivial segment).
        if (array.Length <= 1)
        {
            return array;
        }

        int midPoint = array.Length / 2;

        int[] left = new int[midPoint];
        int[] right = array.Length % 2 == 0
            ? new int[midPoint]
            : new int[midPoint + 1];

        for (int i = 0; i < midPoint; i++)
        {
            left[i] = array[i];
        }

        int rightIndex = 0;
        for (int i = midPoint; i < array.Length; i++)
        {
            right[rightIndex] = array[i];
            rightIndex++;
        }

        left = Sort(array: left);
        right = Sort(array: right);

        return Merge(left: left, right: right);
    }

    public static int[] Merge(int[] left, int[] right)
    {
        int resultLength = left.Length + right.Length;
        int[] result = new int[resultLength];

        int indexLeft = 0;
        int indexRight = 0;
        int indexResult = 0;

        while (indexLeft < left.Length || indexRight < right.Length)
        {
            if (indexLeft < left.Length && indexRight < right.Length)
            {
                if (left[indexLeft] <= right[indexRight])
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            else if (indexLeft < left.Length)
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }
            else if (indexRight < right.Length)
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }
        }

        return result;
    }
}

// https://www.c-sharpcorner.com/blogs/a-simple-merge-sort-implementation-c-sharp
//
// Same divide-and-conquer idea as the single-buffer version, but splits into new
// left/right arrays each recursion (often easier to explain on a whiteboard).
//
// Time: still Θ(n log n).
//
// Extra space: Θ(n log n) from all the temporary subarrays across recursion levels
// (not Θ(n) like reusing one buffer of length n).
