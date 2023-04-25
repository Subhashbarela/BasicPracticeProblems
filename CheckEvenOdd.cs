using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptPractice
{
    public class CheckEvenOdd
    {
        public void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter the number to check even or odd: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("  {0} is Even number: ", num);
            }
            else
            {
                Console.WriteLine("  {0} is Odd number: ", num);
                Console.ReadLine();
            }
        }
    }
}
