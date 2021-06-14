using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class Program
    {
       public static void Main()
        {
            DbMigrator dbmigrator = new DbMigrator(new Logger());
            Installer installer = new Installer(new Logger());
            dbmigrator.Migrate();
            installer.Install();
        }
    }
}
