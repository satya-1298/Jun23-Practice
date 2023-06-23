using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Positive
    {
        public void Negative()
        {
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                Console.WriteLine("It is positive");
            }
            else 
            {
                Console.WriteLine("It is negtive");
            }
        }
    }
}
