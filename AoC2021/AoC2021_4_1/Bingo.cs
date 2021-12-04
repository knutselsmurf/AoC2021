using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021_4_1
{
    public class Bingo
    {
        public List<int> NumbersCalled = new List<int>();
        public List<Board> Boards = new List<Board>(); 

        public void ReadFromConsole()
        {
            readNumbersCalled();

            while (true)
            {
                var board = Board.ReadFromConsole();
                if (board == null) break;
                Boards.Add(board);
            }

            Console.WriteLine();
            Console.WriteLine(Boards.Count);    
        }

        private void readNumbersCalled()
        {
            string input=Console.ReadLine();
            NumbersCalled = input.Split(',').Select(x => int.Parse(x)).ToList();
        }

    }

    public  class Board
    {
        private int? [,] cells = new int?[5,5];
        public static Board? ReadFromConsole()
        {
            var lines = new string[5];
            Console.ReadLine();
            for (int i = 0; i < lines.Length; i++)
            {
                var x = Console.ReadLine(); if (x == String.Empty) return null;
                lines[i] = x;
            }
            var b = new Board(); 
            for (int i = 0;i < lines.Length; i++)
            {
                var a = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(q => int.Parse(q)).ToArray();
                for (int j=0;j<a.Count(); j++) b.cells[i,j]= a[j];  
            }
            return b;
        }

        public void processNumber(int number)
        {
            for (var i = 0; i < 5; i++)
                for (var j = 0; j < 5; j++)
                    if (cells[i, j] == number) cells[i, j] = null;
        }

        public bool isWinning()
        {
            for (var i = 0; i < 5; i++)
            {
                var emptyrow = true;
                for (var j = 0; j < 5; j++)
                    if (cells[i, j] != null) emptyrow = false;
                if (emptyrow) return true; 
            }

            for (var i = 0; i < 5; i++)
            {
                var emptycolumn = true;
                for (var j = 0; j < 5; j++)
                    if (cells[j, i] != null) emptycolumn = false;
                if (emptycolumn) return true;
            }
            return false;
        }

        internal int getSumRemaing()
        {
            var result = 0;
            foreach (var cell in cells) { if (cell != null) result += cell.Value; };
            return result;
        }
    }
}
