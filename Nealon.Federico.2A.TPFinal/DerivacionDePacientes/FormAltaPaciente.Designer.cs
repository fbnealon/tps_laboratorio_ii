
namespace DerivacionDePacientes
{
    partial class FormAltaPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDniOAfiliado = new System.Windows.Forms.Label();
            this.txtDniOAfiliado = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoTurno = new System.Windows.Forms.ComboBox();
            this.lblTipoDeTurno = new System.Windows.Forms.Label();
            this.checkAfiliado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(23, 97);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(23, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(23, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 23);
            this.txtApellido.TabIndex = 6;
            // 
            // lblDniOAfiliado
            // 
            this.lblDniOAfiliado.AutoSize = true;
            this.lblDniOAfiliado.Location = new System.Drawing.Point(22, 166);
            this.lblDniOAfiliado.Name = "lblDniOAfiliado";
            this.lblDniOAfiliado.Size = new System.Drawing.Size(109, 15);
            this.lblDniOAfiliado.TabIndex = 3;
            this.lblDniOAfiliado.Text = "Numero de afiliado";
            // 
            // txtDniOAfiliado
            // 
            this.txtDniOAfiliado.Location = new System.Drawing.Point(23, 184);
            this.txtDniOAfiliado.Name = "txtDniOAfiliado";
            this.txtDniOAfiliado.Size = new System.Drawing.Size(156, 23);
            this.txtDniOAfiliado.TabIndex = 9;
            this.txtDniOAfiliado.Leave += new System.EventHandler(this.txtDniOAfiliado_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(23, 257);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(104, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(23, 115);
            this.numEdad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 23);
            this.numEdad.TabIndex = 7;
            // 
            // cmbTipoTurno
            // 
            this.cmbTipoTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTurno.FormattingEnabled = true;
            this.cmbTipoTurno.Location = new System.Drawing.Point(23, 228);
            this.cmbTipoTurno.Name = "cmbTipoTurno";
            this.cmbTipoTurno.Size = new System.Drawing.Size(156, 23);
            this.cmbTipoTurno.TabIndex = 10;
            // 
            // lblTipoDeTurno
            // 
            this.lblTipoDeTurno.AutoSize = true;
            this.lblTipoDeTurno.Location = new System.Drawing.Point(23, 210);
            this.lblTipoDeTurno.Name = "lblTipoDeTurno";
            this.lblTipoDeTurno.Size = new System.Drawing.Size(78, 15);
            this.lblTipoDeTurno.TabIndex = 4;
            this.lblTipoDeTurno.Text = "Tipo de turno";
            // 
            // checkAfiliado
            // 
            this.checkAfiliado.AutoSize = true;
            this.checkAfiliado.Checked = true;
            this.checkAfiliado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAfiliado.Location = new System.Drawing.Point(22, 144);
            this.checkAfiliado.Name = "checkAfiliado";
            this.checkAfiliado.Size = new System.Drawing.Size(79, 19);
            this.checkAfiliado.TabIndex = 8;
            this.checkAfiliado.Text = "Es afiliado";
            this.checkAfiliado.UseVisualStyleBackColor = true;
            this.checkAfiliado.CheckedChanged += new System.EventHandler(this.checkAfiliado_CheckedChanged);
            // 
            // FormAltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 293);
            this.Controls.Add(this.checkAfiliado);
            this.Controls.Add(this.lblTipoDeTurno);
            this.Controls.Add(this.cmbTipoTurno);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDniOAfiliado);
            this.Controls.Add(this.lblDniOAfiliado);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAltaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de paciente";
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDniOAfiliado;
        private System.Windows.Forms.TextBox txtDniOAfiliado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.ComboBox cmbTipoTurno;
        private System.Windows.Forms.Label lblTipoDeTurno;
        private System.Windows.Forms.CheckBox checkAfiliado;
    }
}