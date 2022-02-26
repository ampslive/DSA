// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rainwater Trapping!");

int[] inputArr = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};

Console.WriteLine($"Input Array: {String.Join(", ", inputArr)}");

Console.WriteLine($"Output: {GetWaterStorage(inputArr)}");
Console.ReadLine();

static int GetWaterStorage(int[] arr) 
{
    var left = new int[arr.Length];
    var right = new int[arr.Length];
    int n= arr.Length;
    int res=0;

    left[0] = arr[0];

    for(int i=1; i < arr.Length; i++)
    {
        left[i] = Math.Max(arr[i], left[i-1]);
    } 

    right[n-1] = arr[n-1];

    for(int i=n-2; i >= 0; i--)
    {
        right[i] = Math.Max(arr[i], right[i+1]);
    } 

    for(int i=0; i<n;i++)
    {
        res += Math.Min(left[i],right[i]) - arr[i];
    }
    return res;
}

