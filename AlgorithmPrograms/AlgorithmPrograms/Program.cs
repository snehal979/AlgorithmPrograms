namespace AlgorithmPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("AlgorithmPrograms");
            Console.WriteLine("1.binary word seraech from data \n 2. guessnumber \n 3.userinput check \n4.insertionSort" +
                "\n 5.bubble sort");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 5, 2, 8, 5, 7, 9, 2 };
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
                case 3:
                    UserInputCheckcs userInputCheck = new UserInputCheckcs();
                    userInputCheck.ReplaceString();
                    break;
                case 4:
                  
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort(arr);
                    break;
                case 5:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort(arr);
                    break;







            }
            
        }
    }
}