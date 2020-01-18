using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public static class AddPrincipalExtension
    {
        public static void AddPrincipal(this CompoundInterest CI, double Amount)
        {
            CI.Principle += Amount;
        }
    }
}
