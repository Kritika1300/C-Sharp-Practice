




using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Program p = new Program();

            p.OpenFacebook();
            await p.AsyncWork();
            
        }

        public void OpenFacebook()
        {
            Console.WriteLine("Welcome to Facebook");

        }

        public async Task CreatePost()
        {
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