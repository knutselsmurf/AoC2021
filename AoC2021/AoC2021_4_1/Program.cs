using AoC2021_4_1;

var game = new Bingo();

game.ReadFromConsole();

foreach(var number in game.NumbersCalled)
{
    foreach(var b in game.Boards)
    {
        b.processNumber(number);    
        if(b.isWinning())
        {
            Console.WriteLine(number*b.getSumRemaing());
            Environment.Exit(0);    
        }
    }
}