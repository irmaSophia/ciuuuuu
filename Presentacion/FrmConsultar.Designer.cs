namespace Presentacion
{
    partial class FrmConsultar
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
            this.grillaDepartamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDepartamentos
            // 
            this.grillaDepartamentos.AllowUserToAddRows = false;
            this.grillaDepartamentos.AllowUserToDeleteRows = false;
            this.grillaDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDepartamentos.Location = new System.Drawing.Point(12, 22);
            this.grillaDepartamentos.Name = "grillaDepartamentos";
            this.grillaDepartamentos.ReadOnly = true;
            this.grillaDepartamentos.RowHeadersWidth = 51;
            this.grillaDepartamentos.RowTemplate.Height = 24;
            this.grillaDepartamentos.Size = new System.Drawing.Size(374, 302);
            this.grillaDepartamentos.TabIndex = 0;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 386);
            this.Controls.Add(this.grillaDepartamentos);
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaDepartamentos;
    }
}