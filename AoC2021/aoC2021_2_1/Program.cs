var depth = 0;
var position = 0;

while (true)
{
    var input = Console.ReadLine();
    if (input == String.Empty) break;

    var parts = input.Split(' ');
    switch (parts[0])
    {
        case "forward":
            position+= int.Parse(parts[1]);
            break;
        case "down":
            depth +=int.Parse(parts[1]);
            break;
        case "up":
            depth -=int.Parse(parts[1]);
            break;  
    }
}
Console.WriteLine();
Console.WriteLine(depth * position);

