using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{


    class Test
    {
        static void Main(string[] args)
        {
            DbMigrator db = new DbMigrator(new FileLogger());
            db.Migrate();

            Installer ins = new Installer(new FileLogger());
            ins.Install();
            

        }

    }

    interface ILogger
    {
        public void Log(string message);
    }
    class ConsoleLogger  : ILogger
    { 
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (var sw = new StreamWriter(@"D:\Persnal\C#\C-Sharp-Practice\ConsoleApp\Test.txt", true))
            {
                sw.WriteLine(message);
            }
        }
    }
    class DbMigrator
    {
        private readonly ILogger _logger;
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("Migrating....");
        }
    }

    class Installer 
    {
        private readonly ILogger _logger;
        public Installer(ILogger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("Installing....");
        }
    }



}





