
namespace DerivacionDePacientes
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnAltaPaciente = new System.Windows.Forms.Button();
            this.btnListadoPacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaPaciente
            // 
            this.btnAltaPaciente.Location = new System.Drawing.Point(138, 44);
            this.btnAltaPaciente.Name = "btnAltaPaciente";
            this.btnAltaPaciente.Size = new System.Drawing.Size(288, 94);
            this.btnAltaPaciente.TabIndex = 0;
            this.btnAltaPaciente.Text = "Alta de paciente";
            this.btnAltaPaciente.UseVisualStyleBackColor = true;
            this.btnAltaPaciente.Click += new System.EventHandler(this.btnAltaPaciente_Click);
            // 
            // btnListadoPacientes
            // 
            this.btnListadoPacientes.Location = new System.Drawing.Point(138, 187);
            this.btnListadoPacientes.Name = "btnListadoPacientes";
            this.btnListadoPacientes.Size = new System.Drawing.Size(288, 94);
            this.btnListadoPacientes.TabIndex = 1;
            this.btnListadoPacientes.Text = "Listar pacientes";
            this.btnListadoPacientes.UseVisualStyleBackColor = true;
            this.btnListadoPacientes.Click += new System.EventHandler(this.btnListadoPacientes_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 344);
            this.Controls.Add(this.btnListadoPacientes);
            this.Controls.Add(this.btnAltaPaciente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaPaciente;
        private System.Windows.Forms.Button btnListadoPacientes;
    }
}

