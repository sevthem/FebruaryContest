using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		static void Main(string[] args)
		{            
            int x = 30, y = 15;
            var matrix = new int[y, x];

            for (int i = 1; i < y - 1; i++)
            {
                for (int j = 1; j < x - 1; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Write(matrix[i, j] == 0 ? ConsoleColor.Green : ConsoleColor.Yellow);
                }
                Console.Write(Environment.NewLine);
            }

            Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
        private static void Write(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(block);
        }
    }
}
