using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFizzBuzzChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Fizz = "FIZZ";
            const string Buzz = "BUZZ";

            int endCount = 15;
            int count = 1;
            int fizzNumber = 3;
            int buzzNumber = 5;

            for(count = 1; count <= endCount; count++)
            {
                

                if ((count % fizzNumber == 0) && (count % buzzNumber == 0))
                {
                    Console.WriteLine(Fizz+Buzz);
                }
                else if (count % fizzNumber == 0)
                {
                    Console.WriteLine(Fizz);
                }
                else if (count % buzzNumber == 0)
                {
                    Console.WriteLine(Buzz);
                }
                else
                  Console.WriteLine(count.ToString());
            }
            Console.ReadLine();
      
        }


    }
}
