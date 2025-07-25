using System;

namespace XOXO_Project;

class Grid
{
    static void Main(string[] args)
    {

        DrawGrid(100, '?', 'Q');

        int gridSize = 8;
        char firstChar = 'X';
        char secondChar = 'O';
    //     Console.WriteLine("Hello World!");
        //     //looping structure
        //     for (int row = 0; row < gridSize; row++)
        //     {
        //         for (int column = 0; column < gridSize; column++)
        //         {
        //             if ((row + column) % 2 == 0)
        //                 Console.Write(firstChar);
        //             else
        //                 Console.Write(secondChar);
        //         }
        //         Console.WriteLine();
        //     }
    }
    public static void DrawGrid(int gridSize, char firstChar, char secondChar)
    {
        for (int row = 0; row < gridSize; row++)
        {
            for (int column = 0; column < gridSize; column++)
            {
                if ((row ^ column) % 2 == 0)
                    Console.Write(firstChar);
                else
                    Console.Write(secondChar);
            }
            Console.WriteLine();
        }
    }
}