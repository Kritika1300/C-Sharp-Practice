using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Classes
{
    interface IFile
    {
        void OpenFile();
    }

    interface IBinaryFile
    {
        void OpenBinaryFile();
 
    }

    class FileInfo : IFile, IBinaryFile
    {
        public void OpenFile()
        {
            Console.WriteLine("Opening Text File");
        }

        public void OpenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");

        }
        public void Search(string text)
        {
            Console.WriteLine("Searching in File");
        }
    }

    public class Program
    {
        public static void Main()
        {
            IFile file1 = new FileInfo();
     

        }
    }




}