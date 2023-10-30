using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    abstract class InsurancePolicy1
    {
        protected string policyName;
        protected int policyId;
        protected double premimumAmount;

        protected InsurancePolicy1(string Name, int Id)
        {
            this.policyName = Name;
            this.policyId = Id;
        }
        public abstract double CalculatePremium();
        public void DisplayPolicyDetails()
        {
            Console.WriteLine("Policy Name: " + policyName);
            Console.WriteLine("Policy ID: " + policyId);
            Console.WriteLine("Premium Amount: $" +  premimumAmount);
        }
    }
}
