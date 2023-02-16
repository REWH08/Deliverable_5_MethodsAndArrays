/*
Author: Roberto Wong Hernandez
Date: 02/16/2023
Description: C# application using methods and user input to populate a random array and sum the elements
*/

using System;

namespace ISM_4300_Fifth_Deliverable
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];

            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);

            }
            return MyArray;
        }
        
        static int sum(int[] array)
        {
            int sum = 0;

            foreach (int item in array)
            {
                sum = sum + item;
            }

            return sum;
        
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter an integer between 5 and 15: ");
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {
                    int[] Array2 = random_array(input);

                    Console.WriteLine(" ");
                    Console.WriteLine("The elements in the array are: ");
                    foreach (int element in Array2)
                    {
                        Console.WriteLine(element + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum of the elemnts in the array is: " + sum(Array2));
                }

                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Please make sure the integer is between 5 and 15");
                }
                

            }

            catch
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please enter an integer between 5 and 15");
            }
        }









        
    }
}