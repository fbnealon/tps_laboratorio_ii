
namespace DerivacionDePacientes
{
    partial class FormDetallarConsulta
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
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.txtBoxDetalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.ItemHeight = 15;
            this.lstPacientes.Location = new System.Drawing.Point(12, 12);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(776, 169);
            this.lstPacientes.TabIndex = 0;
            this.lstPacientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPacientes_MouseDoubleClick);
            // 
            // txtBoxDetalle
            // 
            this.txtBoxDetalle.Location = new System.Drawing.Point(12, 301);
            this.txtBoxDetalle.Multiline = true;
            this.txtBoxDetalle.Name = "txtBoxDetalle";
            this.txtBoxDetalle.PlaceholderText = "Escriba aquí el detalle de consulta";
            this.txtBoxDetalle.Size = new System.Drawing.Size(776, 137);
            this.txtBoxDetalle.TabIndex = 1;
            // 
            // FormDetallarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDetalle);
            this.Controls.Add(this.lstPacientes);
            this.Name = "FormDetallarConsulta";
            this.Text = "FormDetallarConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.TextBox txtBoxDetalle;
    }
}