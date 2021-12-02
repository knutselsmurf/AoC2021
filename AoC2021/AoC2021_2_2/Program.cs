var depth = 0;
var position = 0;
var aim = 0;

while (true)
{
    var input = Console.ReadLine();
    if (input == String.Empty) break;

    var parts = input.Split(' ');
    switch (parts[0])
    {
        case "forward":
            var x = int.Parse(parts[1]);
            position += x;
            depth += aim * x;
            break;
        case "down":
            aim += int.Parse(parts[1]);
            break;
        case "up":
            aim -= int.Parse(parts[1]);
            break;
    }
}
Console.WriteLine();
Console.WriteLine(depth * position);

