using System;
using System.Threading;
using System.Collections.Generic;

class Program
{
    const int Width = 80;
    const int Height = 25;
    static Random rand = new Random();

    static void Main(string[] args)
    {
        Console.CursorVisible = false;

        while (true)
        {
            for (int i = 0; i < 100; i++)
            {
                DrawStar(rand.Next(Width), rand.Next(Height), '*');
                Thread.Sleep(50);
                Console.Clear();
            }

            foreach (var position in GetPatternPositions())
            {
                DrawStar(position.X, position.Y, '*');
                Thread.Sleep(50);
            }

            Thread.Sleep(2000);
            Console.Clear();
        }
    }

    static void DrawStar(int x, int y, char c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }

    static IEnumerable<(int X, int Y)> GetPatternPositions()
    {
        return new List<(int X, int Y)>
        {
            (40, 12), (41, 12), (39, 12),
            (38, 13), (42, 13),
            (37, 14), (43, 14),
            (36, 15), (44, 15),
            (35, 16), (45, 16),
            (35, 17), (45, 17),
            (36, 18), (44, 18),
            (37, 19), (43, 19),
            (38, 20), (42, 20),
            (39, 21), (41, 21),
            (40, 22)
        };
    }
}
