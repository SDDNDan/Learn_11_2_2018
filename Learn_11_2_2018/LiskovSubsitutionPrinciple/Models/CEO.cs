using System;

namespace LiskovSubstitutionPrincipleBad.Models
{
    public class CEO : Employee
    {
        public CEO(string firstName,
                       string lastName,
                       decimal salaryPerHour) : base(firstName, lastName, salaryPerHour) { }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager");
        }
    }
}
