using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public class CompareInterest
    {
        public void Compare()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Comparing Interest Products...");

            Console.WriteLine("{0,-20} {1,10:0,00}", Product1.Indentify(), Product1.InterestAmount());
            Console.WriteLine();
            Console.WriteLine("{0,-20} {1,10:0,00}", Product2.Indentify(), Product2.InterestAmount());
            Console.WriteLine();

            string BestProduct = Product1.InterestAmount() > Product2.InterestAmount() ? Product1.Indentify() : Product2.Indentify();

            Console.WriteLine("{0} is  the best product", BestProduct);
        }
    }
}
