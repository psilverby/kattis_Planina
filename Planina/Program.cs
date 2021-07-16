using System;

namespace Planina
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int points = 0;
            int squares = 1;
            for (int i = 0; i < iterations; i++)
            {
                squares = squares * 2;
                int pointsInOneDimension = squares + 1;
                points = pointsInOneDimension * pointsInOneDimension;
            }

            Console.WriteLine(points);
        }
    }
}
