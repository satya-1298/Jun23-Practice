using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Palimdrom
    {
        public void Display()
        {
            int rev = 0, rem,pal;
            Console.WriteLine("Enter a Value");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                rem = a % 10;
                rev = rev * 10 + rem;
                a = a / 10;
            }
            Console.WriteLine("The reverse Number is " + rev);
            if(a==rev)
            {
                Console.WriteLine("It is palindrom");
            }
            else
            {
                Console.WriteLine("Not a palindrom");
            }
        }
    }
}
