static void InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = key;
    }
}

int[] values = [3, 1, 4, 1, 5, 9, 2, 6];
InsertionSort(array: values);
Console.WriteLine(string.Join(", ", values));

// Idea: prefix [0..i) stays sorted; take array[i] and slide larger neighbors right
// until the gap is where "key" belongs, then write key there.
//
// Time complexity:
//   best:  O(n)   when each key is already ≥ everything to its left (inner while never runs)
//   worst: O(n²) reverse-sorted — each i shifts i elements
//
// Space: O(1) extra (in-place shifts).