using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
       protected internal int id = 101;
    }

    public class AssemblyOneClassII
    {
        public void sampleMethod()
        {
            AssemblyOneClassI a = new AssemblyOneClassI();
            a.id = 102;
        }
       
    }
}
