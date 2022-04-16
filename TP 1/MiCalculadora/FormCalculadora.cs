using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama al método Close para reutilizar la confirmación de salida en el método FormClosing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// En caso de no estar vacío, convierte el número decimal de lblResultado a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                Operando numero = new Operando();
                this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
            }
        }

        /// <summary>
        /// En caso de no estar vacío, convierte el número binario de lblResultado a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                Operando binario = new Operando();
                this.lblResultado.Text = binario.BinarioDecimal(this.lblResultado.Text);
            }
        }
        
        /// <summary>
        /// Borra los números ingresados y resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Realiza la operación ingresada. Si no se selecciona operador al inicio de la aplicación, por defecto aplica el operador +.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(this.txtNumero1.Text, out _))
            {
                this.txtNumero1.Text = "0";
            }
            if (!double.TryParse(this.txtNumero2.Text, out _))
            {
                this.txtNumero2.Text = "0";
            }
            if (this.cmbOperador.Text == "")
            {
                this.cmbOperador.Text = "+";
            }
            if (Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text) == double.MinValue)
            {
                MessageBox.Show("No se puede dividir por cero!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
                string aux = string.Format("{0} {1} {2} = {3}\n", this.txtNumero1.Text, this.cmbOperador.Text, this.txtNumero2.Text, this.lblResultado.Text);
                this.lstOperaciones.Items.Add(aux);
            }
        }
        
        /// <summary>
        /// Invoca al método Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        
        /// <summary>
        /// Borra los operandos, el operador y el resultado. La lista de historial de operaciones permanece sin borrar.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = -1;
            this.lblResultado.ResetText();
            this.lstOperaciones.ResetText();
        }
        
        /// <summary>
        /// Invoca al método Operar de la clase Calculadora para retornar el valor del resultado de la operación.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char op;
            if (!char.TryParse(operador, out op))
            {
                op = '+';
                operador = "+";
            }
            return Calculadora.Operar(operando1, operando2, op);
        }


        /// <summary>
        /// Muestra un mensaje para confirmar la salida del formulario. En caso de elegir no, el formulario permanece abierto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
