using System;
using System.Linq;
using System.Collections.Generic;

namespace A3_1_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> rdmList = new List<int>();
            for (int x = 0; x < 5; x++)
            {
                rdmList.Add(random.Next(1, 100));
            }

            foreach(int x in rdmList)
            {
                PrimeNumbers.DisplayPrimeNumAndFactorial(x);
            }
            Console.ReadLine();

        }

        static class PrimeNumbers 
        {
            static public bool IsPrimeNumberBool(int num)
            {
                //Tests for negative number and makes it positive if it is negative
                if (num < 0)
                {
                    num = Math.Abs(num);
                }

                //Tests if number has any divisible numbers
                int counter = 0;
                List<int> list = new List<int>();
                for (int x = 2; x <= num - 1; x++)
                {
                    int prime = num % x;
                    if (prime == 0)
                    {
                        counter++;
                        list.Add(x);
                    }
                    
                }

                //If no divisible numbers then number is prime
                if (list.Count() == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            static public Dictionary<int, int> IsPrimeNumberList(int num)
            {
                //Tests for negative number and makes it positive if it is negative
                if (num < 0)
                {
                    num = Math.Abs(num);
                }

                //Tests if number has any divisible numbers
                int counter = 0;
                Dictionary<int, int> dicList = new Dictionary<int, int>();
                for (int x = 1; x <= num - 1; x++)
                {
                    int prime = num % x;
                    int multNum = num / x;
                    if (prime == 0)
                    {
                        counter++;
                        dicList.Add(x, multNum);
                    }

                }

                //If no divisible numbers then number is prime
                return dicList;

            }

            static public List<int> FindNumberFactorials (int x)
            {
                List<int> list = new List<int>();
                Dictionary<int, int> dicList = new Dictionary<int, int>();

                dicList = IsPrimeNumberList(x);
                bool dicListBool = IsPrimeNumberBool(x);
                if(dicListBool == true)
                {
                    list.Add(x);
                    return list;
                }
                else
                {
                    int val1 = dicList.ElementAt(1).Key;
                    int val2 = dicList.ElementAt(1).Value;
                    list.AddRange(FindNumberFactorials(val1));
                    list.AddRange(FindNumberFactorials(val2));
                }
                return list;
             
            }

            public static void DisplayPrimeNumAndFactorial(int x)
            {
                Console.WriteLine($"Number is: {x}");
                Console.WriteLine($"Prime: {IsPrimeNumberBool(x)}");
                Console.WriteLine($"Combinations: {String.Join(':', IsPrimeNumberList(x))}");
                Console.WriteLine($"Factorial: {String.Join(':', FindNumberFactorials(x))}");
                Console.WriteLine();
            }
           

        }

    }
}
