Console.WriteLine("Quick Sort!");

int[] inputArray = { 4, 2, 5, 8, 1, 7 };

Console.WriteLine($"Input array: {String.Join(", ", inputArray)}");

Console.WriteLine($"Output Array: {String.Join(", ", QuickSort(inputArray, 0, inputArray.Length-1))}");
Console.ReadLine();

static int[] QuickSort(int[] arr, int low, int high)
{
    if(low<high)
    {
        int partition = FindPartition(arr, low, high);
        QuickSort(arr, low, partition - 1);
        QuickSort(arr, partition + 1, high);
    }
    return arr;
}

static int FindPartition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = low-1;


    for(int j=low; j < high; j++)
    {
        if(arr[j] <= pivot)
        {
            i++;
            Swap(arr, j, i);
        }
    }
    i++;
    Swap(arr, i, high);
    return i;
}

static void Swap(int[] arr, int one, int two)
{
    int temp = arr[one];
    arr[one] = arr[two];
    arr[two] = temp;
}