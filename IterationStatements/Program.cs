using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>(0);

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var myNumber = 0;

            {
                myNumber++; //100

                numbers.Add(myNumber); //100

            
            
            
            } while (myNumber < 100);
            // Create a while loop
            // <--- While num is less than 200
            while (myNumber < 200);
            {
                // Increment num by 1
                myNumber++;
                // Then add num to the collection numbers
                numbers.Add(myNumber);
                    //HINT: copy how this was done in the do while loop

            }

            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
             foreach(var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

        
            for(int i = 199; i >= 0; i--); 
            {
              
                Console.WriteLine($"{numbers[i]}");
            }

            //------------End of exercise
        }
    }
}
