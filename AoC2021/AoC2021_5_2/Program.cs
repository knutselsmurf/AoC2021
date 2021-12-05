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
        for (int i = Math.Min(p1[1], p2[1]); i <= Math.Max(p1[1], p2[1]); i++)
        {
            grid[p1[0], i]++;
        }
    }

    else if (p1[1] == p2[1])
    {
        for (int i = Math.Min(p1[0], p2[0]); i <= Math.Max(p1[0], p2[0]); i++)
        {
            grid[i, p1[1]]++;
        }
    }
    else
    {
        if (p1[0] < p2[0])
        {
            if (p1[1] < p2[1])
            {
                for (var i = p1[0]; i <= p2[0]; i++)
                {
                    grid[i, i - p1[0] + p1[1]]++;
                }
            }
            else
            {
                for (var i = p1[0]; i <= p2[0]; i++)
                {
                    grid[i, -i + p1[0] + p1[1]]++;
                }

            }
        }
        else
        {
            if (p1[1] < p2[1])
            {
                for (var i = p2[0]; i <= p1[0]; i++)
                {
                    grid[i, -1*(i - p2[0]) + p2[1]]++;
                }
            }
            else
            {
                for (var i = p2[0]; i <= p1[0]; i++)
                {
                    grid[i, i - p2[0] + p2[1]]++;
                }

            }

        }
    }

}

Console.WriteLine();
for(var i=0;i<10;i++)
{
    for (var j=0;j<10;j++)
    {
        Console.Write(grid[j,i]);

    }
    Console.WriteLine();
}

Console.WriteLine();

var count = 0;
foreach (var cell in grid)
{
    if (cell > 1) count++;
}

Console.WriteLine();
Console.WriteLine(count);
