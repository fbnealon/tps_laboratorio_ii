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
using Archivos;
using System.IO;
using Excepciones;

namespace DerivacionDePacientes
{
    public partial class FormDetallarConsulta : Form
    {
        private List<Persona> pacientes;
        private Persona paciente;
        public FormDetallarConsulta(List<Persona> pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;
            this.lstPacientes.DataSource = this.pacientes;
        }

        private void lstPacientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (MessageBox.Show($"¿Desea guardar el detalle de consulta del paciente detallado?\n{this.lstPacientes.SelectedItem}", "Detallar consulta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (this.txtBoxDetalle.Text == "")
                    {
                        throw new DetalleVacioException("No se detalló la consulta");
                    }
                    this.paciente = (Persona)this.lstPacientes.SelectedItem;
                    if (GuardarDetalle(this.txtBoxDetalle.Text))
                    {
                        MessageBox.Show("Detalle de consulta guardado");
                        this.Close();
                    }
                }

            }
            catch (DetalleVacioException)
            {
                MessageBox.Show("Por favor, anote los detalles de la consulta.");
            }
        }

        private bool GuardarDetalle(string detalle)
        {
            string rutaCarpeta = AppDomain.CurrentDomain.BaseDirectory;
            string nombreArchivo = @"detalles.log";
            string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

            bool rta = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine($"Consulta de {this.paciente.Apellido}, {this.paciente.Nombre} en el área de {this.paciente.Especialidad}");
                    sw.WriteLine(detalle);
                    sw.WriteLine();
                }
                rta = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error al guardar el detalle de la consulta");
            }
            return rta;
        }
    }
}
