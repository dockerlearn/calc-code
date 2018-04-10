using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static double Calculate(double firstNum, double secondNum, string op)
        {
            double result;
            switch (op)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return result;
        }
    }

    public static class CalculatorExtension
    {

        public static double Getresult(this System.String op,double firstNum, double secondNum)
        {
            double result;
            switch (op)
            {
                case "add":
                    result = firstNum + secondNum;
                    break;
                case "subtract":
                    if(firstNum>secondNum)
                   result = firstNum - secondNum;
                    else
                        result = secondNum - firstNum;
                    break;
                case "multiply":
                    result = firstNum * secondNum;
                    break;
                case "divide":
                    if (firstNum > secondNum)
                    result = firstNum / secondNum;
                    else
                        result = secondNum / firstNum;
                    break;
                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return result;
        }
    }
}
