using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var popNumbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evenList = new List <int>();
            var oddList = new List <int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            
            for (int i =0; i < popNumbers.Length; i++)
            {
                if (popNumbers[i] % 2 == 0)
                    
                {
                    evenList.Add(popNumbers[i]);
                }
                else
                {
                oddList.Add(popNumbers[i]);
                }
            }  

            
            foreach (var num in popNumbers)
            {
               if (num % 2 == 0)
                {
                    evenList.Add(num);  
                }

               if (num % 3 == 0)
                {
                    oddList.Add(num);   
                }
            }


                
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
          ``*/
            foreach (var num in oddList)
            {
                Console.WriteLine($"{num} is an odd number");
            }
            foreach (var evenNum in evenList)
            {
                Console.WriteLine($"{evenNum} is an even number");
            }
        
        
        
        
        
        
        }



    }
}
