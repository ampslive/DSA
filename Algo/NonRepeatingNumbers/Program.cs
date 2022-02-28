// See https://aka.ms/new-console-template for more information
Console.WriteLine("Non-Repeating Numbers!");

int[] inputArray = {1, 2, 3, 2, 1, 4};

Console.WriteLine($"Input Array: {String.Join(", ", inputArray)}");

Console.WriteLine($"Non Repeating numbers... {String.Join(", ", GetNonRepeat(inputArray))}");

static int[] GetNonRepeat(int[] arr)
{
    var res = new List<int>();
    var dict = new Dictionary<int, int>();

    for(int i=0; i < arr.Length; i++)
    {
        if(dict.ContainsKey(arr[i]))
            dict[arr[i]] += 1;
        else
            dict.Add([arr[i], 1);
    }

    foreach(var d in dict)
    {
        if(d.Value == 1)
        {
            res.Add(d.Key);
        }
    }

    return res.ToArray();
}
