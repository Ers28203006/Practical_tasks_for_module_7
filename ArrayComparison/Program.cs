using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray;

            Console.WriteLine("Введите размерность массива класса");
            sizeArray = int.Parse(Console.ReadLine());

            ComparisonOfAmountsArrays firsArray = new ComparisonOfAmountsArrays(sizeArray);

            firsArray.InitArray();

            Console.WriteLine("Значения массива 1: ");
            firsArray.ShowAray();
            Console.Write("Сумма: ");
            firsArray.ResultArraySum=firsArray.SumElAray();
            Console.WriteLine(firsArray.ResultArraySum);

            Console.WriteLine();
            Console.WriteLine();


            ComparisonOfAmountsArrays secondArray = new ComparisonOfAmountsArrays(sizeArray);
            secondArray.InitArray();
            Console.WriteLine("Значения массива 2: ");
            secondArray.ShowAray();
            Console.Write("Сумма: ");
            secondArray.ResultArraySum = secondArray.SumElAray();
            Console.WriteLine(secondArray.ResultArraySum);

            Console.WriteLine();
            Console.Write("Следовательно: ");

            bool result = firsArray > secondArray;
            if (result==true)
            {
                Console.WriteLine("сумма массива класса 1 больше суммы массива 2 !!!");
            }

            else
            {
                Console.WriteLine("сумма массива класса 2 больше суммы массива 1 !!!");
            }

            Console.ReadLine();
        }
    }
}
