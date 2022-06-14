
namespace DerivacionDePacientes
{
    partial class FormLecturaArchivoDeTexto
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
            this.rtbListadoDePacientes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbListadoDePacientes
            // 
            this.rtbListadoDePacientes.Location = new System.Drawing.Point(12, 12);
            this.rtbListadoDePacientes.Name = "rtbListadoDePacientes";
            this.rtbListadoDePacientes.ReadOnly = true;
            this.rtbListadoDePacientes.Size = new System.Drawing.Size(405, 546);
            this.rtbListadoDePacientes.TabIndex = 0;
            this.rtbListadoDePacientes.Text = "";
            // 
            // FormLecturaArchivoDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 570);
            this.Controls.Add(this.rtbListadoDePacientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLecturaArchivoDeTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de pacientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbListadoDePacientes;
    }
}