using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CircularPrimes
{
    class FindPrimes
    {
        /**
         * This class will determine all the prime numbers in a given range or
         *  array of integers in a presorted array from least to greatest.
         * They algorithm will test if the number is prime by dividing n by the
         * numbers 2 - sqrt(n) rounded up.
         * */

        
        private int[] range;

        private int[] primeArray;
        public int[] Primes
        {
            get { return primeArray; }
            set { primeArray = value; }
        }

        public int[] Range
        {
            get { return range; }
            set { range = value; }
        }
        private int min;
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        
        private int max;
        public int Max
        {
            get { return max; }
            set { max =  value;}
        }

        private int[] inputSet;
        public int[] InputSet
        {
            get { return inputSet; }
            set { inputSet = value; }
        }


        /// <summary>
        /// class Constructor, takes the min and lower and upper extremes of
        /// the array to be made. Then runs the CreateRange method to generate
        /// the array used by the rest of the class
        /// </summary>
        /// <param name="minimum">lower extrem of the number range</param>
        /// <param name="maximum">upper extrem of the number range</param>
        public FindPrimes(int minimum, int maximum)
        {
            Min = minimum;
            Max = maximum;

            CreateRange(minimum,maximum);
        }

        public FindPrimes(int[] numbers)
        {
            Range = numbers;
        }

        /// <summary>
        /// creates an array of ints in the given range
        /// </summary>
        /// <returns>an array with the full range of numbers being used</returns>
        private int[] CreateRange(int start,int end)
        {
            return range = Enumerable.Range(start, end + 1).ToArray();
        }

        /// <summary>
        /// prints all the numbers in the range array
        /// </summary>
        public void PrintRange()
        {
            foreach (int num in Range)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Prints all the prime numbers found in the number range to the
        /// to the console
        /// </summary>
        public void PrintPrimes()
        {
            foreach (int num in Primes)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// Determines if a number is prime adds it to a list and then converts
        /// that list to an array and sets it equal primeArray
        /// </summary>
        public void FillPrimeArray()
        {
            List<int> primeList = new List<int>();

            for(int i = 0; i < Range.Length; i++)
            {
                if (Range[i] >= 2)
                {
                    if (IsPrime(Range[i]))
                    {
                        primeList.Add(Range[i]);
                    }
                }
            }
            primeArray = primeList.ToArray();
        }


        /// <summary>
        /// Determines if a number that has more than 1 factor by checking all
        /// the numbers between 2 and square root of n-1
        /// </summary>
        /// <param name="num">the number to be checked</param>
        /// <returns>returns true if a prime number</returns>
        private bool IsPrime(int num)
        {
            int sqrtN = (int)Math.Ceiling(Math.Sqrt(num));
            int factors = 0;

            for (int i = 1; i < sqrtN; i++)
            {
                if (num % i == 0)
                {
                    factors += 2;
                }
            }

            if (sqrtN * sqrtN == num)
            {
                factors++;
            }

            if (factors <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// Returns an array of ints with all the prime numbers in a given
        /// range
        /// </summary>
        /// <returns>the public Primes array</returns>
        public int[] ReturnPrimes()
        {
            return Primes;
        }

        /// <summary>
        /// takes an array of ints and writes them to a file
        /// </summary>
        /// <param name="numbers"></param>
        public void WriteToFile(int[] numbers)
        {
            string fileName = "primes.txt";
            StreamWriter outfile = new StreamWriter(fileName);
            for (int i = 0; i < numbers.Length; i++)
            {
                outfile.WriteLine(numbers[i]);
            }
            outfile.Close();
        }
    }
}
