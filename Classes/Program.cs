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
            DbMigrator dbmigrator = new DbMigrator(new FileLogger(@"C:\Users\Hp\Desktop\C#\C-Sharp-Practice\someFile.txt"));
            dbmigrator.Migrate();

        }
    }
}
