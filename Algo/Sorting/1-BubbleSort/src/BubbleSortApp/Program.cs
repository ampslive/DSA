// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bubble Sort!");

var input = new int[] { 3, 5, 4, 8, 2, 1 };

Console.WriteLine($"Input Array: {String.Join(", ", input)}");

Console.WriteLine($"Output Array: {String.Join(", ", BubbleSort(input))}");

Console.ReadLine();

static int[] BubbleSort(int[] arr)
{
    bool isSwapped;
    for(int i=0; i < arr.Length; i++)
    {
        isSwapped = false;
        for (int j= 0; j < arr.Length - i - 1; j++)
        {
            if(arr[j] > arr[j+1])
            {
                var temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
                isSwapped = true;
            }
        }

        if (!isSwapped)
            break;
    }

    return arr;
}