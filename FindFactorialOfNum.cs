using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptPractice
{
    public class FindFactorialOfNum
    {
        public void FactorialOfGivenNumber(int num)
        {           
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine("factorial of given number is: " + fact);
        }
        public void FactOfGivenRange(int factnum) 
        {
            for (int i = 1; i <= factnum; i++)
             {
                  int result = 1;
                 for(int j = 1; j <= i; j++)
                  {
                      result = result * j;
                  }
                  Console.WriteLine("Num {0} fact is: {1}",i,result);
        }
    }
    }
}
