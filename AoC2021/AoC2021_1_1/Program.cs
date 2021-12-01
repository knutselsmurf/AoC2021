int count = 0;

int previous = int.MaxValue;

while(true)
{
    var input = Console.ReadLine();
    if (input == String.Empty) break;

    var value = int.Parse(input);
    if (value > previous) count++;
    previous = value;
}

Console.WriteLine();
Console.WriteLine(count);
