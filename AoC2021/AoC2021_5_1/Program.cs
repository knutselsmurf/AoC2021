var grid = new int[1000, 1000];

while (true)
{
    var input = Console.ReadLine();
    if (input == String.Empty) break;

    var p = input.Split(' ');
    var p1 = p[0].Split(',').Select(_ => int.Parse(_)).ToArray();
    var p2 = p[2].Split(',').Select(_ => int.Parse(_)).ToArray();

    if (p1[0] == p2[0])
    {
        for(int i = Math.Min(p1[1],p2[1]);i<=Math.Max(p1[1],p2[1]);i++)
        {
            grid[p1[0], i]++;
        }
    }

    if (p1[1] == p2[1])
    {
        for (int i = Math.Min(p1[0], p2[0]); i <= Math.Max(p1[0], p2[0]); i++)
        {
            grid[i,p1[1]]++;
        }
    }
}

var count = 0;
foreach (var cell  in grid)
{
    if (cell > 1) count++;
}

Console.WriteLine();
Console.WriteLine(count);   
