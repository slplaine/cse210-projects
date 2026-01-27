using System;
using Fractions;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(3, 4);

        Console.WriteLine(f1.ToFractionString());
        Console.WriteLine(f1.ToDecimal());

        Fraction f2 = new Fraction();
        f2.SetNumerator(5);
        f2.SetDenominator(2);

        Console.WriteLine(f2.ToFractionString());
        Console.WriteLine(f2.ToDecimal());
    }
}
