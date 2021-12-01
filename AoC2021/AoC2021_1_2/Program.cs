int count = 0;

int previous = int.MaxValue;
var values=new List<int>();

while (true)
{
    var input = Console.ReadLine();
    if (input == String.Empty) break;

    values.Add(int.Parse(input));
}

var valuesArray= values.ToArray();

for (int i = 2;i < valuesArray.Length;i++)
{
    var sum = valuesArray[i]+valuesArray[i-1]+valuesArray[i-2];
    if (sum > previous) count++;
    previous = sum;
}
Console.WriteLine();
Console.WriteLine(count);
