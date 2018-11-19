using LiskovSubstitutionPrincipleBad.Models;

namespace LiskovSubstitutionPrincipleBad
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager firstManager = new Manager("Dan", "Dan", 100);

            Manager secondManager = new Manager("Dan","Dan",100);

            Employee employee = new Employee("Dan", "Dan", 100);

            CEO ceo = new CEO("Dan", "Dan", 100);

            employee.AssignManager(secondManager);
            secondManager.AssignManager(firstManager);
            ceo.AssignManager(firstManager);


        }
    }
}
