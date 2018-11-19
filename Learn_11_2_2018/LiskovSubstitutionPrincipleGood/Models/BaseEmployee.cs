using LiskovSubstitutionPrincipleGood.Interfaces;

namespace LiskovSubstitutionPrincipleGood.Models
{
    public class BaseEmployee : IEmployee
    {
        public BaseEmployee(string firstName, string lastName, decimal salaryPerHour)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SalaryPerHour = salaryPerHour * this.BaseSalaryPerHour;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal SalaryPerHour { get; set; }
        public decimal BaseSalaryPerHour = 12.5M;
    }
}
