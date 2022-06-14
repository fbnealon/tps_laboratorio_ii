using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerivacionDePacientes
{
    public partial class FormLecturaArchivoDeTexto : Form
    {
        public FormLecturaArchivoDeTexto(string texto)
        {
            InitializeComponent();
            this.rtbListadoDePacientes.Text = texto;
        }
    }
}
