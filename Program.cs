using System;
using System.Collections.Generic;
using System.IO;

namespace BingoCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string bingoPath = Console.ReadLine();

            string[] lines = File.ReadAllLines(@bingoPath);

            List<int> usedLines = new List<int>();

            Random rng = new Random();

            int[,] bingoCard = new int[4, 4];
            int lineIndex;

            Console.WriteLine("\n");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n");

                for (int j = 0; j < 4; j++)
                {
                    do
                    {
                        lineIndex = rng.Next(lines.Length + 1);
                        bingoCard[i, j] = lineIndex;
                    }
                    while (usedLines.Contains(lineIndex));

                    usedLines.Add(lineIndex);
                    Console.Write($" {lineIndex}");
                }
            }

            Console.WriteLine("\n\n");


        }
    }
}
