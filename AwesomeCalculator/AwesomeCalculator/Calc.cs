using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeCalculator
{
    public class Calc
    {
        private double firstNumber;
        private double secondNumber;


        public Calc()
        {
            firstNumber = 1;
            secondNumber = 1;
        }

        public Calc(double firstNumber, double secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

       

        public double Addition()
        {
            return Math.Round((firstNumber + secondNumber), 2);
        }

        public double Subtraction()
        {
            return Math.Round((firstNumber - secondNumber), 2);
        }

        public double Multiplication()
        {
            return Math.Round((firstNumber * secondNumber), 2);
        }

        public double Division()
        {
            try
            {
                return Math.Round((firstNumber / secondNumber), 2);
            }
            catch (DivideByZeroException)
            {
                return (0);
            }


        }

    }
}

