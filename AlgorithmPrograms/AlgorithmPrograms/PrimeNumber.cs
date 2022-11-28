using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        LinkedList<int> sorted = new LinkedList<int>();
        public void TotalPrimeNumber(int[] arr)
        {

            int i;
            try
            {
                for (i = 0; i<=arr.Length-1; i++)
                {
                    arr[i] = i;
                    int count = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;

                        }
                    }
                    if (count == 2)
                    {
                        Console.WriteLine(i);
                        sorted.AddFirst(i);


                    }

                }
               


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
    }
}
