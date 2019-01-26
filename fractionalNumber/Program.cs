using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Сравнение дробей*/
            Console.WriteLine("         Сравнение дробей");
            int numerator;
            int denominator;

            Console.Write("Введите числитель дроби 1: ");
            numerator = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель дроби 1: ");
            denominator = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Fraction fractionA = new Fraction(numerator, denominator);


            Console.Write("Введите числитель дроби 2: ");
            numerator = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель дроби 2: ");
            denominator = int.Parse(Console.ReadLine());

            Fraction fractionB = new Fraction(numerator, denominator);
            Console.WriteLine();

            System.Console.Clear();

            Console.WriteLine("         Сравнение дробей");

            Console.WriteLine("Оператор '==': ");

            bool result = fractionA == fractionB;
            if (result == true)
            {
                Console.Write("Утверждение ");
                fractionA.ShowFraction();
                Console.Write(" равно ");
                fractionB.ShowFraction();
                Console.WriteLine(" верно! ");
            }
            else
            {
                Console.Write("Утверждение ");
                fractionA.ShowFraction();
                Console.Write(" равно ");
                fractionB.ShowFraction();
                Console.WriteLine(" не верно! ");
            }

            /*-----------------------------------*/
            Console.WriteLine();

            Console.WriteLine("Оператор '!=': ");

            result = fractionA != fractionB;
            if (result != true)
            {
                Console.Write("Утверждение ");
                fractionA.ShowFraction();
                Console.Write(" не равно ");
                fractionB.ShowFraction();
                Console.WriteLine(" верно! ");
            }
            else
            {
                Console.Write("Утверждение ");
                fractionA.ShowFraction();
                Console.Write(" не равно ");
                fractionB.ShowFraction();
                Console.WriteLine(" не верно! ");
            }

            Console.ReadLine();
        }
    }
}
