using System;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "hi how are you this is a long long very long sentence which has to be shortened";
            string summary = StringUtility.SummarizeText(sentence, 12);
            Console.WriteLine(summary);
        }
    }

}
