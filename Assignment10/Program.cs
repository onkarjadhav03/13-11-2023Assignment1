using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[][]
       {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
       };

            // Print the scores of each student
            Console.WriteLine("Scores of each student:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write($"{studentScores[i][j]} ");
                }
                Console.WriteLine();
            }

            // Calculate the average score for all students combined
            double totalSum = 0;
            double totalElements = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalElements++;
                }
            }

            double averageScore = totalSum / totalElements;

            // Print the average score
            Console.WriteLine($"\nAverage score for all students combined: {averageScore:F2}");
        }
    }
}
