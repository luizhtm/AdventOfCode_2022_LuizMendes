using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022_LuizMendes
{
    public class Day1
    {
        public static void Run()
        {
            var biggestSums = new PriorityQueue<int, int>();
            var currentSum = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }

                if (input == "" || input == " ")
                {
                    biggestSums.Enqueue(currentSum, -currentSum);
                    currentSum = 0;
                }
                else
                {
                    currentSum += int.Parse(input ?? "0");
                }
            }

            var first = biggestSums.Dequeue();
            var second = biggestSums.Dequeue();
            var third = biggestSums.Dequeue();

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

            Console.WriteLine(first + second + third);
        }
    }
}
