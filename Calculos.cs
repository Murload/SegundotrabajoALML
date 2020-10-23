using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_2
{
    class Calculos
    {
        public double sumas(double a, double b)
        {
           
            double resultado;
            resultado = a + b;
            return resultado;
        }

        public double resta(double a, double b)
        {
            double resultado;
            resultado = a - b;
            return resultado;

        }
        public double multiplicacion(double a, double b)
        {
            double resultado;
            resultado = a * b;
            return resultado;
        }
        public double division(double a, double b)
        {
            double resultado;
            resultado = a / b;
            return resultado;
        }
        public double factorial(double a)
        {
           
            double res = 1;
            int contador = 0;
            a = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                contador = contador + 1;
                res = res * contador;

            }

            return res;
        }
    }

}
