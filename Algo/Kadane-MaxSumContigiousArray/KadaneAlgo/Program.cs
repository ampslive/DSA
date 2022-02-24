// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] inputArr = { -1, -3, 8, 2, -5};

Console.WriteLine($"Input array: {String.Join(", ", inputArr)}");

Console.WriteLine($"Max Sum: {Kadane(inputArr)}");
Console.ReadLine();

static int Kadane(int[] arr)
{
    int max_sum = arr[0];
    int current_sum = 0;

    for(int i=0; i<arr.Length; i++)
    {
        current_sum = current_sum + arr[i];
        
        if(max_sum < current_sum)
        {
            max_sum = current_sum;
        }

        if(current_sum < 0)
        {
            current_sum = 0;
        }
    }
    return max_sum;
}