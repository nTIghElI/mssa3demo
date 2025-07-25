// namespace XOXO_Project;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int gridSize = 8;
//         char firstChar = 'X';
//         char secondChar = 'O';

//         GetGrid(gridSize, firstChar, secondChar);
//     }

//     public static void GetGrid(int gridSize, char firstChar, char secondChar)
//     {
//         for (int row = 0; row < gridSize; row++)
//         {
//             for (int column = 0; column < gridSize; column++)
//             {
//                 // TODO: Determine which character to print
//                 if ((row+column) % 2 == 0)
//                     Console.Write($"{firstChar}");
//                 else
//                     Console.Write($"{secondChar}");
//             }
//             Console.WriteLine(); // go to next line
//         }
//     }
// }