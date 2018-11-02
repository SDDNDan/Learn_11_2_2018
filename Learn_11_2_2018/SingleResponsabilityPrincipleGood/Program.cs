using SingleResponsabilityPrinciple.GOOD;
using System;

namespace SingleResponsabilityPrincipleGood
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person person = PersonDataCapture.Capture();

            PersonValidator.Validate(person);

            StandardMessages.WelcomeMessage(person);

            StandardMessages.EndApplication();
        }
    }
}
