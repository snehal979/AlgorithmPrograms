namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("AlgorithmPrograms");
            Console.WriteLine("1.binary word seraech from data");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    string filepath = "C:\\Users\\hp\\Desktop\\newFolder\\AlgorithmPrograms\\AlgorithmPrograms\\AlgorithmPrograms\\bInarysearchdata.txt";

                    BinaryWordSearch binaryWordSearch = new BinaryWordSearch();
                    binaryWordSearch.ReadFile(filepath);
                    binaryWordSearch.Display();
                    string word = Console.ReadLine();
                    binaryWordSearch.SearchWord(word);

                    break;
                    case 2:
                    GuessNumber guessNumber = new GuessNumber();
                    guessNumber.Guess();
                    break;
            }
            
        }
    }
}