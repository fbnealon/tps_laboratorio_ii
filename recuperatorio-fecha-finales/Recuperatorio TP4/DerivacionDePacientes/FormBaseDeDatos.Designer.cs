
namespace DerivacionDePacientes
{
    partial class FormBaseDeDatos
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
            this.lstBoxPacientesBD = new System.Windows.Forms.ListBox();
            this.btnModificarBD = new System.Windows.Forms.Button();
            this.btnAgregarBD = new System.Windows.Forms.Button();
            this.btnEliminarBD = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxPacientesBD
            // 
            this.lstBoxPacientesBD.FormattingEnabled = true;
            this.lstBoxPacientesBD.ItemHeight = 15;
            this.lstBoxPacientesBD.Location = new System.Drawing.Point(12, 12);
            this.lstBoxPacientesBD.Name = "lstBoxPacientesBD";
            this.lstBoxPacientesBD.Size = new System.Drawing.Size(792, 364);
            this.lstBoxPacientesBD.TabIndex = 0;
            // 
            // btnModificarBD
            // 
            this.btnModificarBD.Location = new System.Drawing.Point(12, 395);
            this.btnModificarBD.Name = "btnModificarBD";
            this.btnModificarBD.Size = new System.Drawing.Size(152, 60);
            this.btnModificarBD.TabIndex = 1;
            this.btnModificarBD.Text = "Modificar";
            this.btnModificarBD.UseVisualStyleBackColor = true;
            this.btnModificarBD.Click += new System.EventHandler(this.btnModificarBD_Click);
            // 
            // btnAgregarBD
            // 
            this.btnAgregarBD.Location = new System.Drawing.Point(170, 395);
            this.btnAgregarBD.Name = "btnAgregarBD";
            this.btnAgregarBD.Size = new System.Drawing.Size(152, 60);
            this.btnAgregarBD.TabIndex = 2;
            this.btnAgregarBD.Text = "Agregar";
            this.btnAgregarBD.UseVisualStyleBackColor = true;
            this.btnAgregarBD.Click += new System.EventHandler(this.btnAgregarBD_Click);
            // 
            // btnEliminarBD
            // 
            this.btnEliminarBD.Location = new System.Drawing.Point(328, 395);
            this.btnEliminarBD.Name = "btnEliminarBD";
            this.btnEliminarBD.Size = new System.Drawing.Size(152, 60);
            this.btnEliminarBD.TabIndex = 3;
            this.btnEliminarBD.Text = "Eliminar";
            this.btnEliminarBD.UseVisualStyleBackColor = true;
            this.btnEliminarBD.Click += new System.EventHandler(this.btnEliminarBD_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(486, 434);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 21);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "lblFecha";
            // 
            // FormBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 477);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnEliminarBD);
            this.Controls.Add(this.btnAgregarBD);
            this.Controls.Add(this.btnModificarBD);
            this.Controls.Add(this.lstBoxPacientesBD);
            this.Name = "FormBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBaseDeDatos";
            this.Load += new System.EventHandler(this.FormBaseDeDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxPacientesBD;
        private System.Windows.Forms.Button btnModificarBD;
        private System.Windows.Forms.Button btnAgregarBD;
        private System.Windows.Forms.Button btnEliminarBD;
        private System.Windows.Forms.Label lblFecha;
    }
}