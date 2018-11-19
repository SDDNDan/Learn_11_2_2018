namespace LiskovSubstitutionPrincipleGood.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        decimal SalaryPerHour { get; set; }
    }
}
