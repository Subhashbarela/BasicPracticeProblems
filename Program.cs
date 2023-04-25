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
            EligibleForAddmition eligible=new EligibleForAddmition();
            eligible.EligibleOrNot();

           Console.ReadLine();
        }
    }
}
