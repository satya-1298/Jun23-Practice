using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Largest
    {
        public void Number()
        {
            Console.WriteLine("Enter First Number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b=Convert.ToInt32(Console.ReadLine());  
            if (a<b) 
            {
                Console.WriteLine("Second Number is largest");

            }
            else

            {
                Console.WriteLine("First is Largest");
            }
        }
    }
}
