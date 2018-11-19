namespace LiskovSubstitutionPrincipleGood.Models
{
    public class CEO : BaseEmployee 
    {
        public CEO(string firstName,
                       string lastName,
                       decimal salaryPerHour) : base(firstName, lastName, salaryPerHour) { }

    }
}
