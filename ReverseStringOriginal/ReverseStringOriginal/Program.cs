using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringOriginal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter the string
            Console.WriteLine("Welcome to CSharp corner");

            string[] str = "Welcome to CSharp corner".Split(' ');
            string ans = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                ans += str[i] + " ";
            }

            Console.WriteLine("Reveresed string is :");
            Console.Write(ans.Substring(0, ans.Length - 1));
            Console.ReadLine();S
        }
    }
}
