using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnaGram
    {
        public void checkAnagram(string name1, string name2)
        {
            string input1 = Test(name1);
            string input2 = Test(name2);
            if (input1.Equals(input2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
        }
        public string Test(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            return new String(arr);
        }
    }
}
