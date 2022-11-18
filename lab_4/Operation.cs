using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_4
{
    public class Operation
    {
        public static int GetPriority(string p0)
        {
            
            switch (p0) 
            {
                case "+": return 1;
                case "-": return 1;
                case "*": return 2;
                case "/": return 2;
                case "%": return 2;
                case "abs": return 3;
                case "sqr": return 3;
            }
            return -1;
        }
        public static double CountOperator(string item, double a)
        {
            
            switch (item) 
            {
                case "abs": return Math.Abs(a);
                case "sqr": return Math.Pow(a, 2);
                default: throw new Exception("Other operator. ");
            }
        } 
        public static double CalculateOperations(string item, double a, double b)
        {
            switch (item) 
            {
                case "+": return a + b;
                case "-": return a - b;
                case "*": return a * b;
                case "/": return a / b;
                case "%": return a % b;
                default: return 0;
            }
        }
        public static bool IsOperator(string item)
        {
            string[] operators = { "+", "-", "*", "/", "%" };
            return operators.Contains(item);
        }
    }
}
