using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visedimenzionalni_nizovi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 },
                               { 4, 5, 6 }
                             };

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for(int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j] + " ");
            //    }
            //}
            //foreach(var element in numbers)
            //{
            //    if (element % 2 == 0)
            //    {
            //        Console.Write(element + "\t");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\t");
            //    }
            //}

            int row, col;
            Console.Write("Enter num of rows: "); row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num of cols: "); col = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, col];


            //input
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Matrix [{i}][{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("-----------------");

            //output
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                    
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------");

            int sum = 0;
            int numOfElements = 0;

            //Sum of elements and num of elements
            foreach (int element in matrix)
            {
                sum+= element;
                numOfElements++;
            }

            //Max element in matrix
            int max = matrix[0, 0];
            foreach (int element in matrix) 
            { 
                if(element > max)
                {
                    max = element;  
                }
            }

            //Min element in matrix
            int min = matrix[0, 0];
            foreach (int element in matrix) 
            { 
                if(element < min)
                {
                    min = element;
                }
            }

            Console.WriteLine($"Max is: {max}");
            Console.WriteLine($"Min is: {min}");
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"Number of elements in matrix is: {numOfElements}");

            //If one quadratic matrix is equal
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                Console.WriteLine("Matrica is not square  and cannot be symmetric");
            }
            else
            {
                bool simetric = true;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != matrix[j, i])
                        {
                            simetric = false; // the matrix is not simetric
                            break;
                        }
                        if (!simetric) break;
                    }
                }

                if (simetric)
                    Console.WriteLine("Matrix is symmetric.");
                else
                    Console.WriteLine("Matrix is not symmetric");
            }

            //check if num is odd or even
            int numOdd = 0;
            int numEven = 0;
            foreach (int element in matrix)
            {
                if(element % 2 == 0)
                {
                    numEven++;
                }
                else
                {
                    numOdd++;
                }
            }

            Console.WriteLine($"Even numbers: {numEven}, odd numbers: {numOdd}");

            //changing first and last row
            for (int j = 0; j < col; j++)
            {
                int temp = matrix[0, j];
                matrix[0, j] = matrix[row - 1, j];
                matrix[row - 1, j] = temp;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
