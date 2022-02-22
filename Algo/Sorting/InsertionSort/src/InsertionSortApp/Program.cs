// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insertion Sort!");

var inputArray = new int[] { 4, 2, 6, 3, 1, 8, 5 };

Console.WriteLine($"Input Array: {String.Join(", ", inputArray)}");

Console.WriteLine($"Sorted Array: {String.Join(", ", InsertionSort(inputArray))}");
Console.ReadLine();

static int[] InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int temp = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > temp)
        {
            arr[j + 1] = arr[j];
            arr[j] = temp;
            j--;
        }
    }
    return arr;
}