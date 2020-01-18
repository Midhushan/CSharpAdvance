using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public class CompareInterest
    {
        public void Compare(ICompareInterest Product1, ICompareInterest Product2)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Comparing Interest Products...");

            Console.WriteLine("{0,-20} {1,10:0,00}", Product1.Identify(), Product1.InterestAmount());
            Console.WriteLine();
            Console.WriteLine("{0,-20} {1,10:0,00}", Product2.Identify(), Product2.InterestAmount());
            Console.WriteLine();

            string BestProduct = Product1.InterestAmount() > Product2.InterestAmount() ? Product1.Identify() : Product2.Identify();

            Console.WriteLine("{0} is  the best product", BestProduct);
        }
    }
}
