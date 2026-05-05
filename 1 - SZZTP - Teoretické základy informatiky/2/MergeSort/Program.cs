static void MergeSort(int[] array)
{
    int length = array.Length;

    if (length <= 1)
    {
        return;
    }

    int middleIndex = length / 2;

    int[] left = new int[middleIndex];
    int[] right = new int[length - middleIndex];

    for (int index = 0; index < middleIndex; index++)
    {
        left[index] = array[index];
    }

    for (int index = middleIndex; index < length; index++)
    {
        right[index - middleIndex] = array[index];
    }

    MergeSort(array: left);
    MergeSort(array: right);

    Merge(left: left, right: right, target: array);
}

static void Merge(int[] left, int[] right, int[] target)
{
    int leftIndex = 0;
    int rightIndex = 0;
    int targetIndex = 0;

    while (leftIndex < left.Length && rightIndex < right.Length)
    {
        if (left[leftIndex] <= right[rightIndex])
        {
            target[targetIndex] = left[leftIndex];
            leftIndex++;
        }
        else
        {
            target[targetIndex] = right[rightIndex];
            rightIndex++;
        }

        targetIndex++;
    }

    while (leftIndex < left.Length)
    {
        target[targetIndex] = left[leftIndex];
        leftIndex++;
        targetIndex++;
    }

    while (rightIndex < right.Length)
    {
        target[targetIndex] = right[rightIndex];
        rightIndex++;
        targetIndex++;
    }
}

int[] values = [3, 1, 4, 1, 5, 9, 2, 6];
int[] sorted = MergeSort(array: values);
Console.WriteLine(string.Join(", ", sorted));