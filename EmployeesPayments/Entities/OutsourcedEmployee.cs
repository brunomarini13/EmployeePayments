using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeesPayments.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, 
            double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

        public override string ToString()
        {
            return Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
