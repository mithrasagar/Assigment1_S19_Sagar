using System;

namespace Assigment1_S19_Sagar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 15;
            printPrimeNumbers(x, y);

            /* Unable to complete code--
            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            */

            /* Unable to complete code--
            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);
            */

            /* Unable to complete code--
            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3); 
            */

            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            Console.WriteLine(" ");
            Console.WriteLine("Hit any key to close the application.");
            Console.ReadKey(true);
            /* 
             
            Throughout working on the assignment, there were a variety of sections I found to be more difficult
            than first anticipated; resulting in my inability to complete them prior to the assignment deadline.
            I do believe that if I had spent more time on working with the code and running through reiterations of
            testing and writing the code, I would be able to complete all methods. The only experience I had
            prior to this assignment was in a course taken in Fall of 2017, which only provided introductory understanding
            of the C# language. Overall, I do believe this assignment provides a comprehensive review of C#, albeit
            also matching the rigor of a graduate course. It takes significant work outside of the classroom to 
            properly understand the code within this assignment, and cannot be done by relying on the in-class review alone.

            */
        } // End of main

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                Console.WriteLine("So we want to list all prime numbers between a range");
                // Prompts user to declare their x variable
                Console.WriteLine("What do you want x, your minimum, to be? ");
                    // Takes input and saves it as a string
                    string inputX = Console.ReadLine();
                    // Converts string to x var integer that will be used
                    x = int.Parse(inputX);
                // Prompts user to declare their y variable
                Console.WriteLine("Okay. What do you want y, your maximum to be? ");
                    // Takes input and saves it as a string
                    string inputY = Console.ReadLine();
                    // Converts string to y var integer that will be used
                    y = int.Parse(inputY);
                Console.WriteLine("Below are all the prime numbers between " + inputX + " and " + inputY + ".");
                    // Call isPrime method to determine prime numbers and print them
                    isPrime(x, y);

                // Insert blank line after running isPrime()
                Console.WriteLine(" ");
                Console.WriteLine("----------");
            } // End of try block

            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            } // End of catch block
        } // End of printPrimeNumbers

        private static void isPrime(int x, int y)
        {
            try
            {
                // Define integer named number, initialized with lower range x
                // Run the for loop for all 'numbers' under the max range y
                for (int number = x; number <= y; number++)
                {
                    // Create control variable and initialize with 0
                    int test = 0;

                    // For every number within the range, test to see if it is prime
                    // Prime numbers should only divisible by itself and 1
                    for (int i = 2; i <= number / 2; i++)
                    {
                        // If there is a number calculated with 
                        // no remainder then it is prime
                        if (test % i == 0)
                        {
                            // Run through the loop until we hit the upper 
                            // end of the range
                            test++;
                        }
                    }
                    // If the number is proven to be prime then 
                    // print the results in the console
                    if (test == 0 && number!= 1)
                    {
                        Console.Write(number.ToString() + " ");
                    }
                }
            } // End of try block
            catch
            {
                Console.WriteLine("Exception occurred while computing isPrime()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            }
        }

        /* public static double getSeriesResult(int n1)
        {
            try
            {
                // Unable to complete code
            } // End of try block
            catch
            {
                // Exception allows for program to be closed
                Console.WriteLine("Exception occured while computing getSeriesResult()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            } // End of catch block
            return 0;
        } // End of getSeriesResult */

        /* public static long decimalToBinary(long n2)
        {
            try
            {
                // Unable to complete code
            } // End of try block
            catch
            {
                // Exception allows for program to be closed
                Console.WriteLine("Exception occured while computing decimalToBinary()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            } // End of catch block
            return 0;
        } // End of decimalToBinary */

        /* public static long binaryToDecimal(long n)
        {
            try
            {
                // Unable to complete code
            } // End of try block
            catch
            {
                // Exception allows for program to be closed
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            } // End of catch block
            return 0;
        } // End of binaryToDecimal */

        public static void printTriangle(int n4)
        {
            try
            {
                // Declare string named triangle
                string triangle = " ";

                // Prompt user to enter the amount of lines for triangle
                Console.WriteLine("Enter the amount of lines for the triangle: ");
                string input = Console.ReadLine();
                // Parse the input and assign it to n4 variable
                n4 = int.Parse(input);

                // For each integer i until the upper limit
                // cycle through the nested loops
                for (int i = 0; i <= n4; i++)
                {
                    // Create variable t and set equal to incrementing i
                    // Insert space at ends of *'s in each line
                    for (int t = i; t < n4; t++)
                    {
                        triangle += " ";
                    }
                    // Create variable m and set equal to 0
                    // Insert * in the middle of each line to
                    // create perfect triangle
                    for (int m = 0; m < 2 * i - 1; m++)
                    {
                        triangle += "*";
                    }
                    // Insert a new line in the console application 
                    triangle += Environment.NewLine;
                }
                // Write the triangle in the application
                Console.WriteLine(triangle);
                Console.WriteLine("----------");
            } // End of try block
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            } // End of catch block
        } // End of printTriangle

        public static void computeFrequency(int[] arr)
        {
            try
            {
                Console.WriteLine("Below is the array and the frequency of each number within it:");
                Console.WriteLine(" ");
                Console.WriteLine("Number" + " Frequency");
                // Create for loop that cycles through the 
                // length of the array
                for (int i = 0; i < arr.Length; i++)
                {
                    // Initialize a count variable with 0
                    int count = 0;
                    // Initialize a c variable with 0
                    // For each number in the array
                    for (int c = 0; c < arr.Length; c++)
                    {
                        // If the number of the array matches
                        // the number of the count, increment by 1
                        // This takes a total count of each set of numbers
                        if (arr[i] == arr[c])
                        {
                            count = count + 1;
                        }
                    }
                    // Display the array
                    Console.WriteLine(arr[i] + "      " + count);
                }
            } // End of try block
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
                Console.WriteLine("Hit any key to close the application.");
                Console.ReadKey(true);
            } // End of catch block
        } // End of computeFrequency
    } // End of class
} // End of namespace
