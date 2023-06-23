using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Partice problems");
            while (true) 
            {
                Console.WriteLine("\n");
                Console.WriteLine("1-Even or odd");
                Console.WriteLine("2-Largest of two");
                Console.WriteLine("3-Reverse a number");
                Console.WriteLine("4-Positive or negative");
                Console.WriteLine("5-Reverse palindrom");
                Console.WriteLine("Choose the above options");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        Console.WriteLine("Even-Odd Program");
                        Even even = new Even();
                        even.Odd();
                        break;
                    case 2:
                        Console.WriteLine("Largest on two number program");
                        Largest largest = new Largest();
                        largest.Number();
                        break;
                    case 3:
                        Console.WriteLine("Reversing a number program");
                        Reverse reverse = new Reverse();
                        reverse.Num();
                        break;  
                    case 4:
                        Console.WriteLine("Positive-Negative Number");
                        Positive positive   = new Positive();
                        positive.Negative();
                        break;
                    case 5:
                        Console.WriteLine("Reverse- Palindom or not program");
                        Palimdrom palimdrom = new Palimdrom();
                        palimdrom.Display();
                        break;
                    default: 
                        Console.WriteLine("Invalid Option");
                        break;

                }
            }
        }
    }
}
