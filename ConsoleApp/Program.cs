using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DBMigrator 
    {

        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating.....");
        }

    }

    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing.......");
        }
    
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            DBMigrator db = new DBMigrator(new Logger());
            db.Migrate();

            Installer ins = new Installer(new Logger());
            ins.Install();
            
        }

    
       

    }

  

   
}