using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a, b;            /* Initializing variables for starting and ending range*/
            Console.WriteLine("Enter starting range for Prime Numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending range for Prime Numbers:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PrimeNumbers Between {0} and {1} ", a, b);
            PrintPrimeNumbers(a, b);/*Calling function PrimeNumbers to execute the logic and print 
                                                                                prime numbers in between the given range */



            int num;
            double z;            /* Initailizing variable for finding the sum of the series and converting it to double */
            Console.WriteLine("\n\n Enter any number for finding the factorial series sum:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of the series of the given number {0} is :", num);
            z = GetSeriesResult(num);    /* Calling function GetSeriesResult to execute the logic and print 
                                                                the sum of the series by rounding to three decimal places  */
            Console.WriteLine(Math.Round(z, 3));



            int n4;            /* Initializing variable for thr number of lines to print the pattern*/
            Console.WriteLine("\n\n Give numbers of lines for the triangle pattern:");
            n4 = Convert.ToInt32(Console.ReadLine());
            PrintTriangle(n4);   /* Calling function to execute logic and print the pattern for the given number of lines */


            int[] arr1 = new int[100];            /* Initaializing the array */
            ComputeFrequency(arr1);            /*Calling function to execute the frequency of the elements in a given array */


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

            /* Self Reflection :
             1.Learning : Learnt more about try,catch system and user defined exceptions. Personally I followed with system 
             potential fixes immediately after typing in a function which I would have not followed in the beginning and went into trouble.
             The more errors we make in coding in the beginning(while learning) the more will get to learn about it.
             2. Learned how the program flow executes in a process and learned writing and calling functions , using for loops ,
             where and when to keep print statements.
             3.Recommendations to improve for you:Stress where the early learners could go wrong while doing programming , what are the 
             steps we need to follow for if we struck somewhere in the coding , what could be the possible scenarios/mistakes most early 
             programmers do.
             4.Time taken: Since no experience in programming , took 16 hrs. Reading and try to attempt code , execute , learned from the 
             errors and for finally finishing the assignment whole process took arround 16 hrs.
             */

        }

        public static void PrintPrimeNumbers(int x, int y) /* This function checks each number in between starting 
                                                                and ending range has no factors other than the 1 and the number itself 
                                                                and print only prime numbers. Excludes 0 and 1 which are not considered as 
                                                                Prime numbers */
        {
            try
            {
                int n = 2; int n3;
                for (int i = x; i <= y; i++)
                {
                    n3 = 0;
                    for (n = 2; n <= i / 2; n++)
                    {
                        if (i % n == 0)
                        {
                            n3++;
                            break;
                        }
                    }
                    if (n3 == 0 && i != 1 && i != 0)
                    {
                        Console.Write( + i +"," ,"{0}");

                    }

                }
               
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static int Factorial(int a) /* This function finds the factorial of a given number and returns an integer */
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static double GetSeriesResult(int n) /* This function gives the sum of the given series by calling the factorial function
                                                                                    and returns double*/
        {
            try
            {
                double j;
                double y = 0.000;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        j = -1.000;
                    }
                    else
                    {
                        j = 1.000;
                    }
                    y = y + (Factorial(i) * j / (i + 1));
                }
                return y;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static void PrintTriangle(int n) /* This function prints the triangle pattern for the given number of lines.*/
        {
            try
            {
                int i, j, m;
                j = n - 1;
                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= 3 * (n - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (m = 1; m <= i; m++)
                    {
                        Console.Write(" * ");
                    }
                    for (m = i - 1; m >= 1; m--)
                    {
                        Console.Write(" * ");
                    }
                    Console.Write("\n");
                }
                n--;
                Console.WriteLine();
                
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void ComputeFrequency(int[] arr) /* This function displays the frequency of elements in a given array */
        {
            try
            {
                int[] fr1 = new int[100];
                int n, i, j, ctr;
                Console.Write("\n\nCount the frequency of each element of an array:\n");
                Console.Write("Input the number of elements to be stored in the array :");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input {0} elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    fr1[i] = -1;
                }
                for (i = 0; i < n; i++)
                {
                    ctr = 1;
                    for (j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            ctr++;
                            fr1[j] = 0;
                        }
                    }

                    if (fr1[i] != 0)
                    {
                        fr1[i] = ctr;
                    }
                }
                Console.Write("\nThe frequency of all elements of the array : \n");
                Console.Write("Number       Frequency\n");
                for (i = 0; i < n; i++)
                {
                    if (fr1[i] != 0)
                    {
                        
                        Console.Write("{0}            {1} \n", arr[i], fr1[i]);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}

