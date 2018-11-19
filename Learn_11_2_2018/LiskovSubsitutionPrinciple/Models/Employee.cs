namespace LiskovSubstitutionPrincipleBad.Models
{
    public class Employee
    {
        public Employee(string firstName, string lastName, decimal salaryPerHour)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SalaryPerHour = salaryPerHour * this.BaseSalaryPerHour;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public decimal SalaryPerHour { get; private set; }

        public Employee Manager { get; private set; }

        public decimal BaseSalaryPerHour = 12.5M;


        public virtual void AssignManager(Employee manager)
        {
            this.Manager = manager;
        }
    }
}
