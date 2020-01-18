using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Inheritance
{
    public class SimpleInterest : InterestBaseClass, ICompareInterest
    {
        public SimpleInterest():base(0,0,0)
        {

        }

        public SimpleInterest(double Principle, double RateOfInterest, int NoOfYears) : base(Principle, RateOfInterest, NoOfYears)
        {
        }

        public override void Calculate()
        {
            InterestAmount = Principle * RateOfInterest * NoOfYears / 100;
        }

        string ICompareInterest.Identify()
        {
            return "Simple Interest";
        }
    }
}
