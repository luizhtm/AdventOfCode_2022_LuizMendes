using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022_LuizMendes
{
    public class Day2
    {
        public static void Run()
        {
            var totalScore = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }

                var splittedInput = (input ?? "").Split(" ");

                var opponentPlay = splittedInput[0];
                var myPlay = splittedInput[1];

                if (myPlay == "X")
                {
                    if (opponentPlay == "A")
                    {
                        // Scissors
                        totalScore += 3;
                    }
                    else if (opponentPlay == "B")
                    {
                        // Rock
                        totalScore += 1;
                    }
                    else
                    {
                        // Paper
                        totalScore += 2;
                    }
                }
                else if (myPlay == "Y")
                {
                    totalScore += 3;

                    if (opponentPlay == "A")
                    {
                        totalScore += 1;
                    }
                    else if (opponentPlay == "B")
                    {
                        totalScore += 2;
                    }
                    else
                    {
                        totalScore += 3;
                    }
                }
                else
                {
                    totalScore += 6;

                    if (opponentPlay == "A")
                    {
                        totalScore += 2;
                    }
                    else if (opponentPlay == "B")
                    {
                        totalScore += 3;
                    }
                    else
                    {
                        totalScore += 1;
                    }
                }
            }
            Console.WriteLine(totalScore);
        }
    }
}
