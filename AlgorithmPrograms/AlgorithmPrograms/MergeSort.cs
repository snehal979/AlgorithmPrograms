using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{

    public class MergeSort
    {
        static public void sortmethod(int[] arr, int leftSide, int rightSide)
        {
            int mid;
            if (rightSide > leftSide)
            {
                mid = (rightSide + leftSide) / 2;
                sortmethod(arr, leftSide, mid);
                sortmethod(arr, (mid + 1), rightSide);
                mergemethod(arr, leftSide, (mid+1), rightSide);

            }

        }
        static public void mergemethod(int[] arr, int leftSide, int mid, int rightSide)
        {
            int[] temp = new int[25]; // size declare
            int i;
            int left_end = (mid - 1);
            int num_elements = (rightSide - leftSide + 1); ;
            int tmp_pos = leftSide;




            while ((leftSide <= left_end) && (mid <= rightSide))
            {
                if (arr[leftSide] <= arr[mid])
                {
                    temp[tmp_pos++] = arr[leftSide++];
                }
                else
                {
                    temp[tmp_pos++] = arr[mid++];
                }



            }
            while (leftSide <= left_end)
            {
                temp[tmp_pos++] = arr[leftSide++];
            }

            while (mid <= rightSide)
            {
                temp[tmp_pos++] = arr[mid++];
            }

            for (i = 0; i < num_elements; i++)
            {
                arr[rightSide] = temp[rightSide];
                rightSide--;
            }

        }
    }
}

