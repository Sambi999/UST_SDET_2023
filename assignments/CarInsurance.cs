using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class CarInsurance : InsurancePolicy1
    {
        private string vehicleType;
        public CarInsurance(string name, int id, string vehicleType) : base(name, id)
        {
            this.vehicleType = vehicleType;
            premimumAmount = CalculatePremium();
        }
        public override double CalculatePremium()
        {
            return vehicleType == "Sedan" ? 1000.0 : 1500.0;
        }
    }
}
