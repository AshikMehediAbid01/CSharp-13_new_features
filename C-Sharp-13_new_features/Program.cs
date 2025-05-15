// See https://aka.ms/new-console-template for more information
Console.WriteLine("Span");

int[] num = { 1, 2, 3, 4, 5 };

Span<int> arrayToSpan = new Span<int>(num);

Console.WriteLine("Array");
foreach (var item in num)
{
    Console.Write("{0} ", item);
}
Console.WriteLine("\nSpan");
foreach (var item in arrayToSpan)
{
    Console.Write("{0} ",item);
}
arrayToSpan[0] = 10;
Console.WriteLine("\nArray after changing span");
foreach (var item in num)
{
    Console.Write("{0} ", item);
}
