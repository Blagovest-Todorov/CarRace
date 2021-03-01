using System;
using System.Linq;

namespace ListsMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsTime = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            // CarOne /Left Side  of the Array-> we start from left to mid, exclusive midIndex
            int middle = numsTime.Length/2;

            double leftSumTime = 0;

            for (int i = 0; i < middle; i++)
            {
                if (numsTime[i] == 0)
                {
                    leftSumTime = leftSumTime - 0.2 * leftSumTime;
                }
                else
                {
                    leftSumTime += numsTime[i];
                }
            }

            // CarTwo //walkibng on Right side of Array/We start from right to mid, exclusive midIdx
            double rightSumTime = 0;


            for (int i = numsTime.Length - 1; i >= middle + 1; i--)
            {
                if (numsTime[i] == 0)
                {
                    rightSumTime *= 0.8;
                }
                else
                {
                    rightSumTime += numsTime[i];
                }
            }

            if (leftSumTime < rightSumTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftSumTime}");
            }
            else if (rightSumTime < leftSumTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightSumTime}");
            }
        }
    }
}
