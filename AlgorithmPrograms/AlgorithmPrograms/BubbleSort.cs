using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i<arr.Length-1; i++)
            {
                for (int j = 0; j<arr.Length-1; j++)
                {
                    if (arr[j].CompareTo(arr[j+1])>0)
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
