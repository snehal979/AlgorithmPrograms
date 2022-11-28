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
                        checkAnagramNumber(sorted);

                    }

                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }
        public void checkAnagramNumber(LinkedList<int> sorted)
        {
            LinkedList<int> anagram = new LinkedList<int>();
            Console.WriteLine("checknumber is anagram or not");
            foreach (var data in sorted)
            {
                Console.WriteLine(data);

                int A = data % 10;
                int B = data/10;
                int sum = A+B;
                int sum2 = 0;
                foreach (var item in sorted)
                {

                    // Console.WriteLine("the sum  "   +sum);

                    int A2 = item % 10; //23%10 =3
                    int B2 = item/10; // 2
                    sum2 = A2+B2;
                    //Console.WriteLine(sum2);//5

                    if (sum.Equals(sum2))
                    {
                        Console.WriteLine("anagram{0}+{1} = sum{2}", data, item, sum);
                        anagram.AddFirst(data);

                    }
                    if (!sum.Equals(sum2))
                    {
                        continue;
                    }


                }

            }


        }
    }
}
