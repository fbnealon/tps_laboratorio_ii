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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                Operando numero = new Operando();
                this.lblResultado.Text = numero.DecimalBinario(this.lblResultado.Text);
            }
        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (this.lblResultado.Text != "")
            {
                Operando binario = new Operando();
                this.lblResultado.Text = binario.BinarioDecimal(this.lblResultado.Text);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.cmbOperador.Text == "")
            {
                MessageBox.Show("No se puede operar sin seleccionar previamente un operando", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!double.TryParse(this.txtNumero1.Text, out _))
                {
                    this.txtNumero1.Text = "0";
                }
                if (!double.TryParse(this.txtNumero2.Text, out _))
                {
                    this.txtNumero2.Text = "0";
                }
                this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
                string aux = string.Format("{0} {1} {2} = {3}\n", this.txtNumero1.Text, this.cmbOperador.Text, this.txtNumero2.Text, this.lblResultado.Text);
                this.lstOperaciones.Items.Add(aux);

            }
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.ResetText();
            this.lstOperaciones.ResetText();
        }
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char op = Convert.ToChar(operador);

            return Calculadora.Operar(operando1, operando2, op);
        }



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
