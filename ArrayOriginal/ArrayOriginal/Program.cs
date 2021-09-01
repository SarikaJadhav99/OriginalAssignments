using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOriginal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array :");
            //taking the array size from user
            string X = Console.ReadLine();

            int sizeOfArray = Int32.Parse(X);
            int[] array = new int[sizeOfArray];

            //taking the array from user
            Console.WriteLine("Enter elements of array :");
            for (int i = 0; i < sizeOfArray; i++)
            {
                string str = Console.ReadLine();
                array[i] = Int32.Parse(str);

            }
            //string A = Console.ReadLine
            Console.WriteLine("Enter given elements to be searched in array :");
            int GivenElement = Int32.Parse(Console.ReadLine());

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == GivenElement)
                {
                    Console.WriteLine($"The given element is {GivenElement} and is in {j + 1} position");
                }
            }
            Console.ReadLine();
        }
    }
}
