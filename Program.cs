// See https://aka.ms/new-console-template for more information
// Author: James King II
// Date: July 8, 2025
// Lab name: Lab 7 - Maze 

{

    Console.WriteLine("This is a simple maze game.");
    Console.WriteLine("Use the arrow keys to move. Try to reach the * to win!");
    Console.WriteLine("Press any key to start...");
    Console.ReadKey();

    string[] mapRows = File.ReadAllLines("map.txt");
    Console.Clear();
    for (int i = 0; i < mapRows.Length; i++)
    {
        Console.WriteLine(mapRows[i]);
    }

    Console.SetCursorPosition(0, 0);
    ConsoleKey key = ConsoleKey.NoName;
    while (key != ConsoleKey.Escape)
    {
        key = Console.ReadKey(true).Key;

        int newTop = Console.CursorTop;
        int newLeft = Console.CursorLeft;

        if (key == ConsoleKey.UpArrow)
        {
            newTop = newTop - 1;
        }
        else if (key == ConsoleKey.DownArrow)
        {
            newTop = newTop + 1;
        }
        else if (key == ConsoleKey.LeftArrow)
        {
            newLeft = newLeft - 1;
        }
        else if (key == ConsoleKey.RightArrow)
        {
            newLeft = newLeft + 1;
        }

        TryMove(newTop, newLeft, mapRows);

        if (mapRows[Console.CursorTop][Console.CursorLeft] == '*')
        {
            Console.Clear();
            Console.WriteLine("You win! Great job!");
            break;
        }
    }
}

static void TryMove(int top, int left, string[] maze)
{
    if (top < 0) return;
    if (top >= maze.Length) return;

    if (left < 0) return;
    if (left >= maze[top].Length) return;

    if (maze[top][left] == '#') return;

    Console.SetCursorPosition(left, top);
}




