using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    public class methods
    {
        public static int MenhodsPlus(int a, int b)
        {
            return a + b;
        }

        public static int MethodsMinus(int a, int b)
        {
            return a - b;
        }

        public static int MethodsUmnojit(int a, int b)
        {
            return a * b;
        }

        public static int MthodsDelenie(int a, int b)
        {
            return a / b;
        }

        public static int MethodsStepen(int a, int n)
        {
            int result = 1;

            for (int i = 0; i < Math.Abs(a); i++)
            {
                result *= n;
            }

            if (a < 0)
            {
                result = 1 / result;
            }

            return result;
        }

        public static double MethodsKoren(double a)
        {
            return Math.Sqrt(a);
        }

        public static int MethodsProcent(int a)
        {
            return a / 100;
        }

        public static int MethodsFact(int a)
        {
            if (a == 1) return 1;

            return a * MethodsFact(a - 1);
        }
    }
}
