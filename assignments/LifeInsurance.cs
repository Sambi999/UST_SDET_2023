using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class LifeInsurance : InsurancePolicy1
    {
        private int age;
        public LifeInsurance(string name, int id, int age) : base(name, id)
        {
            this.age = age;
            premimumAmount = CalculatePremium();
        }
        public override double CalculatePremium()
        {
            return age < 30 ? 500.0 : 800.0;
        }
    }
}
