namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnMunicipio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.Location = new System.Drawing.Point(46, 43);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(164, 23);
            this.btnDepartamento.TabIndex = 0;
            this.btnDepartamento.Text = "Gestion Departamento";
            this.btnDepartamento.UseVisualStyleBackColor = true;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnMunicipio
            // 
            this.btnMunicipio.Location = new System.Drawing.Point(46, 82);
            this.btnMunicipio.Name = "btnMunicipio";
            this.btnMunicipio.Size = new System.Drawing.Size(164, 23);
            this.btnMunicipio.TabIndex = 1;
            this.btnMunicipio.Text = "Gestion Municipio";
            this.btnMunicipio.UseVisualStyleBackColor = true;
            this.btnMunicipio.Click += new System.EventHandler(this.btnMunicipio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(46, 123);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 226);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMunicipio);
            this.Controls.Add(this.btnDepartamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnMunicipio;
        private System.Windows.Forms.Button btnSalir;
    }
}

