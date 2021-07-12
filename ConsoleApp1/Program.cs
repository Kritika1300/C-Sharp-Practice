using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            
            p.OpenFacebook();
            p.AsyncWork();
            for (int i = 0; i < 20; i++)
            { 
              Console.WriteLine("Some other work");
              Thread.Sleep(100);
            }
              
            Thread.Sleep(7000);
        }

        public void OpenFacebook()
        {
            Console.WriteLine("Opening...");
           
        }

        public async Task CreatePost()
        {
            await Task.Delay(1000);
            Console.WriteLine("Creating Post...");
            await Task.Delay(5000);
            Console.WriteLine("Post Created");
        }

        public void LikePost()
        {
            Console.WriteLine("Liked");
        }

        public async Task AsyncWork()
        {
            await CreatePost();
            
            LikePost();
        }


    }
}
