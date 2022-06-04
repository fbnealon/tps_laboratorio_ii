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
    public partial class FormAltaAfiliado : Form
    {
        private Afiliado afiliado;
        public FormAltaAfiliado()
        {
            InitializeComponent();
        }

        public Afiliado Afiliado { get => this.afiliado; set => this.afiliado = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idAfiliado = 0;
                this.afiliado = new Afiliado(idAfiliado, this.txtNombre.Text, this.txtApellido.Text, (int)numEdad.Value, this.txtDniOAfiliado.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Uno o más campos están vacíos");
            }
        }
    }
}
