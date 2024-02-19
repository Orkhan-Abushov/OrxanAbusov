using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
namespace Calculator_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine(name + "Salam calculatora xosh gelmisen!");
            Console.WriteLine("1-ci ededi gonder gelsin");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-ci ededide gonder ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kefin hansi sade riyazi emeli istiyirse simvolu daxil ele");
            char simvol = Convert.ToChar(Console.ReadLine());
           

            if (simvol == '+') 
            {
                Console.WriteLine((c1 + c2) + " cavab");

            }else if(simvol == '-') 
            {

                Console.WriteLine((c1 - c2) + " cavab");

            }else if (simvol == '*') 
            { 

                Console.WriteLine((c1 * c2) + " cavab");

            }else if(simvol == '/') 
            { 
            Console.WriteLine((c1 / c2) + " cavab");
            }
            else
            {
                Console.WriteLine("error sehv simvol");
            }
         
       }
    }
}
