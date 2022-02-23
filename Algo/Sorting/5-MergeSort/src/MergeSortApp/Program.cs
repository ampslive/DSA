// See https://aka.ms/new-console-template for more information
Console.WriteLine("Merge Sort!");

int[] inputArray = { 4, 2, 5, 8, 1, 7 };

Console.WriteLine($"Input array: {String.Join(", ", inputArray)}");

Console.WriteLine($"Output Array: {String.Join(", ", MergeSort(inputArray, 0, inputArray.Length - 1))}");
Console.ReadLine();

static int[] MergeSort(int[] arr, int start, int end)
{
    if (start < end)
    {
        int mid = (start + end) / 2;

        MergeSort(arr, start, mid);
        MergeSort(arr, mid + 1, end);
        Merge(arr, start, mid, end);
    }
    return arr;
}

static void Merge(int[] arr, int l, int m, int r)
{
    int n1 = m - l + 1;
    int n2 = r - m;

    // Create temp arrays
    int[] L = new int[n1];
    int[] R = new int[n2];
    int i, j;

    // Copy data to temp arrays
    for (i = 0; i < n1; ++i)
        L[i] = arr[l + i];
    for (j = 0; j < n2; ++j)
        R[j] = arr[m + 1 + j];

    // Merge the temp arrays

    // Initial indexes of first
    // and second subarrays
    i = 0;
    j = 0;

    // Initial index of merged
    // subarray array
    int k = l;
    while (i < n1 && j < n2)
    {
        if (L[i] <= R[j])
        {
            arr[k] = L[i];
            i++;
        }
        else
        {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    // Copy remaining elements
    // of L[] if any
    while (i < n1)
    {
        arr[k] = L[i];
        i++;
        k++;
    }

    // Copy remaining elements
    // of R[] if any
    while (j < n2)
    {
        arr[k] = R[j];
        j++;
        k++;
    }
}