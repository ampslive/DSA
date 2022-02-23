// See https://aka.ms/new-console-template for more information
Console.WriteLine("Selection Sort!");

var inputArray = new int[] { 5, 3, 8, 1, 6, 2 };

Console.WriteLine($"Input Array: {String.Join(", ", inputArray)}");
Console.WriteLine($"Output Array: {String.Join(", ", SelectionSort(inputArray))}");
Console.ReadLine();

static int[] SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int min = i;

        for(int j=i+1; j < arr.Length; j++)
        {
            if(arr[j] < arr[min])
            {
                min = j;
            }
        }

        if(min != i)
        {
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
    }
    return arr;
}