using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    internal class ArrayWorker
    {
        public int[] Reverse(int[] arrayNumbers)
        {
            for(int i = 0, j = 1; i < arrayNumbers.Length / 2; i++, j++)
            {
                int temp;
                temp = arrayNumbers[i];
                arrayNumbers[i] = arrayNumbers[^j];
                arrayNumbers[^j] = temp;
            }
            return arrayNumbers;

        }

        public void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
