using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class calculadora
    {
        public double num1,num2,resultado;

        public double somar()
        {
            
            resultado = num1 + num2;
            return resultado;
        }
        public double multiplicar()
        {
            resultado = num1 * num2;
            return resultado;
        }
        public double subtrair()
        {
            resultado = num1 - num2;
            return resultado;
        }
        public double dividir()
        {
            resultado = num1 / num2;
            return resultado;
        }

    }
}
