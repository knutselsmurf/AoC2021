using AoC2021_4_1;

var game = new Bingo();

game.ReadFromConsole();

var boardsRemoved = new List<Board>();

Board lastBoard= null;

foreach (var number in game.NumbersCalled)
{
    foreach(var b in game.Boards)
    {
        b.processNumber(number);    
        if(b.isWinning())
        {
            boardsRemoved.Add(b);   
        }
    }
    foreach(var board in boardsRemoved) game.Boards.Remove(board);

    if(game.Boards.Count == 1)
    {
        lastBoard = game.Boards[0];
    }

    if (game.Boards.Count == 0)
    {
        Console.WriteLine(number * lastBoard.getSumRemaing());
        Environment.Exit(0);    
    }
}