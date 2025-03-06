using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_0
{
    internal class FizzBuzz
    {
        public int limit; 
        public FizzBuzz(int limit) {  this.limit = limit; }

        public void solution()
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");        
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
