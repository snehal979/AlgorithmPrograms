using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BinaryWordSearch
    {
        string[] array;
        public void ReadFile(string filepath)
        {
            string words = File.ReadAllText(filepath);
            array=words.Split(",");
        }

        public void Display()
        {
            foreach (var data in array)
            {
                Console.WriteLine(data);
            }
        }
        // for search word method
        public void SearchWord(string input)
        {
            foreach (var word in array)
            {
                if (word.Equals(input))
                {
                    Console.WriteLine("found that word in the list using binarry serach");
                    return;
                }

            }
            Console.WriteLine("search is not found in the first at word");
        }
    }
}
