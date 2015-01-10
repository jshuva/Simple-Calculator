using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public double result { get; set; }

        public void calculation(string sign , double num1, double num2)
        {
            switch (sign)
            {
                case "+" :
                    firstNumber = num1;
                    secondNumber = num2;
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    firstNumber = num1;
                    secondNumber = num2;
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    firstNumber = num1;
                    secondNumber = num2;
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    firstNumber = num1;
                    secondNumber = num2;
                    result = firstNumber / secondNumber;
                    break;
            }




        }
   
    
    }
}
