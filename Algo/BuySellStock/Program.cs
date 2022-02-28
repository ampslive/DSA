// See https://aka.ms/new-console-template for more information
Console.WriteLine("Buy and Sell Stocks!");

int[] inputArray = {2,4,3,3,1,7};
Console.WriteLine($"Stock Prices (day-wise): {String.Join(", ", inputArray)}");

Console.WriteLine($"Max Profit: {CalculateProfit(inputArray)}");

/// <summary>
/// For each day wise price, add to an existing profit variable when there is difference in price between currentDay and currentDay-1
/// </summary>
static int CalculateProfit(int[] arr)
{
    int profit = 0;

    for(int i=1; i<arr.Length; i++)
    {
        if(arr[i] > arr[i-1])
        {
            profit += (arr[i] - arr[i-1]);
        }
    }

    return profit;
}

