using AssemblyOne;
using System;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
         public void Print()
        {
            AssemblyTwoClassI a1 = new AssemblyTwoClassI();
            a1.id = 105;
        }
    }

}
