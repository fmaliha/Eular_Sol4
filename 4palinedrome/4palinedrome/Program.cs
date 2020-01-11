using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4palinedrome
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            int result = PProgram();
            Console.WriteLine("The largest palineedrome is {0}",result);
            Console.ReadKey();
        }

        private static int PProgram()
        {
            int num = 0;
            int maxpalinedrome = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    num = i*j;

                    if (IsPalinedrome(num) && (num > maxpalinedrome))
                    {
                        maxpalinedrome = num;
                    }


                }


            }

          
            return maxpalinedrome;
        }
    

        private static  bool IsPalinedrome(int product)
        {
            int reversed = 0;
          
            int tt = product;
            while (tt != 0)
            {
                reversed = reversed * 10;
                reversed = reversed + tt % 10;
                tt = tt / 10;

                  if (reversed == product)
                  {
                      return true;
               
                  }
                
            }


            return false;
           

        }
    }
}
