Console.WriteLine("Task: Exception handling");
Console.WriteLine("========================");

int[] arr = new int[5] { 101, 102, 103, 104, 105 };

try
{
    for (int i = 0; i <= 5; i++)
    {
        Console.WriteLine($"Index {i}: Value {arr[i]}");
    }
}
catch(IndexOutOfRangeException e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[ERR]: "+ e.Message.ToString());
    Console.ForegroundColor = ConsoleColor.White;
}
finally
{
    Console.WriteLine("This is finally block.");
}

Console.ReadLine();