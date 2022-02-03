// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------Heap App---------");

var inputArr = new int[] { 7, 8, 9, 10 };

var heap = new MaxHeap(4);

foreach (var inp in inputArr)
    heap.Add(inp);


Console.ReadLine();

public class MaxHeap
{
    public int[] Data { get; private set; }
    public int Length { get; private set; }
    public MaxHeap(int length)
    {
        Length = length;
        Data= new int[Length];
    }

    public void Add(int input)
    {
        Heapify(input);
    }

    private void Heapify(int value)
    {
        int index = 0;

        int left = GetLeftChild(index);
        int right = GetRightChild(index);

        if (Data[index] == 0)
        {
            Data[index] = value;
            return;
        }

        if(Data[index] != null)
        {
            if(left < Length && value > Data[index])
            {
                var temp = Data[index];
                Data[index] = value;
                Data[left] = temp;
            }
            else
            {
                if(Data[left] != 0)
                {
                    Data[right] = value;
                }
                Data[left] = value;
            }
        }



    }

    private int GetLeftChild(int index)
    {
        return 2 * index + 1;
    }

    private int GetRightChild(int index)
    {
        return 2 * index + 2;
    }
}
