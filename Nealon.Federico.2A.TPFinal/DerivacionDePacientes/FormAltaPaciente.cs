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
using Excepciones;

namespace DerivacionDePacientes
{
    public partial class FormAltaPaciente : Form
    {
        private Afiliado paciente_afiliado;
        private NoAfiliado paciente_noAfiliado;
        public FormAltaPaciente()
        {
            InitializeComponent();
            this.cmbTipoTurno.DataSource = Enum.GetValues(typeof(EEspecialidades));

        }

        public Afiliado PacienteAfiliado { get => this.paciente_afiliado; set => this.paciente_afiliado = value; }
        public NoAfiliado PacienteNoAfiliado { get => this.paciente_noAfiliado; set => this.paciente_noAfiliado = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampoVacio(this.txtNombre.Text);
                ValidarCampoVacio(this.txtApellido.Text);
                ValidarCampoVacio(this.txtDniOAfiliado.Text);

                if (this.checkAfiliado.Checked)
                {
                    this.paciente_afiliado = new Afiliado(1, this.txtNombre.Text, this.txtApellido.Text, (int)numEdad.Value, this.txtDniOAfiliado.Text, (EEspecialidades)this.cmbTipoTurno.SelectedItem);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    ValidarDni(this.txtDniOAfiliado.Text);
                    this.paciente_noAfiliado = new NoAfiliado(1, this.txtNombre.Text, this.txtApellido.Text, (int)numEdad.Value, this.txtDniOAfiliado.Text, (EEspecialidades)this.cmbTipoTurno.SelectedItem);
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

        public void ValidarDni(string dni)
        {
            foreach (char c in dni)
            {
                if (c < '0' || c > '9')
                {
                    throw new DniInvalidoException("DNI se conforma de solo numeros");
                }
            }
        }
        public void ValidarCampoVacio(string dato)
        {
            if (dato == "")
            {
                throw new CampoVacioException("No puede quedar un campo vacío");
            }
        }
    }
}
