using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace DerivacionDePacientes
{
    public partial class FormAltaPaciente : Form
    {
        private Persona paciente;
        public FormAltaPaciente()
        {
            InitializeComponent();
            this.cmbTipoTurno.DataSource = Enum.GetValues(typeof(EEspecialidades));
        }

        public FormAltaPaciente(int id) : this()
        {
            this.numId.Value = id;
        }

        public FormAltaPaciente(Persona persona) : this()
        {
            this.paciente = persona;
            this.numId.Value = persona.Id;
            this.txtNombre.Text = persona.Nombre;
            this.txtApellido.Text = persona.Apellido;
            this.numEdad.Value = persona.Edad;
            this.txtDniOAfiliado.Enabled = false;
            this.checkAfiliado.Enabled = false;
            this.txtDniOAfiliado.Text = "A";
        }

        public Persona Paciente { get => this.paciente; set => this.paciente = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampoVacio(this.txtNombre.Text);
                ValidarCampoVacio(this.txtApellido.Text);
                ValidarCampoVacio(this.txtDniOAfiliado.Text);
                ValidarCampoSinNumeros(this.txtNombre.Text);
                ValidarCampoSinNumeros(this.txtApellido.Text);

                if (this.checkAfiliado.Checked)
                {
                    this.paciente = new Afiliado((int)this.numId.Value, this.txtNombre.Text, this.txtApellido.Text, (int)numEdad.Value, this.txtDniOAfiliado.Text, (EEspecialidades)this.cmbTipoTurno.SelectedItem);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ValidarDni(this.txtDniOAfiliado.Text);
                    this.paciente = new NoAfiliado((int)this.numId.Value, this.txtNombre.Text, this.txtApellido.Text, (int)numEdad.Value, this.txtDniOAfiliado.Text, (EEspecialidades)this.cmbTipoTurno.SelectedItem);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (NumeroAfiliadoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CampoVacioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CampoConNumerosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkAfiliado_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkAfiliado.Checked)
            {
                this.lblDniOAfiliado.Text = "DNI";
            }
            else
            {
                this.lblDniOAfiliado.Text = "Numero de afiliado";
            }
        }

        private void txtDniOAfiliado_Leave(object sender, EventArgs e)
        {
            try
            {
                if (this.checkAfiliado.Checked)
                {
                    if (!this.txtDniOAfiliado.Text.StartsWith("A"))
                    {
                        throw new NumeroAfiliadoInvalidoException("Los numeros de afiliado comienzan con A");
                    }
                }
                else
                {
                    ValidarDni(this.txtDniOAfiliado.Text);
                }
            }
            catch (NumeroAfiliadoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Lanza una excepción en caso de que el dni no contenga 8 numeros.
        /// </summary>
        /// <param name="dni"></param>
        public void ValidarDni(string dni)
        {
            foreach (char c in dni)
            {
                if (c < '0' || c > '9' || dni.Length!=8)
                {
                    throw new DniInvalidoException("DNI se conforma de solo 8 numeros.");
                }
            }
        }
        /// <summary>
        /// Lanza una excepción en caso de que un dato quede vacío.
        /// </summary>
        /// <param name="dato"></param>
        public void ValidarCampoVacio(string dato)
        {
            if (dato == "")
            {
                throw new CampoVacioException("No puede quedar un campo vacío.");
            }
        }

        /// <summary>
        /// Lanza una excepcion en caso de que un dato tenga algún caracter más que una letra.
        /// </summary>
        /// <param name="dato"></param>
        public void ValidarCampoSinNumeros(string dato)
        {
            if (!Regex.IsMatch(dato, @"^[a-zA-Z]+$"))
            {
                throw new CampoConNumerosException("Nombre y apellido sólo debe contener letras.");
            }
        }
    }
}
