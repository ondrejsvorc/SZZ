static void InsertionSort(int[] array)
{
    int length = array.Length;

    for (int currentIndex = 1; currentIndex < length; currentIndex++)
    {
        int currentValue = array[currentIndex];
        int sortedIndex = currentIndex - 1;

        while (sortedIndex >= 0 && array[sortedIndex] > currentValue)
        {
            array[sortedIndex + 1] = array[sortedIndex];
            sortedIndex--;
        }

        array[sortedIndex + 1] = currentValue;
    }
}

int[] values = [3, 1, 4, 1, 5, 9, 2, 6];
InsertionSort(array: values);
Console.WriteLine(string.Join(", ", values));