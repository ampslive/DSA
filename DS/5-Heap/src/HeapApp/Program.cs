// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------Heap App---------");

#region REPL
var inputArr = new int[] { 7, 8, 9, 10, 15, 17, 5 };
Console.WriteLine("Input Array: ");

PrintArray(inputArr);

var heap = new MaxHeap(inputArr, 7);

Console.WriteLine("Max Heap: ");

PrintArray(heap.Data);

Console.ReadLine();

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine("---");
}
#endregion

public class MaxHeap
{
    public int[] Data { get; private set; }
    public int Length { get; private set; }
    public MaxHeap(int[] data, int length)
    {
        Length = length;
        Data = data;
        CreateMaxHeap();
    }

    public void CreateMaxHeap()
    {
        for (int i = Length / 2; i >= 0; i--)
            Heapify(i);
    }

    private void Heapify(int index)
    {
        int curr = Data[index];
        int leftIndex = 2 * index + 1;
        int rightIndex = 2 * index + 2;
        int swapIndex = 0;

        if(leftIndex < Length && curr < Data[leftIndex])
        {
            curr = Data[leftIndex];
            swapIndex = leftIndex;
        }
        
        if(rightIndex < Length && curr < Data[rightIndex])
        {
            curr = Data[rightIndex];
            swapIndex = rightIndex;
        }

        if(curr != Data[index])
        {
            Swap(index, swapIndex, curr);
            Heapify(swapIndex);
        }
    }

    private void Swap(int index, int swapIndex, int newValue)
    {
        int currValue = Data[index];
        Data[index] = newValue;
        Data[swapIndex] = currValue;
        
    }


}
