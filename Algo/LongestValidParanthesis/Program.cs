// See https://aka.ms/new-console-template for more information
Console.WriteLine("Longest Valid Parenthisis!");

string input = "()(()))))";
Console.WriteLine($"Input: {input}");

Console.WriteLine($"Output: {FindLongestParenthisis(input)}");

static int FindLongestParenthisis(string input)
{
    int res = 0;
    var brackets = new Stack<int>();

    for(int i=0; i< input.Length; i++)
    {
        if(input[i] == '(')
        {
            brackets.Push(i);
        }
        else
        {
            if(brackets.Count > 0)
            {
                brackets.Pop();
                res += 2;
            }
        }
    }
    return res;
}
