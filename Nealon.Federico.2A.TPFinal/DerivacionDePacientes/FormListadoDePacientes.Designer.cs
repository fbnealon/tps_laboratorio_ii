
namespace DerivacionDePacientes
{
    partial class FormListadoDePacientes
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
            this.dataGridAfiliados = new System.Windows.Forms.DataGridView();
            this.btnSerializarAfiliadosXML = new System.Windows.Forms.Button();
            this.btnDeserializarAfiliadosXML = new System.Windows.Forms.Button();
            this.btnGuardarArchivoDeTexto = new System.Windows.Forms.Button();
            this.btnLeerArchivoDeTexto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAfiliados
            // 
            this.dataGridAfiliados.AllowUserToAddRows = false;
            this.dataGridAfiliados.AllowUserToDeleteRows = false;
            this.dataGridAfiliados.AllowUserToOrderColumns = true;
            this.dataGridAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfiliados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridAfiliados.Location = new System.Drawing.Point(12, 12);
            this.dataGridAfiliados.Name = "dataGridAfiliados";
            this.dataGridAfiliados.RowTemplate.Height = 25;
            this.dataGridAfiliados.Size = new System.Drawing.Size(645, 426);
            this.dataGridAfiliados.TabIndex = 0;
            // 
            // btnSerializarAfiliadosXML
            // 
            this.btnSerializarAfiliadosXML.Location = new System.Drawing.Point(12, 444);
            this.btnSerializarAfiliadosXML.Name = "btnSerializarAfiliadosXML";
            this.btnSerializarAfiliadosXML.Size = new System.Drawing.Size(155, 45);
            this.btnSerializarAfiliadosXML.TabIndex = 1;
            this.btnSerializarAfiliadosXML.Text = "Serializar Pacientes XML";
            this.btnSerializarAfiliadosXML.UseVisualStyleBackColor = true;
            this.btnSerializarAfiliadosXML.Click += new System.EventHandler(this.btnSerializarPacientesXML_Click);
            // 
            // btnDeserializarAfiliadosXML
            // 
            this.btnDeserializarAfiliadosXML.Location = new System.Drawing.Point(173, 444);
            this.btnDeserializarAfiliadosXML.Name = "btnDeserializarAfiliadosXML";
            this.btnDeserializarAfiliadosXML.Size = new System.Drawing.Size(155, 45);
            this.btnDeserializarAfiliadosXML.TabIndex = 3;
            this.btnDeserializarAfiliadosXML.Text = "Deserializar Pacientes XML";
            this.btnDeserializarAfiliadosXML.UseVisualStyleBackColor = true;
            this.btnDeserializarAfiliadosXML.Click += new System.EventHandler(this.btnDeserializarPacientesXML_Click);
            // 
            // btnGuardarArchivoDeTexto
            // 
            this.btnGuardarArchivoDeTexto.Location = new System.Drawing.Point(341, 444);
            this.btnGuardarArchivoDeTexto.Name = "btnGuardarArchivoDeTexto";
            this.btnGuardarArchivoDeTexto.Size = new System.Drawing.Size(155, 45);
            this.btnGuardarArchivoDeTexto.TabIndex = 4;
            this.btnGuardarArchivoDeTexto.Text = "Guardar archivo de texto";
            this.btnGuardarArchivoDeTexto.UseVisualStyleBackColor = true;
            this.btnGuardarArchivoDeTexto.Click += new System.EventHandler(this.btnGuardarArchivoDeTexto_Click);
            // 
            // btnLeerArchivoDeTexto
            // 
            this.btnLeerArchivoDeTexto.Location = new System.Drawing.Point(502, 444);
            this.btnLeerArchivoDeTexto.Name = "btnLeerArchivoDeTexto";
            this.btnLeerArchivoDeTexto.Size = new System.Drawing.Size(155, 45);
            this.btnLeerArchivoDeTexto.TabIndex = 5;
            this.btnLeerArchivoDeTexto.Text = "Leer archivo de texto";
            this.btnLeerArchivoDeTexto.UseVisualStyleBackColor = true;
            this.btnLeerArchivoDeTexto.Click += new System.EventHandler(this.btnLeerArchivoDeTexto_Click);
            // 
            // FormListadoDePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 535);
            this.Controls.Add(this.btnLeerArchivoDeTexto);
            this.Controls.Add(this.btnGuardarArchivoDeTexto);
            this.Controls.Add(this.btnDeserializarAfiliadosXML);
            this.Controls.Add(this.btnSerializarAfiliadosXML);
            this.Controls.Add(this.dataGridAfiliados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListadoDePacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAfiliados;
        private System.Windows.Forms.Button btnSerializarAfiliadosXML;
        private System.Windows.Forms.Button btnDeserializarAfiliadosXML;
        private System.Windows.Forms.Button btnGuardarArchivoDeTexto;
        private System.Windows.Forms.Button btnLeerArchivoDeTexto;
    }
}