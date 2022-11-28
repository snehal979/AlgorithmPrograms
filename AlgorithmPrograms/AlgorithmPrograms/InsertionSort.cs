using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 1; i<arr.Length; i++)
            {
                for (int j = 0; j<i; j++)
                {
                    if (arr[i].CompareTo(arr[j])<0)
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }

                }
            }
            foreach (var data in arr)
            {
                Console.WriteLine(data+" ");
            }
        }
    }
}
