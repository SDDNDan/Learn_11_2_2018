using SingleResponsabilityPrinciple.BAD;
using System;

namespace SingleResponsabilityPrincipleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new Person();

            Console.Write("What is your first name");
            person.FirstName = Console.ReadLine();

            Console.Write("What is your last name");
            person.LastName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You did not give us a valid last name");
                Console.ReadLine();
                return;
            }

        }
    }
}
