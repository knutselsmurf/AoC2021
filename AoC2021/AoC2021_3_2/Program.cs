
using AoC2021_3_2;

int length = 12;

var lijst = new List<string>();

while (true)
{
    var input = Console.ReadLine();
    
    
    if (input == string.Empty) break;

    lijst.Add(input);   
}



var l = lijst;

for (int i = 0; i<length; i++)
{
    l = Functions.Reduce(l, i,1);
}

var ox = Functions.ToInt(l.First());

l = lijst;

for (int i = 0; i < length; i++)
{
    l = Functions.Reduce(l, i, 0);
    if (l.Count == 1) break;
}

var co2 = Functions.ToInt(l.First());

Console.WriteLine();
Console.WriteLine(ox * co2);


