using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        private double ValidarOperando(string strNumero)
        {
            double numero;
            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            return numero;
        }

        public string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }

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

        public string BinarioDecimal(string binario)
        {
            string resultado = "Valor invalido";

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

        public string DecimalBinario(double numero)
        {
            string binario = "Valor invalido";

            int aux = (int)Math.Abs(numero);
            if (aux == numero || -aux == numero)
            {
                binario = string.Empty;
                while (aux > 0)
                {
                    binario = aux % 2 + binario;
                    aux /= 2;
                }
            }
            return binario;
        }

        public string DecimalBinario(string numero)
        {
            string binario = "Valor invalido";
            if (double.TryParse(numero, out double aux))
            {
                binario = DecimalBinario(aux);
            }
            return binario;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

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

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}
