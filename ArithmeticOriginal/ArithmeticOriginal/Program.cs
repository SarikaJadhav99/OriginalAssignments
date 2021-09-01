using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOriginal
{
    class Arithmetic

    {
        int additionOfTwoNumbers(int firstTerm, int secondTerm)
        {
            return firstTerm + secondTerm;
        }

        int substractionOfTwoNumbers(int firstTerm, int secondTerm)
        {
            return firstTerm - secondTerm;
        }

        int multiplitionOfTwoNumbers(int firstTerm, int secondTerm)
        {
            return firstTerm * secondTerm;
        }

        double divisionOfTwoNumbers(int firstTerm, int secondTerm)
        {
            return firstTerm / secondTerm;
        }


        static void Main(string[] args)
        {
            Arithmetic operation = new Arithmetic();
            Console.WriteLine("addition is " + operation.additionOfTwoNumbers(11, 10));
            Console.WriteLine("substraction is " + operation.substractionOfTwoNumbers(11, 10));
            Console.WriteLine("multiplication is " + operation.multiplitionOfTwoNumbers(11, 10));
            Console.WriteLine("division is " + operation.divisionOfTwoNumbers(11, 10));
            Console.ReadLine();
        }
    }
}
