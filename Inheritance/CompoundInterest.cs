﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public partial class CompoundInterest : InterestBaseClass, ICompareInterest
    {
        public int NoOfTimes { get; set; }

        public CompoundInterest(): base(0,0,0)
        {
            NoOfTimes = 0;
        }

        public CompoundInterest(
            double Principle,
            double R,
            int N,
            int NTimes) : base(Principle, R, N)
        {
            this.NoOfTimes = NTimes;
        }

        public override void Calculate()
        {
            double r = RateOfInterest / 100;
            double subCalc = (1 + r / NoOfTimes);
            subCalc = Math.Pow(subCalc, NoOfTimes * NoOfYears);
            double A = Principle * subCalc;
            InterestAmount = A - Principle;

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("No Of Times The Interest Componded : {0,10}", NoOfTimes);
            Console.WriteLine();
        }

        string ICompareInterest.Identify()
        {
            return "Compound Interest";
        }
    }
}
