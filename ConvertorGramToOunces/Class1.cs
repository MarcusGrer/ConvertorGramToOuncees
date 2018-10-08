using System;

namespace ConvertorGramToOunces
{
    public class Class1
    {
        public static double OuncesToGrams(double ounces)
        {
            double grams = ounces * 28.34952;
            return grams;
        }

        public static double GramsToOunces(double grams)
        {
            double ounces = grams / 28.34952;
            return ounces;
        }
    }
}
