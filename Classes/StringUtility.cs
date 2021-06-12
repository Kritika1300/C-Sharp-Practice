using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class StringUtility
    {
        public static string SummarizeText(string text, int len = 20)
        {
            if (text.Length < len) return text;

            var arr = text.Split(' ');
            var list = new List<string>();
            int totalWords = 0;

            foreach(var word in arr)
            {
                list.Add(word);

                totalWords += word.Length + 1;

                if(totalWords > len) break;
            }
            return String.Join(" ", list) + ".....";
        }
    }
}
