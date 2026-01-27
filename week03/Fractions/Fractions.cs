namespace Fractions
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int numerator)
        {
            SetNumerator(numerator);
            SetDenominator(1);
        }

        public Fraction(int numerator, int denominator)
        {
            SetNumerator(numerator);
            SetDenominator(denominator);
        }

        public int GetNumerator()
        {
            return _numerator;
        }

        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            _denominator = denominator;
        }

        public string ToFractionString()
        {
            return _numerator + "/" + _denominator;
        }

        public double ToDecimal()
        {
            return (double)_numerator / _denominator;
        }
    }
}
