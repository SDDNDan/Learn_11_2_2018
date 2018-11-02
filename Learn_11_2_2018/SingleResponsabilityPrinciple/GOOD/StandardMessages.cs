using System;

namespace SingleResponsabilityPrinciple.GOOD
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void WelcomeMessage(Person person)
        {
            Console.WriteLine("Welcome " + person.FirstName + " " + person.LastName);
        }

        public static void EndApplication()
        {
            Console.WriteLine("Application will be closed");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
