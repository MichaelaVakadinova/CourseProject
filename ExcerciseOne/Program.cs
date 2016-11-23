using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.Write("The number is even.");
                Console.Read();
            }
            else
            {
                Console.Write("The number is odd.");
                Console.Read();
            }
        }
    }
}
