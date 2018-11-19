using LiskovSubstitutionPrincipleGood.Interfaces;

namespace LiskovSubstitutionPrincipleGood.Models
{
    public class Manager : BaseEmployee , IManaged
    {
        public Manager(string firstName,
                       string lastName,
                       decimal salaryPerHour) : base(firstName, lastName, salaryPerHour) { }

        public BaseEmployee HisManager { get; set; }

        public void AssignManager(BaseEmployee manager)
        {
            this.HisManager = manager;
        }
    }
}
