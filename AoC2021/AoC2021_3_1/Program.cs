int length = 12;

var ones = new int[length];
var zeros = new int[length];

while (true)
{
    var input = Console.ReadLine();
    
    if (input == string.Empty) break;

    for (int i = length-1; i >= 0; i--)
    {
        if (input[i] == '1') ones[length-i-1]++;
        if (input[i] == '0') zeros[length-i-1]++;

    }
}

int gamma=0;
int epsilon=0;
for (int i = length-1; i >= 0; i--)
{
    if (ones[i] > zeros[i])
        gamma += 1 << i;
    else epsilon += 1 << i;
}


Console.WriteLine();
Console.WriteLine(gamma * epsilon);




