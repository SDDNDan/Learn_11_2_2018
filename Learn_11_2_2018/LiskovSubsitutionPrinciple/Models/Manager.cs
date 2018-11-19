namespace LiskovSubstitutionPrincipleBad.Models
{
    public class Manager : Employee
    {
        public Manager(string firstName,
                       string lastName,
                       decimal salaryPerHour) : base(firstName, lastName, salaryPerHour) { }
    }
}
