// See https://aka.ms/new-console-template for more information
for (int i = 2; i <= 9; i++)
{
    Console.WriteLine("{0}단", i);
    Console.WriteLine("============================");
    for (int j = 1; j <= 9; j++)
    {
        int result;
        result = i * j;
        Console.WriteLine("{0} * {1} = {2}", i, j, result);
    }
    Console.WriteLine("");
}