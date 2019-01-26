using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionalNumber
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static bool operator ==(Fraction fractionNumber1, Fraction fractionNumber2)
        {
            return fractionNumber1._numerator == fractionNumber2._numerator
                && fractionNumber1._denominator == fractionNumber2._denominator;
        }
        public static bool operator !=(Fraction fractionNumber1, Fraction fractionNumber2)
        {
            return fractionNumber1._numerator != fractionNumber2._numerator
                && fractionNumber1._denominator != fractionNumber2._denominator;
        }

        public void ShowFraction()
        {
            Console.Write(_numerator + "/" + _denominator);
        }

    }
}
