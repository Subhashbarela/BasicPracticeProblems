using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            FindFactorialOfNum fact =new FindFactorialOfNum();
           
           /* Console.WriteLine("Pleasr insert the number to find factorial");
            int num = int.Parse(Console.ReadLine());
            fact.FactorialOfGivenNumber(num); */

            Console.WriteLine("Pleasr insert the range to find factorial");
            int range = int.Parse(Console.ReadLine());
            fact.FactOfGivenRange(range);
           Console.ReadLine();
        }
    }
}
