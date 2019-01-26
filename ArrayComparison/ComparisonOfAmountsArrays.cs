using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComparison
{
    class ComparisonOfAmountsArrays
    {
        private int[] array;
        public ComparisonOfAmountsArrays(int sizeArray)
        {
            array = new int[sizeArray];
        }

        public int ResultArraySum { get; set; }


        Random random = new Random();

        public void InitArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }

        public void ShowAray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }

        public int SumElAray()
        {
            int result;
            result = array.Sum();
            return result;
        }

        public static bool operator >
            (ComparisonOfAmountsArrays firstArray, ComparisonOfAmountsArrays secondArray)
        {
            return firstArray.ResultArraySum > secondArray.ResultArraySum;
        }

        public static bool operator <
            (ComparisonOfAmountsArrays firstArray, ComparisonOfAmountsArrays secondArray)
        {
            return firstArray.ResultArraySum < secondArray.ResultArraySum;
        }

        public static bool operator ==
           (ComparisonOfAmountsArrays firstArray, ComparisonOfAmountsArrays secondArray)
        {
            return firstArray.ResultArraySum == secondArray.ResultArraySum;
        }

        public static bool operator !=
          (ComparisonOfAmountsArrays firstArray, ComparisonOfAmountsArrays secondArray)
        {
            return firstArray.ResultArraySum == secondArray.ResultArraySum;
        }
    }
}
