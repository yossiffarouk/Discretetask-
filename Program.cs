using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int y,x;

            Console.WriteLine("Input the starting of numbers");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the ending of numbers ");
            y = int.Parse(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (n = x; n <= y; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} \t ", n);
            }
            
            
            Console.ReadKey();  
        } 
    }
    
}
