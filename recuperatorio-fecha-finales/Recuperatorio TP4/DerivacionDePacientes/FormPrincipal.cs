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
            try
            {
                SerializarPacientes();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay archivo cargado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Registro de turnos";
        }
        private void btnAltaPaciente_Click(object sender, EventArgs e)
        {
            FormAltaPaciente formAltaAfiliado = new FormAltaPaciente();

            if (formAltaAfiliado.ShowDialog() == DialogResult.OK)
            {
                this.pacientes += formAltaAfiliado.Paciente;
            }
        }

        private void btnListadoPacientes_Click(object sender, EventArgs e)
        {
            FormListadoDePacientes formListadoDePacientes = new FormListadoDePacientes(this.pacientes);

            if (formListadoDePacientes.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Los pacientes fueron serializados correctamente");
            }
        }

        private void SerializarPacientes()
        {
            try
            {
                Pacientes<Persona> aux = new Pacientes<Persona>();
                Pacientes<Persona>.LeerXml(AppDomain.CurrentDomain.BaseDirectory, "listadoPacientes.xml", out aux);
                foreach (Persona item in aux.Listado)
                {
                    this.pacientes += item;
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.ArchivosException("Error al intentar cargar la lista preexistente", ex.InnerException);
            }
        }

        private void btnAccesoABaseDeDatos_Click(object sender, EventArgs e)
        {
            FormBaseDeDatos formBD = new FormBaseDeDatos(this.pacientes.Listado);
            formBD.StartPosition = FormStartPosition.CenterParent;
            formBD.Show();
        }
    }
}
