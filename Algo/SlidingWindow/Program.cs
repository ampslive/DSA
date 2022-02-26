// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sliding Window!");

int[] inputArr = {1, 2, 3, 4};
int k = 2;

Console.WriteLine($"Input Array: {String.Join(", ", inputArr)}");

Console.WriteLine($"Max Sum: {GetMaxSum(inputArr, k)}");
Console.WriteLine($"Array Elements: {String.Join(", ", GetMaxArray(inputArr, k))}");
Console.ReadLine();

static int GetMaxSum(int[] arr, int k)
{
    int maxSum = 0;
    int windowSum = 0;

    if(k > arr.Length)
        throw new InvalidOperationException($"{k} is greater than the array length: {arr.Length}");

    //find the sum of the first window
    for(int i=0; i<k; i++)
    {
        maxSum += arr[i];
    }

    windowSum = maxSum;

    //slide window by one index place and remove the previous element from the sum
    for(int i=k; i<arr.Length; i++)
    {
        windowSum += arr[i] - arr[i-k];

        if(windowSum > maxSum)
        {
            maxSum = windowSum;
        }
    }

    return maxSum;
}

static List<int> GetMaxArray(int[] arr, int k)
{
    var maxArr= new List<int>();
    var windowArr = new List<int>();
    int maxSum = 0;
    int windowSum = 0;

    if(k > arr.Length)
        throw new InvalidOperationException($"{k} is greater than the array length: {arr.Length}");

    //find the sum of the first window
    for(int i=0; i<k; i++)
    {
        maxArr.Add(arr[i]);
        maxSum += arr[i];
    }

    windowSum = maxSum;
    windowArr = maxArr;

    //slide window by one index place and remove the previous element from the sum
    for(int i=k; i<arr.Length; i++)
    {
        windowArr.Remove(arr[i - k]);
        windowArr.Add(arr[i]);
        windowSum += arr[i] - arr[i-k];

        if(windowSum > maxSum)
        {
            maxSum = windowSum;
            maxArr = windowArr;
        }
    }

    return maxArr;
}