using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> circularPrimes = new List<int>();
            FindPrimes under100 = new FindPrimes(0, 100);
            under100.FillPrimeArray();
            int[] primesUnder100 = under100.ReturnPrimes();

            RecursivePermutations test = new RecursivePermutations(2);
            test.CalcPermutation(0);
            int[] temp = test.listOfPermutations.ToArray();

            //for (int i = 0; i < primesUnder100.Length; i++)
            //{
            //    RecursivePermutations rec = new RecursivePermutations(primesUnder100[i]);
            //    rec.CalcPermutation(0);
            //    int[] permutations = rec.ReturnPermutations();

            //    FindPrimes temp = new FindPrimes(permutations);
            //    temp.FillPrimeArray();
            //    int[] tempInts = temp.ReturnPrimes();

            //    for (int j = 0; j < tempInts.Length; j++)
            //    {
            //        circularPrimes.Add(tempInts[j]);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
