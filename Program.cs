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
            ReversingString strObj =new ReversingString();
           Console.WriteLine("Please insert the string to reverse");
            string str = Console.ReadLine();
            strObj.ReverseStringMethod(str); 
                       
           Console.ReadLine();
        }
    }
}
