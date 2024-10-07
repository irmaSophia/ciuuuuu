using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMunicipio());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmDepartamento());
        }

        void AbrirFormulario(Form f)
        {
            f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
