using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPrimes
{
    class RecursivePermutations
    {
        /*
         * This class will find all the permutatinos of a given set of numbers
         * using a recursive algorithm
         * */
        private int elementLevel = -1;
        private int numberOfElements;
        private int[] permutationValue = new int[0];
        public List<int> listOfPermutations = new List<int>();

        private int inputNumber;
        public int InputNumber
        {
            get { return inputNumber; }
            set { inputNumber = value; }
        }

        private char[] inputSet;
        public char[] InputSet
        {
            get { return inputSet; }
            set { inputSet = value; }
        }

        private int permutationCount = 0;
        public int PermutationCount
        {
            get { return permutationCount; }
            set { permutationCount = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        public RecursivePermutations(int number)
        {
            InputNumber = number;

            InputSet = MakeCharArray(InputNumber.ToString());
        }


        private char[] MakeCharArray(string input)
        {
            char[] charString = input.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;
            return charString;
        }

        public void CalcPermutation(int k)
        {
            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                AddToList(permutationValue);
                //OutputPermutation(permutationValue);
            }
            else
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                    {
                        CalcPermutation(i);
                    }
                }
            }
            elementLevel--;
            permutationValue.SetValue(0, k);
        }

        private void OutputPermutation(int[] value)
        {
            foreach (int i in value)
            {
                Console.Write(inputSet.GetValue(i - 1));
            }
            Console.WriteLine();
            PermutationCount++;
        }

        private void AddToList(int[] numbers)
        {
            string temp = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                temp +=  numbers[i].ToString();
            }
            listOfPermutations.Add(Convert.ToInt32(temp));
        }

        private void AddToList(int number)
        {
            listOfPermutations.Add(Convert.ToInt32(InputNumber));
        }

        public int[] ReturnPermutations()
        {
            int[] numbers = listOfPermutations.ToArray();

            return numbers;
        }
    }
}
