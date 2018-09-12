using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionOfNumbers
{
    public class MathOperations
    {
        public static double DivisionOfNumbersTwo(double divinded, double divider)
        {
            if (divider == 0) throw new ArgumentException(" делитель равен нулю! ");
            return divinded / (double)divider;
        }

        public static bool IsNumber(string numberAsString, out double number)
        {
            try
            {
                number = double.Parse(numberAsString);
                return true;
            }
            catch
            {
                throw new ArgumentNullException(" Аргумент пуст или не правильное значения! ");
            }
        }

    }
}
