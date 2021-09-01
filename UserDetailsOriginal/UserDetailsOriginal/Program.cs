using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetailsOriginal
{
    class Program
    {
        static void Main(string[] args)
        {
			string Name, Education, birthDate, City, Date;

			Console.WriteLine("Enter the Name of user : ");
			Name = Console.ReadLine();

			Console.WriteLine("Enter the Education of user : ");
			Education = Console.ReadLine();

			Console.WriteLine("Enter Date of Birth of user : ");
			birthDate = Console.ReadLine();

			Console.WriteLine("Enter the Location of user : ");
			City = Console.ReadLine();

			Console.WriteLine("Enter Today's Date : ");
			Date = Console.ReadLine();


			Console.WriteLine("User's Details are ");
			Console.WriteLine("Name is " + Name + " ,education is " + Education + " ,Date of birth is " + birthDate + " ,I live in " + City + " and Todays's date is " + Date);

			Console.ReadLine();
		}
    }
}
