using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Entidades;
using Excepciones;

namespace DerivacionDePacientes
{
    public partial class FormListadoDePacientes : Form
    {
        private Pacientes<Persona> pacientes;
        private DataTable dtPacientes = new DataTable("Pacientes");

        public Pacientes<Persona> Pacientes { get => this.pacientes; set => this.pacientes = value; }

        public FormListadoDePacientes(Pacientes<Persona> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;

            this.ConfigurarColumnasDataTable();

            this.dataGridAfiliados.DataSource = this.dtPacientes;

            foreach (Persona item in this.pacientes.Listado)
            {
                DataRow fila = this.dtPacientes.NewRow(); 
                item.Id = (int)fila["ID"];
                fila["Nombre"] = item.Nombre;
                fila["Apellido"] = item.Apellido;
                fila["Edad"] = item.Edad;
                fila["Derivar a"] = item.Especialidad;
                if (item is Afiliado)
                {
                    fila["DNI/Nº afiliado"] = ((Afiliado)item).NroAfiliado;
                }
                if (item is NoAfiliado)
                {
                    fila["DNI/Nº afiliado"] = ((NoAfiliado)item).Dni;

                }

                this.dtPacientes.Rows.Add(fila);
            }
        }

        private void ConfigurarColumnasDataTable()
        {
            this.dtPacientes.Columns.Add("ID", typeof(int));
            this.dtPacientes.Columns.Add("Nombre", typeof(string));
            this.dtPacientes.Columns.Add("Apellido", typeof(string));
            this.dtPacientes.Columns.Add("Edad", typeof(int));
            this.dtPacientes.Columns.Add("Derivar a", typeof(EEspecialidades));
            this.dtPacientes.Columns.Add("DNI/Nº afiliado", typeof(string));

            this.dtPacientes.PrimaryKey = new DataColumn[] { this.dtPacientes.Columns[0] };

            this.dtPacientes.Columns["ID"].AutoIncrement = true;
            this.dtPacientes.Columns["ID"].AutoIncrementSeed = 1;
            this.dtPacientes.Columns["ID"].AutoIncrementStep = 1;
        }
        private void btnSerializarPacientesXML_Click(object sender, EventArgs e)
        {
            if (this.pacientes.Listado.Count == 0)
            {
                MessageBox.Show("No se serializará un archivo vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pacientes<Persona> aux= new Pacientes<Persona>();
                foreach (Persona item in this.pacientes.Listado)
                {
                    aux += item;
                }
                if (Pacientes<Persona>.GuardarXml(AppDomain.CurrentDomain.BaseDirectory, "listadoPacientes.xml", aux))
                {
                    MessageBox.Show("Archivo serializado");
                }
                
            }
        }

        private void btnDeserializarPacientesXML_Click(object sender, EventArgs e)
        {
            try
            {
                Pacientes<Persona> aux = new Pacientes<Persona>();
                Pacientes<Persona>.LeerXml(AppDomain.CurrentDomain.BaseDirectory, "listadoPacientes.xml", out aux);
                foreach (Persona item in aux.Listado)
                {
                    this.pacientes += item;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSerializarPacientesJSON_Click(object sender, EventArgs e)
        {
            if (this.pacientes.Listado.Count == 0)
            {
                MessageBox.Show("No se serializará un archivo vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pacientes<Persona> aux = new Pacientes<Persona>();
                foreach (Persona item in this.pacientes.Listado)
                {
                    aux += item;
                }
                if (Pacientes<Persona>.GuardarJson(AppDomain.CurrentDomain.BaseDirectory, "listadoPacientes.json", aux))
                {
                    MessageBox.Show("Archivo serializado");
                }
            }
        }

        private void btnDeserializarPacientesJSON_Click(object sender, EventArgs e)
        {
            try
            {
                Pacientes<Persona> aux = new Pacientes<Persona>();
                Pacientes<Persona>.LeerJson(AppDomain.CurrentDomain.BaseDirectory, "listadoPacientes.json", out aux);
                foreach (Persona item in aux.Listado)
                {
                    this.pacientes += item;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}