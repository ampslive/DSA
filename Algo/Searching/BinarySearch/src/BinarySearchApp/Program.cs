// See https://aka.ms/new-console-template for more information
var input = new int[] {1, 2, 3, 4, 5};
Console.WriteLine($"Input Array: {String.Join(", ", input)}");

int target = 7;
Console.WriteLine($"Search term: {target}");

int left = 0;
int right = input.Length - 1;

var res = BinarySearch(input, left, right, target);
Console.WriteLine($"Search Result Index {res}");

int res2 = BinarySearchRecursive(input, left, right, target);
Console.WriteLine($"Recursive: Search Result Index {res2}");
Console.ReadLine();

static int BinarySearch(int[] input, int left, int right, int target)
{
    int targetIndex = -1;
    while (left <= right)
    {
        int mid = (left + right)/2;
        
        if (input[mid] == target)
        {
            return targetIndex = mid;
        }
        else if(target < input[mid])
        {
            left = 0;
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
            right = input.Length - 1;
        }
    }
    return targetIndex;
}

static int BinarySearchRecursive(int[] input, int left, int right, int target)
{
    if (left > right)
        return -1;

    int mid = (left + right)/2;
    if (input[mid] == target)
    {
        return mid;
    }
    else if(target < input[mid])
    {
        left = 0;
        right = mid - 1;
        return BinarySearchRecursive(input, left, right, target);
    }
    else
    {
        left = mid + 1;
        right = input.Length - 1;
        return BinarySearchRecursive(input, left, right, target);
    }
}



