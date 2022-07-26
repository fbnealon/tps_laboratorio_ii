using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerivacionDePacientes
{
    public delegate void DelegadoActualizarListado();
    public partial class FormBaseDeDatos : Form
    {
        private Pacientes<Persona> pacientes;

        public Pacientes<Persona> Pacientes { get => this.pacientes; set => this.pacientes = value; }

        public FormBaseDeDatos(Pacientes<Persona> pacientes)
        {
            InitializeComponent();
            this.pacientes = DAO.ObtenerPacientes();
            this.Text = "Base de datos";
        }

        private void FormBaseDeDatos_Load(object sender, EventArgs e)
        {
            this.lstBoxPacientesBD.DataSource = this.pacientes.Listado;
            Task hora = Task.Run(() => { while (true)
                {
                    if (this.lblFecha.InvokeRequired)
                    {
                        this.lblFecha.BeginInvoke((MethodInvoker)delegate ()
                        {
                            this.lblFecha.Text = DateTime.Now.ToString();
                        });
                    }
                    else
                    {
                        this.lblFecha.Text = DateTime.Now.ToString();
                    }
                    Thread.Sleep(1000);
                }
            });
            this.pacientes = DAO.ObtenerPacientes();
            Task.Run(() => ActualizarListado());
        }

        private void ActualizarListado()
        {
            if (this.lstBoxPacientesBD.InvokeRequired)
            {
                DelegadoActualizarListado delegadoActualizarListado = ActualizarListado;
                this.lstBoxPacientesBD.Invoke(delegadoActualizarListado);
            }
            else
            {
                if (lstBoxPacientesBD.Items.Count < this.pacientes.Listado.Count)
                {
                    this.lstBoxPacientesBD.Refresh();
                }
            }
        }

        private void btnAgregarBD_Click(object sender, EventArgs e)
        {
            FormAltaPaciente altaPaciente = new FormAltaPaciente(this.lstBoxPacientesBD.Items.Count + 1);
            altaPaciente.StartPosition = FormStartPosition.CenterParent;

            if (altaPaciente.ShowDialog() == DialogResult.OK)
            {
                DAO dao = new DAO();
                dao.ConsultaOIdRepetido += Manejador_ConsultaOIdRepetidos;

                if (dao.Agregar(altaPaciente.Paciente))
                {
                    this.FormBaseDeDatos_Load(sender, e);
                    MessageBox.Show("Paciente agregado a la base de datos");
                    this.pacientes += altaPaciente.Paciente;
                }
                else
                {
                    MessageBox.Show("No se agregó la consulta a la base de datos");
                }

                dao.ConsultaOIdRepetido -= Manejador_ConsultaOIdRepetidos;
            }
        }
        private void Manejador_ConsultaOIdRepetidos(object sender, EventArgs e)
        {

            Pacientes<Persona> pacientes = (Pacientes<Persona>)sender;

            foreach (Persona item in pacientes.Listado)
            {
                MessageBox.Show(item.ToString(), "Consulta o ID repetido " + DateTime.Now);
            }

        }

        private void btnModificarBD_Click(object sender, EventArgs e)
        {
            int i = this.lstBoxPacientesBD.SelectedIndex;

            if( i<0 ) { return; }

            Persona persona = this.pacientes.Listado[i];

            FormAltaPaciente altaPaciente = new FormAltaPaciente(persona);
            altaPaciente.StartPosition = FormStartPosition.CenterParent;

            if (altaPaciente.ShowDialog() == DialogResult.OK)
            {
                DAO dao = new DAO();

                if (dao.Modificar(altaPaciente.Paciente))
                {
                    this.pacientes.Listado[i] = altaPaciente.Paciente;
                    this.FormBaseDeDatos_Load(sender, e);
                    MessageBox.Show("Paciente modificado");
                }
                else
                {
                    MessageBox.Show("El paciente no se modificó");
                }
            }
        }

        private void btnEliminarBD_Click(object sender, EventArgs e)
        {
            int i = this.lstBoxPacientesBD.SelectedIndex;

            if (i < 0) { return; }

            Persona persona = this.pacientes.Listado[i];

            FormAltaPaciente altaPaciente = new FormAltaPaciente(persona);
            altaPaciente.StartPosition = FormStartPosition.CenterParent;

            if (altaPaciente.ShowDialog() == DialogResult.OK)
            {
                DAO dao = new DAO();
                if (dao.Eliminar(altaPaciente.Paciente))
                {
                    this.pacientes.Listado.RemoveAt(i);
                    this.FormBaseDeDatos_Load(sender, e);
                    MessageBox.Show("Paciente eliminado.");
                }
                else
                {
                    MessageBox.Show("El paciente no se ha eliminado.");
                }
            }
        }
    }
}
