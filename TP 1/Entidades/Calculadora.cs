using System;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida operador. En caso de no ser válido, el operador por defecto es la suma.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            char op = '+';
            if (operador == '/' || operador == '-' || operador == '*')
            {
                op = operador;
            }
            return op;
        }

        /// <summary>
        /// Realiza la operación correspondiente y retorna el resultado de la misma.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            switch (ValidarOperador(operador))
            {
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = num1 + num2;
                    break;
            }
            return resultado;
        }
    }
}
