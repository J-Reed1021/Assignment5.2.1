namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a sentence to determine the amount of letters in the last word");
            string userSentence = Console.ReadLine();
            Console.WriteLine($"The last word has a length of {LastWordCount(userSentence)}");

        }

        static int LastWordCount (string count)
        {
            int lengthofLastWord = 0;
            for (int i = count.Length-1; i >= 0; i--)
            {
                if (count[i] == ' ')
                {
                    break;
                }
                lengthofLastWord++;
            }
            return lengthofLastWord;
        }
    }
}
