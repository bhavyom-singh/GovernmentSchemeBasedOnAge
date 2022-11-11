using System;

namespace GovernmentSchemeBasedOnAge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            EligibilityBasedOnAge eligibilityBasedOnAge = new EligibilityBasedOnAge();
            if(eligibilityBasedOnAge.IsEligible(age))
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }

    public class EligibilityBasedOnAge
    {
        public bool IsEligible(string age)
        {
            bool isAgeInteger = Int32.TryParse(age, out int ageOut);
            if (isAgeInteger)
            {
                return ageOut >= 18 && ageOut <= 70 && (ageOut <= 40 || ageOut >= 55);
            }
            return false;            
        }
    }
}
