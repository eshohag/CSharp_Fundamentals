namespace Calculator
{
    public class Calculate
    {
        public static double Add(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
        {
            double result = Add(firstNumber, secondNumber, thirdNumber) + Add(fourthNumber);
            return result;
        }
        public static double Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            double result = Add(firstNumber, secondNumber) + thirdNumber;
            return result;
        }
        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        public static double Add(double aNumber)
        {
            double result = aNumber;
            return result;
        }


        //Object create then access methods,
        public double Multiply(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
        {
            double result = Multiply(firstNumber, secondNumber, thirdNumber) * fourthNumber;
            return result;
        }
        public double Multiply(double firstNumber, double secondNumber, double thirdNumber)
        {
            double result = Multiply(firstNumber, secondNumber) * thirdNumber;
            return result;
        }
        public double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        public double Multiply(double aNumber)
        {
            double result = aNumber;
            return result;
        }
        public double Substractor(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
        {
            double sub = Substractor(firstNumber, secondNumber, thirdNumber);
            double result;
            if (sub >= fourthNumber)
            {
                result = sub - fourthNumber;
            }
            else
            {
                result = fourthNumber - sub;
            }
            return result;
        }
        public double Substractor(double firstNumber, double secondNumber, double thirdNumber)
        {
            double sub = Substractor(firstNumber, secondNumber);
            double result;
            if (sub >= thirdNumber)
            {
                result = sub - thirdNumber;
            }
            else
            {
                result = thirdNumber - sub;
            }
            return result;
        }
        public double Substractor(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }
        public double Substractor(double aNumber)
        {
            double result = aNumber;
            return result;
        }
    }

    public abstract class CalculateAbstract     //Cann't create object 
    {
        public static double Add(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
        {
            double result = Add(firstNumber, secondNumber, thirdNumber) + Add(fourthNumber);
            return result;
        }
        public static double Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            double result = Add(firstNumber, secondNumber) + thirdNumber;
            return result;
        }
        public static double Add(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }
        public static double Add(double aNumber)
        {
            double result = aNumber;
            return result;
        }
        public static double Multiply(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
        {
            double result = Multiply(firstNumber, secondNumber, thirdNumber) * fourthNumber;
            return result;
        }
        public static double Multiply(double firstNumber, double secondNumber, double thirdNumber)
        {
            double result = Multiply(firstNumber, secondNumber) * thirdNumber;
            return result;
        }
        public static double Multiply(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
        public static double Multiply(double aNumber)
        {
            double result = aNumber;
            return result;
        }
        public static double Substractor(double firstNumber, double secondNumber, double thirdNumber, double fourthNumber)
        {
            double sub = Substractor(firstNumber, secondNumber, thirdNumber);
            double result;
            if (sub >= fourthNumber)
            {
                result = sub - fourthNumber;
            }
            else
            {
                result = fourthNumber - sub;
            }
            return result;
        }
        public static double Substractor(double firstNumber, double secondNumber, double thirdNumber)
        {
            double sub = Substractor(firstNumber, secondNumber);
            double result;
            if (sub >= thirdNumber)
            {
                result = sub - thirdNumber;
            }
            else
            {
                result = thirdNumber - sub;
            }
            return result;
        }
        public static double Substractor(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }
        public static double Substractor(double aNumber)
        {
            double result = aNumber;
            return result;
        }


    }
}