using System;

namespace SingleResponsabilityPrinciple.GOOD
{
    public class PersonValidator
    {
        public static void Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name");
                StandardMessages.EndApplication();
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You did not give us a valid last name");
                StandardMessages.EndApplication();
            }
        }
    }
}
