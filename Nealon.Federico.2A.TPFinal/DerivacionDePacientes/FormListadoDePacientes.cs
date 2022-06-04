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
    public partial class FormListadoDePacientes : Form
    {
        private Pacientes<Persona> pacientes;
        private DataTable dtPacientes = new DataTable();
        public FormListadoDePacientes(Pacientes<Persona> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;

            foreach (Persona item in this.pacientes.Listado)
            {
                this.rtbPacientes.Text += item.ToString();
            }
        }
    }
}
