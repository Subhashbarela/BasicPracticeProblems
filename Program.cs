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
            SumOfSquare square =new SumOfSquare();
           
            Console.WriteLine("Pleasr insert the number to find sum of square");
            int num = int.Parse(Console.ReadLine());
            square.SumOfSqr(num);
           Console.ReadLine();
        }
    }
}
