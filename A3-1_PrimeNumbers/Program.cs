using System;
using System.Linq;
using System.Collections.Generic;

namespace A3_1_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = -9;
            int int2 = 78;
            int int3 = -23;
            int int4 = 587;

            Console.WriteLine(String.Join(':', PrimeNumbers.IsPrimeNumberList(int1)));
            Console.WriteLine(String.Join(':', PrimeNumbers.IsPrimeNumberList(int2)));
            Console.WriteLine(String.Join(':', PrimeNumbers.IsPrimeNumberList(int3)));
            Console.WriteLine(String.Join(':', PrimeNumbers.IsPrimeNumberList(int4)));

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

            static public Dictionary<int, int> DisplayPrimeNumberFactorials(int num)
            {
                bool isPrimeNumberBool = IsPrimeNumberBool(num);
                Dictionary<int, int> dicList = new Dictionary<int, int>();

                if (isPrimeNumberBool == true)
                {
                    Console.WriteLine(String.Join(',', dicList));
                }
                else if (isPrimeNumberBool == false)
                {
                    dicList = IsPrimeNumberList(num);
                    
                }
            }

            static public Dictionary<int, int> FindNumberFactorials(int num)
            {
                Dictionary<int, int> dicList = new Dictionary<int, int>();
                dicList = IsPrimeNumberList(num);


            }

            private List<int> FindNum (int x)
            {
                List<int> list = new List<int>();
                Dictionary<int, int> dicList = new Dictionary<int, int>();

                dicList = IsPrimeNumberList(x);
                if(dicList.Count == 0)
                {
                    list.Add(x);
                    return list;
                }
                else
                {
                    foreach (int y in dicList.Keys)
                    {

                    }
                }
             
            }
           

        }

    }
}
