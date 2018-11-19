using LiskovSubstitutionPrincipleGood.Interfaces;

namespace LiskovSubstitutionPrincipleGood.Models
{
    public class Employee : BaseEmployee, IManaged
    {
        public Employee(string firstName,
                       string lastName,
                       decimal salaryPerHour) : base(firstName, lastName, salaryPerHour) { }

        public BaseEmployee HisManager { get; set; }

        public void AssignManager(BaseEmployee manager)
        {
            this.HisManager = manager;
        }
    }
}
