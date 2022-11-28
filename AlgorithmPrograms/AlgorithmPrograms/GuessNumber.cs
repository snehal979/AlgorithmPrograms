using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class GuessNumber
    {
        public void Guess()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            string result;
            Console.WriteLine("enter the upper and lower range");
            int lowerRange = Convert.ToInt32(Console.ReadLine());
            int UpperRang = Convert.ToInt32(Console.ReadLine());

            if (n > lowerRange && n<= UpperRang)
            {
                Console.WriteLine("Give true/false");
                result = Console.ReadLine();
                UpperRang = UpperRang/2;
                Guess();
            }
            else
            {
                Console.WriteLine("Give true/false");
                result = Console.ReadLine();
            }



        }
    }
}
