
namespace MethodsOverloading
{
    class Calculator
    {
        public double Add(double aNumber, double twoNumber, double thiredNumber)
        {
            return aNumber + twoNumber + thiredNumber;
        }
        public double Add(double aNumber, double twoNumber)
        {
            return aNumber + twoNumber;
        }
        public double Add(double aNumber)
        {
            return aNumber + 6;
        }
    }
}
