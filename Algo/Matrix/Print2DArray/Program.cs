// See https://aka.ms/new-console-template for more information
Console.WriteLine("Print 2D Array!");

int[,] inputArray = {{1,2,3,4},{5,6,7,8}};

Console.WriteLine("Output of matrix:");

PrintMatrix(inputArray);
Console.ReadLine();

static void PrintMatrix(int[,] arr)
{
    int height = arr.GetLength(0);
    int width = arr.GetLength(1);
    
    for(int i=0; i < height*width; i++)
    {
        int row = i/width;
        int col = i%width;
        Console.WriteLine(arr[row,col]);
    }
}

