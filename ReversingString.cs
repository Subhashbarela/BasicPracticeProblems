using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptPractice
{
    public class ReversingString
    {
        public void ReverseStringMethod( string str)
        {
          
            string reverse = "";

            int length = str.Length - 1;

            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            Console.WriteLine(reverse);

        }

    }
}
