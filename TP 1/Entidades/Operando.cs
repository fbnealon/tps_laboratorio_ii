using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        /// <summary>
        /// Atributo privado de tipo double.
        /// </summary>
        private double numero;

        /// <summary>
        /// Constructor por defecto de Operando. Inicializa el atributo numero en 0.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Sobrecarga de constructor, valor del atributo numero pasado como parámetro.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Sobrecarga de constructor. Reutiliza la propiedad Numero para asignar el valor del parámetro de formato string.
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        /// <summary>
        /// Validación de operando. De no ser posible el parseo de string a double, el numero asignado es 0.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;
            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            return numero;
        }

        /// <summary>
        /// Propiedad de la clase. Setea el atributo numero a través del método ValidarOperando.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        /// <summary>
        /// Retorna verdadero si el string es binario.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool esBin = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    esBin = false;
                    break;
                }
            }
            return esBin;
        }

        /// <summary>
        /// De ser posible la conversión, transforma un binario a decimal. Caso contrario, retorna "Valor inválido".
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor inválido";

            if (this.EsBinario(binario))
            {
                int entero = 0;
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1')
                    {
                        entero += (int)Math.Pow(2, binario.Length - 1 - i);
                    }
                }
                resultado = entero.ToString();
            }
            return resultado;
        }

        /// <summary>
        /// De ser posible la conversión, transforma un decimal a binario. Caso contrario, retorna "Valor inválido".
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string binario = "Valor inválido";

            int aux = (int)Math.Abs(numero);
            binario = string.Empty;
            while (aux > 0)
            {
                binario = aux % 2 + binario;
                aux /= 2;
            }
            return binario;
        }

        /// <summary>
        /// Sobrecarga de método. Reutiliza el método DecimalBinario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string binario = "Valor inválido";
            if (double.TryParse(numero, out double aux))
            {
                binario = DecimalBinario(aux);
            }
            return binario;
        }

        /// <summary>
        /// Sobrecarga de operador. Posibilita la resta entre dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador. Posibilita la multiplicación entre dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador. Posibilita la división entre dos objetos de tipo Operando. En caso de que el denominador sea 0, retorna double.MinValue.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double aux = n2.numero;
            if (aux == 0)
            {
                aux = double.MinValue;
            }
            else
            {
                aux = n1.numero / n2.numero;
            }
            return aux;
        }

        /// <summary>
        /// Sobrecarga de operador. Posibilita la suma entre dos objetos de tipo Operando.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
