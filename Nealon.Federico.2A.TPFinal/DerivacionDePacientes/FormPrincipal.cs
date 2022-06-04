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

namespace DerivacionDePacientes
{
    public partial class FormPrincipal : Form
    {
        private Pacientes<Persona> pacientes;
        public FormPrincipal()
        {
            InitializeComponent();
            this.pacientes = new Pacientes<Persona>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de derivacion de pacientes";
        }
        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAltaAfiliado formAltaAfiliado = new FormAltaAfiliado();

            if (formAltaAfiliado.ShowDialog() == DialogResult.OK)
            {
                this.pacientes += formAltaAfiliado.Afiliado;
            }
        }

        private void btnListadoPacientes_Click(object sender, EventArgs e)
        {
            FormListadoDePacientes formListadoDePacientes = new FormListadoDePacientes(this.pacientes);

            formListadoDePacientes.ShowDialog();
        }

    }
}
